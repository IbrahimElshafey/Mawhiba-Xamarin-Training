using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MawhibaSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
       

        public TestPage()
        {
            InitializeComponent();
            var x= Grid.GetRow(Label1);
        }

        

        //private async void PlayAnimantion_Clicked(object sender, EventArgs e)
        //{
        //    //await Box.ScaleTo(1.5, 300,Easing.BounceOut);
        //    //await Box.ScaleTo(1, 300, Easing.BounceIn);

        //    //await Task.WhenAll( Box.ScaleXTo(1.5),Box.ScaleYTo(2));
        //    //await Task.WhenAll( Box.ScaleXTo(1),Box.ScaleYTo(1));

        //    //await Box.TranslateTo(200,400,1000);
        //    //await Box.RotateTo(45, 500);


        //    //await Box.RotateXTo(20,1000);
        //    //await Box.RotateYTo(50,2000);

        //    //await Box.RotateXTo(0,1000);
        //    //await Box.RotateYTo(0,2000);
        //    var toggle = true;
        //    while (true)
        //    {
        //        if (toggle)
        //        {
        //            await Box.RotateTo(360);
        //            toggle = false;
        //        }
        //        else
        //        {
        //            await Box.RotateTo(0);
        //            toggle = true;
        //        }

        //    }
        //}
    }
}