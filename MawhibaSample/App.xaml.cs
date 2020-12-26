using System;
using System.Globalization;
using MawhibaSample.Common;
using MawhibaSample.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample
{
    public partial class App : Application
    {
        public static NavigationPage MainNavigationPage { get; private set; }
        public static User CurrentUser { get; set; }
        public static bool IsEnglish { get; set; } = true;
        public static FlowDirection FlowDirection => IsEnglish ? FlowDirection.LeftToRight : FlowDirection.RightToLeft;

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
