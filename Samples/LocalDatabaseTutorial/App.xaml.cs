using System;
using System.IO;
using Xamarin.Forms;

namespace LocalDatabaseTutorial
{
    public partial class App : Application
    {
        private static Database _database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static Database Database =>
            _database ?? (_database = new Database(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3")));

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}