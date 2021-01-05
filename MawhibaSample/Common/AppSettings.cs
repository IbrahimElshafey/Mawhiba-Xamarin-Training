using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MawhibaSample.Common
{
   public class AppSettings
    {
        public static bool IsEnglish
        {
            get => bool.Parse(Preferences.Get("IsEnglish","true"));
            set => Preferences.Set("IsEnglish", value.ToString());
        }

        public static async Task<string> GetUserName()
        {
            return await SecureStorage.GetAsync("UserName");
        }
        public static async Task SetUserName(string userName)
        {
            await SecureStorage.SetAsync("UserName",userName);
        }

        public static async Task<string> GetPassword()
        {
            return await SecureStorage.GetAsync("Password");
        }
        public static async Task SetPassword(string password)
        {
            await SecureStorage.SetAsync("Password",password);
        }

        public static FlowDirection FlowDirection => IsEnglish ? FlowDirection.LeftToRight : FlowDirection.RightToLeft;
    }
}
