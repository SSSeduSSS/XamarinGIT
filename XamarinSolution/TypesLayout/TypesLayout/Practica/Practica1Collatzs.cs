using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TypesLayout.Practica
{
	public class Practica1Collatzs : ContentPage
	{
        StackLayout stackppal;
        Entry cajaText;

        public Practica1Collatzs ()
		{
             stackppal = new StackLayout()
            {
                Margin = new Thickness(0, 40, 0, 0)
            };

            Label header = new Label()
            {
                Text = "COLLATZ ",
                TextColor = Color.Black,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };


            cajaText = new Entry();
            cajaText.BackgroundColor = Color.LightGray;
            cajaText.FontSize = 20;
            //cajaText.Text = "Añade un numero";

            stackppal.Children.Add(cajaText);


            stackppal.Children.Add(header);

            Button boton = new Button();
            boton.Text = "Mostrar";
            boton.HorizontalOptions = LayoutOptions.CenterAndExpand;

            stackppal.Children.Add(boton);
            
            this.Content = stackppal; //IMPORTANTE

            boton.Clicked += Boton_Clicked;
        }

        private void Boton_Clicked(object sender, EventArgs e)
        {
            
            ScrollView scroll = new ScrollView();
            scroll.Orientation = ScrollOrientation.Vertical;

            //Añadimos el scroll al layout principal
            stackppal.Children.Add(scroll);


            StackLayout contenedor = new StackLayout();
            contenedor.BackgroundColor = Color.YellowGreen;
            contenedor.VerticalOptions = LayoutOptions.FillAndExpand;
                                 
            int numero = int.Parse(cajaText.Text);
           
            while (numero!=(1))
            {
                if(numero % 2==0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = (numero*3)+1;
                }

                Label lbl = new Label();
                lbl.Text = numero.ToString();
                contenedor.Children.Add(lbl);
            }

            scroll.Content = (contenedor);         

        }
    }
}