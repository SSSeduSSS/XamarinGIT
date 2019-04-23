using PaginasBindings.Models;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBindings
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BindingClases : ContentPage
	{
        public Jugador MiJugador { get; set; }
		public BindingClases ()
		{
			InitializeComponent ();

            this.MiJugador.Nombre = "Salchichas";
            this.MiJugador.Equipo = "Frankfurt CD";
            this.MiJugador.Imagen = "a469a.png";
            this.MiJugador.Descripcion = "Nice player bro.";
            BindingContext = MiJugador;
        }
	}
}