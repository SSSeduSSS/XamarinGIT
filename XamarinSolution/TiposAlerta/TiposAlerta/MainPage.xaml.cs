using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TiposAlerta
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.botonsimple.Clicked += async (sender, args) =>
              {
                  //Tercer argumento es boton de CANCEl
                  await DisplayAlert("Titulo del mensaje", "Cuerpo del mensaje", "Cancelar");
              };

            this.botonokcancel.Clicked +=   Botonokcancel_ClickedAsync;
            this.botonopciones.Clicked += Botonopciones_Clicked;
            this.botonmodal.Clicked += async (sender, args) =>
             {
                 PaginaModal pagina = new PaginaModal();
                 await Navigation.PushModalAsync(pagina);
             };
        }

        private async void Botonopciones_Clicked(object sender, EventArgs e)
        {
            String respuesta = await
                DisplayActionSheet("Texto 1","Cancelar","Aceptar","Opcion1", "Opcion2",
                "Opcion3");
            this.lblRespuesta.Text = respuesta;
        }

        private async  void Botonokcancel_ClickedAsync(object sender, EventArgs e)
        {
            bool respuesta = 
                await DisplayAlert("Titulo","¿Todo bien?","Yes","No");

            if(respuesta==true)
            {
                this.lblRespuesta.Text = "SI";
            }
            else
            {
                this.lblRespuesta.Text = "NO";
            }

        }
    }
}
