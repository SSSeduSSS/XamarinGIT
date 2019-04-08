using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposAlerta
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaModal : ContentPage
	{
		public PaginaModal ()
		{
			InitializeComponent ();
            this.botoncerrar.Clicked += async (sender, args) =>
            {
                await Navigation.PopModalAsync();
            };
		}
	}
}