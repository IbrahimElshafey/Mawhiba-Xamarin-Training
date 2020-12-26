using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample
{
    public partial class App : Application
    {
        public static NavigationPage MainNavigationPage { get; private set; }
        public App()
        {
            InitializeComponent();

            MainNavigationPage = new NavigationPage(new LoginPage());
            MainPage = MainNavigationPage; 
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
