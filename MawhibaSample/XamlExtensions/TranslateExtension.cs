using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using MawhibaSample.Common;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.XamlExtensions
{
    [ContentProperty(nameof(Value))]
    public class TranslateExtension : IMarkupExtension
    {
        private static Dictionary<string, string> _languagePairs = null;
        public TranslateExtension()
        {
            if (_languagePairs == null)
                _languagePairs = GetLocalizationDictionary();
        }
        public string Value { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Translate(Value);
        }

        public static string Translate(string key)
        {
            if (!AppSettings.IsEnglish && _languagePairs.ContainsKey(key))
                return _languagePairs[key];
            return key;
        }

        public class LanguagePair
        {
            public string En { get; set; }
            public string Ar { get; set; }
        }
        public static Dictionary<string, string> GetLocalizationDictionary()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream($"MawhibaSample.Localization.Localization.json");
            var dic = new Dictionary<string, string>();
            using (var reader = new StreamReader(stream ?? throw new InvalidOperationException()))
            {
                var text = reader.ReadToEnd();
                var list = JsonConvert.DeserializeObject<LanguagePair[]>(text);
                list.ForEach(x =>
                {
                    if (!dic.ContainsKey(x.En))
                        dic.Add(x.En, x.Ar);
                });
            }
            return dic;
        }
    }
}