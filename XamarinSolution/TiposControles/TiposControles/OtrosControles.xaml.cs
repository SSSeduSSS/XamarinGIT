using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposControles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OtrosControles : ContentPage
	{
        bool ventanaActiva;
		public OtrosControles ()
		{
			InitializeComponent ();
            this.progreso.Progress = 0;

            this.slider1.ValueChanged += Slider1_ValueChanged;
            this.stepper1.ValueChanged += Stepper1_ValueChanged;
		}

        private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.lblStepper.Text = "Stepper : " + e.NewValue;
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.lblSlider.Text = "Slider: " +e.NewValue;
        }

        protected override void OnAppearing()
        {
            //Cuando la ventana aparece se ejecuta este método
            base.OnAppearing();
            this.ventanaActiva = true;
            //Device se comunica con el sistema operativo del dispositivo
            //StartTimer es compatible con todos los OS
            
            //Cada 0.1 Segundos hace una llamada a TimerCallBack
            Device.StartTimer(TimeSpan.FromSeconds(0.1),TimerCallBack);
        }

        bool TimerCallBack ()
        {
            this.progreso.Progress += 0.01;

            //Si llega a 1 o si se cierra la ventana realiza un return
            return ventanaActiva || this.progreso.Progress == 1;
        }

        protected override void OnDisappearing()
        {
            //Cuando la ventana desaparece se ejecuta este método
            base.OnDisappearing();
            this.ventanaActiva = false;
        }
    }
}