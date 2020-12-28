using System.Globalization;
using System.Threading;
using MawhibaSample.Common;
using MawhibaSample.Services;
using MawhibaSample.Views;
using Xamarin.Forms;

namespace MawhibaSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainNavigationPage = new NavigationPage(new LoginPage());
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