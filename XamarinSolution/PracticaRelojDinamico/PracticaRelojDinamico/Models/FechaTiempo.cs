using System;


namespace PracticaRelojDinamico.Models
{
    class FechaTiempo
    {
        DateTime ahora;
        public FechaTiempo()
        {
            this.ahora = DateTime.Now;
        }
        public String Dia ()
        {
            return this.ahora.DayOfWeek.ToString();
        }

        public String Mes()
        {
            return this.ahora.ToString("MMM");
        }
        public String Year()
        {
            return this.ahora.Year.ToString();
        }
        public String Hora()
        {

            return this.ahora.TimeOfDay.Hours.ToString();
        }

        public String Minutos()
        {

            return this.ahora.TimeOfDay.Minutes.ToString();
        }

        public String Segundos()
        {

            return this.ahora.TimeOfDay.Seconds.ToString();
        }
    }
}
