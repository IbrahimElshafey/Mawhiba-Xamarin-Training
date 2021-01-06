using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MawhibaSample.Models
{
    public class ServiceItem
    {
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceHomeImageUrl { get; set; }
        public ImageSource Image { get; set; }
        public int Id { get; set; }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            //after receive object
            if(string.IsNullOrWhiteSpace(ServiceHomeImageUrl))
                Image = ImageSource.FromResource("logo.png");
            Image = ImageSource.FromUri(new Uri(ServiceHomeImageUrl));
        }
    }
}
