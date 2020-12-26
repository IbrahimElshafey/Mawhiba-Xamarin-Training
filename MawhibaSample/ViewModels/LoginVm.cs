using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FluentValidation;
using FluentValidation.Results;
using MawhibaSample.Annotations;
using MawhibaSample.Common;
using MawhibaSample.Services;
using Refit;
using Xamarin.Forms;

namespace MawhibaSample.ViewModels
{
    public class LoginVm : INotifyPropertyChanged
    {
        private string _password;
        private string _userName;

        public string UserName
        {
            get => _userName;
            set
            {
                if (value == _userName) return;
                _userName = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value == _password) return;
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand ChangeLanguageCommand => new Command(async () =>
        {
            var currentCulture = App.IsEnglish ?
                new CultureInfo("ar") :
                new CultureInfo("en");
            CultureInfo.CurrentUICulture = currentCulture;
            //TextResources.Culture = currentCulture;
            App.IsEnglish = !App.IsEnglish;
            App.Current.MainPage = new LoginPage();
        });

        public ICommand LoginCommand =>new Command(async() =>
        {
            var validationResult = ValidateInputs();
            if (validationResult.IsValid)
            {
                //await App.MainNavigationPage.PushAsync(new HomePage());
                var loginClient = RestService.For<ILoginService>($"{AppConstants.BaseUrl}/UserProfile/api");
                var loginResult = await loginClient.Login(UserName, Password);
                if (loginResult?.ResultCode == "RES01")
                {
                    App.CurrentUser = loginResult.ResultObject;
                    App.Current.MainPage = new HomePage();
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Failed", loginResult?.ResultMessage ?? "Undefined Error", "OK");
                    //await DisplayAlert("Failed", loginResult?.ResultMessage ?? "Undefined Error", "OK");
                }
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Failed", validationResult.GetErrors(), "OK");
            }
        });

        private ValidationResult ValidateInputs()
        {
            var validator = new InlineValidator<(string UserName, string Password)>();
            validator
                .RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required")
                .Matches("[A-Za-z1-9]{5,8}");
            validator
                .RuleFor(x => x.UserName)
                .NotEmpty();
            var validationResult = validator.Validate((UserName, Password));
            return validationResult;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}