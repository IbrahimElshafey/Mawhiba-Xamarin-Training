using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactUsPage : ContentPage
    {
        public ContactUsPage()
        {
            InitializeComponent();
            ServicePicker.FontFamily = "FAR";
        }

        public List<KeyValuePair<string,int>> TopicsList => new List<KeyValuePair<string, int>>
        {
           new KeyValuePair<string, int>("إستفسار",2),
           new KeyValuePair<string, int>("ملاحظة",5),
           new KeyValuePair<string, int>("إقتراح",3),
           new KeyValuePair<string, int>("آخرى",3),
        };
        private KeyValuePair<string, int> _selectedRadio;
        public KeyValuePair<string,int> SelectedRadio
        {
            get => _selectedRadio;
            set
            {
                if (Equals(value, _selectedRadio)) return;
                _selectedRadio = value;
                DisplayAlert("Radio Button", value.Key, "OK");
                OnPropertyChanged();
            }
        }

        public ICommand CheckCommand=>new Command(()=>{
            DisplayAlert("Radio Button", "Clicked", "OK");
        });
    }
}