using System;
using System.Collections.Generic;
using System.Text;

namespace MawhibaSample.Models
{
    public class ServiceItem
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Url { get; set; } = "http://www.google.com";
    }
}
