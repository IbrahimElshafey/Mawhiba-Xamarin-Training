using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace MawhibaSample.Droid
{
    [Activity(Label = "Training", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SubscribeToErrors();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void SubscribeToErrors()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;

            void TaskSchedulerOnUnobservedTaskException(object sender,
                UnobservedTaskExceptionEventArgs unobservedTaskExceptionEventArgs)
            {
                var newExc = new Exception("TaskSchedulerOnUnobservedTaskException",
                    unobservedTaskExceptionEventArgs.Exception);
                LogUnhandledException(newExc);
            }

            void CurrentDomainOnUnhandledException(object sender,
                UnhandledExceptionEventArgs unhandledExceptionEventArgs)
            {
                var newExc = new Exception("CurrentDomainOnUnhandledException",
                    unhandledExceptionEventArgs.ExceptionObject as Exception);
                //Crashes.TrackError(newExc);
                LogUnhandledException(newExc);
            }

            void LogUnhandledException(Exception exception)
            {
                try
                {
                    // Log to Android Device Logging.
                    Log.Error("Crash Report", exception.Message);
                }
                catch
                {
                    // just suppress any error logging exceptions
                }
            }
            //Crashes.GenerateTestCrash();
        }
    }
}