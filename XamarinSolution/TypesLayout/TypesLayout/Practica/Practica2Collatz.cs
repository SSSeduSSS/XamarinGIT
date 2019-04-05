using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TypesLayout.Practica
{
	public class Practica2Collatz : ContentPage
	{
        StackLayout stack1;
        public Practica2Collatz ()
		{

             stack1 = new StackLayout()
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

            ScrollView scroll1 = new ScrollView();
            scroll1.Orientation = ScrollOrientation.Horizontal;

            //Añadimos el scroll al layout principal
            stack1.Children.Add(scroll1);


            FlexLayout contenedor = new FlexLayout();
            contenedor.Direction = FlexDirection.Row;
            contenedor.BackgroundColor = Color.YellowGreen;
            contenedor.VerticalOptions = LayoutOptions.Center;

            for(int i=0; i<15; i++)
            {
                Button boton = new Button();
                boton.Text = i.ToString();
                boton.HorizontalOptions = LayoutOptions.Center;
              
                boton.Clicked +=  (sender, args) =>CalculaCollazts(int.Parse(boton.Text));

                contenedor.Children.Add(boton);
            }
            scroll1.Content = contenedor;
            this.Content = stack1; //IMPORTANTE
        }

        private void CalculaCollazts(int num)
        {
            StackLayout stack2 = new StackLayout();
            ScrollView scroll2 = new ScrollView();
            scroll2.Orientation = ScrollOrientation.Vertical;

            //Añadimos el scroll al layout principal
            stack1.Children.Add(scroll2);


            StackLayout contenedor2 = new StackLayout();
            contenedor2.BackgroundColor = Color.YellowGreen;
            contenedor2.VerticalOptions = LayoutOptions.FillAndExpand;

            int numero = num;

            while (numero != (1))
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = (numero * 3) + 1;
                }

                Label lbl = new Label();
                lbl.Text = numero.ToString();
                contenedor2.Children.Add(lbl);
            }

            scroll2.Content = (contenedor2);
            //this.Content = this.Content + stack2; //IMPORTANTE
        }
    }
}