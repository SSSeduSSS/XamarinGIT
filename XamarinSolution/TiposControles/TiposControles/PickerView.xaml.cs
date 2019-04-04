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
    public partial class PickerView : ContentPage
    {
        List<String> ingredientes;
        public PickerView()
        {
            InitializeComponent();
            ingredientes = new List<String>() { };
            foreach (String s in ingredientes)
            {
                this.picker1.Items.Add(s);
            }
            //Es otra forma de crear el evento, con función anónima
            this.picker1.SelectedIndexChanged += (sender, args) =>
             {
                 int indice = this.picker1.SelectedIndex;
                 if(indice==-1)
                 {
                     this.lblPicker.Text = "No ha seleccionado nada";
                 }
                 else
                 {
                     this.lblPicker.Text = "Ha seleccionado: "+ this.ingredientes[indice];
                 }
             };
        }

    }

}