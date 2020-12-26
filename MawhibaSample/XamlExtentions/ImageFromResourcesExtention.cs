using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.XamlExtensions
{
    [ContentProperty(nameof(ImageName))]
    class ImageFromResourcesExtension:IMarkupExtension
    {
        
        public string ImageName { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource($"MawhibaSample.{ImageName}", typeof(ImageFromResourcesExtension).GetTypeInfo().Assembly);
        }
    }
}
