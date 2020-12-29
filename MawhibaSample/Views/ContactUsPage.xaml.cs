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
        }

        public List<KeyValuePair<string,int>> RadioItems => new List<KeyValuePair<string, int>>
        {
           new KeyValuePair<string, int>("Item 1",1),
           new KeyValuePair<string, int>("Item 2",2),
           new KeyValuePair<string, int>("Item 3",3),
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