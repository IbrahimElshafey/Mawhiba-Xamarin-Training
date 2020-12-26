using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using MawhibaSample.Services;
using Refit;
using Xamarin.Forms;

namespace MawhibaSample
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var userName = UserNameEntry.Text;
            var password = PasswordNameEntry.Text;
            var validator = new InlineValidator<(string UserName, string Password)>();
            validator
                .RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required")
                .Matches("[A-Za-z1-9]{5,8}");
            validator
                .RuleFor(x => x.UserName)
                .NotEmpty();
            var validationResult = validator.Validate((userName, password));
            if (validationResult.IsValid)
            {
                //await App.MainNavigationPage.PushAsync(new HomePage());
                var loginClient = RestService.For<ILoginService>("http://testapi.mawhiba.org/UserProfile/api");
                var loginResult = await loginClient.Login(userName,password);
                await DisplayAlert("Failed", loginResult.ResultMessage, "OK");
            }
            else
            {
                await DisplayAlert("Failed", GetErrors(validationResult), "OK");
            }
        }

        public string GetErrors(ValidationResult validationResult)
        {
            if (validationResult != null && !validationResult.IsValid)
            {
                var sb = new StringBuilder();
                sb.AppendLine();
                foreach (var validationResultError in validationResult.Errors)
                {
                    sb.Append("* ");
                    sb.Append(validationResultError.ErrorMessage);
                    sb.AppendLine();
                }

                return sb.ToString();
            }

            return null;
        }
    }
}
