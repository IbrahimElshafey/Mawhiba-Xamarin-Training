using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage
    {
        public HomePage()
        {
            InitializeComponent();
            SideMenuList.ItemsSource = new[] {"Page One", "Page Two"};
            Detail = new ContactUsPage();
            //MainPageNavigationArea.PushAsync(new PageOne());
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)  
        {
            switch (e.ItemIndex)
            {
                case 0: Detail=(new ContactUsPage()); break;
                case 1: Detail=(new ServicesListPage()); break;

                    //case 0: MainPageNavigationArea=new NavigationPage(new PageOne()); break;
                    //case 1: MainPageNavigationArea=new NavigationPage(new PageTwo()); break;
            }

            this.IsPresented = false;
            //await DisplayAlert("Value",e.Item.ToString(),"OK");
            //Navigate to page
        }
    }
}