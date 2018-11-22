using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HojaRutina
    {

        public HojaRutina(string ejercicio, int repeticiones, int series)
        {
            Ejercicio = ejercicio;
            Repeticiones = repeticiones;
            Series = series;
        }

        public HojaRutina() { }
        

        public String Ejercicio { get; set; }

        public int Repeticiones { get; set; }

        public int Series { get; set; }
    }
}
