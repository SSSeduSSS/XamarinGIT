using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TypesLayout.CodeViews
{
	public class FrameView : ContentPage
	{
		public FrameView ()
		{
            StackLayout stack = new StackLayout()
            {
                Margin = new Thickness(0,40,0,0)
            };
            Label header = new Label()
            {
                Text="Frame View Code",
                TextColor=Color.Cyan,
                FontSize=20,
                HorizontalOptions=LayoutOptions.FillAndExpand
            };

            stack.Children.Add(header);
            Frame frame = new Frame()
            {
                BorderColor = Color.LawnGreen
            };
            stack.Children.Add(frame);

            Label lbl  = new Label()
            {
                Text = "amlsamdsla dasld sad sla dsla dsaldlsajkdsladksaldillaf "              
            };

            frame.Content = lbl;
            this.Content = stack;
        }
	}
}