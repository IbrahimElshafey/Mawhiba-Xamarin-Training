using System.Transactions;
using MawhibaSample.XamlExtensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage
    {
        public HomePage()
        {
            InitializeComponent();
            SideMenuList.ItemsSource = new[] {TranslateExtension.Translate("Services"), TranslateExtension.Translate("Contact Us") };
            MainPageNavigationArea.PushAsync(new ServicesListPage());
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)  
        {
            switch (e.ItemIndex)
            {
                case 0:await MainPageNavigationArea.PushAsync(new ServicesListPage()); break;
                case 1:await MainPageNavigationArea.PushAsync(new ContactUsPage()); break;
            }

            this.IsPresented = false;
            //await DisplayAlert("Value",e.Item.ToString(),"OK");
            //Navigate to page
        }
    }
}