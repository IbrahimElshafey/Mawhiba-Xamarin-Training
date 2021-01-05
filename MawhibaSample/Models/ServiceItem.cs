using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MawhibaSample.Models
{
    public class ServiceItem
    {
        public string ServiceName { get; set; }
        public string ImageUrl { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceHomeImageUrl { get; set; }
        public int Id { get; set; }
    }
}
