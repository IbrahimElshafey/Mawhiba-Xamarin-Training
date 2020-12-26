using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
namespace MawhibaSample.Common
{
   public class AppSettings
    {
        public static bool IsEnglish
        {
            get => bool.Parse(Preferences.Get("IsEnglish","true"));
            set => Preferences.Set("IsEnglish", value.ToString());
        }
    }
}
