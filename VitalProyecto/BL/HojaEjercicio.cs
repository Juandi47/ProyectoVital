using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HojaEjercicio
    {
        public HojaEjercicio(string ejercicio)
        {
            Ejercicio = ejercicio;
        }

        public HojaEjercicio() { }


        public String Ejercicio { get; set; }
    }
}
