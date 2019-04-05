using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypesLayout.CodeViews;
using TypesLayout.XamlViews;
using Xamarin.Forms;

namespace TypesLayout
{
    public partial class MainPage : ContentPage

    {

        public MainPage()

        {

            InitializeComponent();

            this.botonstack.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new ViewStackLayout());

            this.botonabsoluteayout.Clicked+= async (sender, args) =>
             await Navigation.PushAsync(new AbsoluteLayoutView());

            this.botonflexLayout.Clicked += async (sender, args) =>
              await Navigation.PushAsync(new FlexLayoutCodeView());

            this.botonframe.Clicked += async (sender, args) =>
             await Navigation.PushAsync(new CodeViews.FrameView());

            this.botonscrollView.Clicked += async (sender, args) =>
             await Navigation.PushAsync(new ScrollViewPageCode());


            //this.botonstack.Clicked +=Botonstack;

        }



        //private async void Botonstack_Clicked(object sender, EventArgs e)

        //{

        //    await Navigation.PushAsync(new ViewStackLayout());

        //}

    }
}
