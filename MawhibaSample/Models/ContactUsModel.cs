using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using MawhibaSample.Annotations;

namespace MawhibaSample.Models
{
    public class ContactUsModel:NotifyPropertyChange
    {
        private string _country;
        public int? ID { get; set;}
        public int? UserID { get; set;}
        public int? MessayType { get; set;}
        public int? MessayTypeText { get; set;}
        public string Name { get; set;}
        public string Specialist { get; set;}

        public string Country
        {
            get => _country;
            set => SetProperty(ref _country,value);
        }

        public string City { get; set;}
        public string Department { get; set;}
        public string PhoneNumber { get; set;}
        public string FaxNumber { get; set;}
        public string Email { get; set;}
        public string MessageBody { get; set;}
        public int? SupportTypeId { get; set;}
        public string SupportTypeName { get; set;}
        public int? ServiceId { get; set;}
        public string ServiceName { get; set;}
        public string AttachmentURL { get; set;}

    }
}
