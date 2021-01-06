using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using MawhibaSample.Common;
using MawhibaSample.Services;
using MawhibaSample.ViewModels;
using MawhibaSample.Views;
using Xamarin.Forms;

[assembly: ExportFont("Free-Regular-400.otf", Alias = "FAR")]//font is invalid 
[assembly: ExportFont("Free-Solid-900.otf", Alias = "FAS")]
[assembly: ExportFont("Tajawal-Regular.ttf", Alias = "TR")]
[assembly: ExportFont("Tajawal-Bold.ttf", Alias = "TB")]
namespace MawhibaSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //SetStartUpPage();
            //MainNavigationPage = new NavigationPage(new LoginPage());
            //MainNavigationPage = new NavigationPage(new ContactUsPage());
            MainNavigationPage = new NavigationPage(new TestPage());
            MainPage = MainNavigationPage;
        }

        private async Task SetStartUpPage()
        {
            var userName = await AppSettings.GetUserName();
            var loginPage = new LoginPage();
            var isUserExist = !string.IsNullOrWhiteSpace(userName);
            if (isUserExist)
            {
                if (loginPage.BindingContext is LoginVm loginVm)
                {
                    loginVm.UserName = userName;
                    loginVm.Password = await AppSettings.GetPassword();
                    loginVm.LoginCommand.Execute(null);
                }
            }
            MainNavigationPage = new NavigationPage(loginPage);
            MainPage = MainNavigationPage;
        }

        public static NavigationPage MainNavigationPage { get; private set; }
        public static User CurrentUser { get; set; }

        public static void ChangeLanguage()
        {
            //var currentCulture = AppSettings.IsEnglish ? new CultureInfo("ar") : new CultureInfo("en");
            //Thread.CurrentThread.CurrentUICulture = currentCulture;
            //CultureInfo.CurrentUICulture = currentCulture;
            //TextResources.Culture = currentCulture;
            AppSettings.IsEnglish = !AppSettings.IsEnglish;
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}