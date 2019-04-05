using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TypesLayout.CodeViews
{
    public class ScrollViewPageCode : ContentPage
    {
        public ScrollViewPageCode()
        {
            StackLayout stackppal = new StackLayout()
            {
                Margin = new Thickness(0, 40, 0, 0)
            };

            Label header = new Label()
            {
                Text = "Scroll  View Code",
                TextColor = Color.LavenderBlush,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            stackppal.Children.Add(header);

            //Creamos el scrollVIEW
            ScrollView scroll = new ScrollView();
            scroll.Orientation = ScrollOrientation.Vertical;

            //Añadimos el scroll al layout principal
            stackppal.Children.Add(scroll);

            //Dentro del scroll solamente podemos tener un control
            //para poder tener más elementos le añadimos al scroll
            //un LAYOUT para poder meter más controles ahí entro

            StackLayout contenedor = new StackLayout();
            contenedor.BackgroundColor = Color.YellowGreen;
            contenedor.VerticalOptions = LayoutOptions.FillAndExpand;

            //Generamos controles
            for (int i = 0; i < 30; i++)
            {
                Button boton = new Button();
                boton.Text = "Boton => " + i.ToString();
                boton.HorizontalOptions = LayoutOptions.CenterAndExpand;

                contenedor.Children.Add(boton);
            }

            //Indicamos al scroll que objeto tendrá en interior => Solo puede tener uno
            scroll.Content=(contenedor);

            this.Content = stackppal; //IMPORTANTE
        }
    }
}