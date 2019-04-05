using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TypesLayout.CodeViews
{
	public class StackLayoutView : ContentPage
	{
		public StackLayoutView ()
		{
            StackLayout stackppal = new StackLayout();
            stackppal.Margin = new Thickness(0,40,0,0);

            Label header = new Label()
            {
                Text="LABEL",
                FontSize = 40,
                TextColor = Color.DarkBlue,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            stackppal.Children.Add(header);

            Button boton = new Button()
            {
                Text = "BOTON",
                HorizontalOptions = LayoutOptions.Start,
                CornerRadius=2
            };
            stackppal.Children.Add(boton);
            Image img = new Image()
            {
                Source = "https://vignette.wikia.nocookie.net/joke-battles/images/7/70/Chuck.jpg/revision/latest?cb=20180613043330",
                WidthRequest=200,
                HeightRequest=200
            };
            stackppal.Children.Add(img);

            //Añadimos el contenido de la clase CONTENTPAGE
            this.Content = stackppal;
        }
	}
}