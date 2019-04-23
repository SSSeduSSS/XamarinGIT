using PracticaRelojDinamico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracticaRelojDinamico
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ActualizaFecha();
            Device.StartTimer(
                TimeSpan.MinValue, () => { ActualizaFecha(); return true; });

        }

        public void ActualizaFecha()
        {

            FechaTiempo ft = new FechaTiempo();
            this.Dia.Text = "Día " + ft.Dia();
            this.Mes.Text = "Mes " + ft.Mes();
            this.Year.Text = "Año " + ft.Year();



            int gradosHoras = (360 / 24 * int.Parse(ft.Hora()) - 90);
            this.Hora.Rotation = gradosHoras;
            this.Hora.Text = "Hora " + ft.Hora();

            int gradosMinutos = (360 / 60 * int.Parse(ft.Minutos()) - 90);
            this.Minuto.Rotation = gradosMinutos;
            this.Minuto.Text = "Minutos " + ft.Minutos();


            int gradosSegundos = (360 / 60 * int.Parse(ft.Segundos())-90);
            this.Segundo.Text = "Segundos " + ft.Segundos();
            this.Segundo.Rotation = gradosSegundos;
           
            
        }

    }
}
