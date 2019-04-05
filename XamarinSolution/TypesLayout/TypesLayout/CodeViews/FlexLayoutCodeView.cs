using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TypesLayout.CodeViews
{
	public class FlexLayoutCodeView : ContentPage
	{
		public FlexLayoutCodeView ()
		{
            StackLayout stackppal = new StackLayout()
            {
                Margin = new Thickness(0,40,0,0)
            };

            Label header = new Label()
            {
                Text = "FLEX  View Code",
                TextColor = Color.Green,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            stackppal.Children.Add(header);

            FlexLayout flex = new FlexLayout();
            flex.AlignItems = FlexAlignItems.Center;
            flex.Direction = FlexDirection.Column;
            flex.JustifyContent = FlexJustify.Center;
            stackppal.Children.Add(flex);


            Button btn = new Button();
            btn.Text = "Boton dentro de flex";
            btn.TextColor = Color.Blue;

            flex.Children.Add(btn);

            this.Content = stackppal;
            
        }
	}
}