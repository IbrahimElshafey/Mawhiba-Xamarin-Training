using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using MawhibaSample.Common;
using MawhibaSample.Models;
using MawhibaSample.Services;
using Refit;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.Views
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicesListPage : ContentPage
    {
       

        private List<ServiceItem> _services = new List<ServiceItem>
        {
            new ServiceItem
            {
                ServiceName = "Service One",
                ServiceDescription =
                    "Description Description Description Description Description Description Description Description "
            },
            new ServiceItem
            {
                ServiceName = "Service One",
                ServiceDescription =
                    "Description Description Description Description Description Description Description Description "
            },
            new ServiceItem
            {
                ServiceName = "Service One",
                ServiceDescription =
                    "Description Description Description Description Description Description Description Description "
            }
        };

        public ServicesListPage()
        {
            BindingContext = this;
            InitializeComponent();
            LoadServices();
            //ServicesList.ItemsSource = new string[]
            //{
            //    "Service One",
            //    "Service Two",
            //    "Service Three",
            //    "Service Four",
            //};
        }

        private async Task LoadServices()
        {
            var client = RestService.For<IGeneralService>(AppConstants.BaseUrl);
            var servicesResult = await client.GetServices();
            Services = servicesResult.ResultObject;
        }

        //private async void ServicesList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    await this.DisplayAlert("", "Item Selected", "OK");
        //}

        //private async void ServicesList_OnItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    await this.DisplayAlert("", "Item Tapped", "OK");
        //}
        public ICommand OpenServicePageCommand => new Command<ServiceItem>(async service =>
        {
            await Launcher.OpenAsync(service.ServiceHomeImageUrl);
        });

        public List<ServiceItem> Services
        {
            get => _services;
            set
            {
                if (value == _services) return;
                _services = value;
                OnPropertyChanged();
            }
        }
    }
}