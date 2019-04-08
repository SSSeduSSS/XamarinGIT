using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecursosCore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //He instalado el NUGET  de Xamarin.Forms con la versión que está instalada en ProyectoRecursos
    public partial class EstilosExternos : ResourceDictionary
    {
        public EstilosExternos()
        {
            InitializeComponent();
        }
    }
}