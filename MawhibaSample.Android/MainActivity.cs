using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Platform = Xamarin.Essentials.Platform;

namespace MawhibaSample.Droid
{
    [Activity(Label = "Training", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                               ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SubscribeToErrors();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Platform.Init(this, savedInstanceState);
            Xamarin.Forms.Forms.SetFlags("RadioButton_Experimental");
            Forms.Init(this, savedInstanceState);
            
            //change start to crosponding value to start a sample in below switch
            var start = "LocalDatabaseTutorial";
            switch (start)
            {
                case "OurSample":
                    LoadApplication(new App());
                    break;
                case "Entry_Editor_Label":
                    LoadApplication(new TextSample.App());
                    break;
                case "Picker_1":
                    LoadApplication(new PickerDemo.App());
                    break;
                case "Picker_2":
                    LoadApplication(new BindablePicker.App());
                    break;
                case "CheckBox":
                    LoadApplication(new CheckBoxDemos.App());
                    break;
                case "DatePicker":
                    LoadApplication(new DaysBetweenDates.App());
                    break;
                case "Switch":
                    LoadApplication(new SwitchDemos.App());
                    break;
                case "TimePicker":
                    LoadApplication(new SetTimer.App());
                    break;
                case "RadioButtons":
                    LoadApplication(new RadioButtonDemos.App());
                    break;
                case "Effects":
                    LoadApplication(new RoundEffectDemo.App());
                    break;
                case "EffectParameters":
                    LoadApplication(new EffectsDemo.App());
                    break;
                case "EventToCommandBehavior":
                    LoadApplication(new EventToCommandBehavior.App());
                    break;
                case "AttachedBehavior":
                    LoadApplication(new AttachedNumericValidationBehavior.App());
                    break;
                case "LocalDatabaseTutorial":
                    LoadApplication(new LocalDatabaseTutorial.App());
                    break;
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions,
            [GeneratedEnum] Permission[] grantResults)
        {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

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