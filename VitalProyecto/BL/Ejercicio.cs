using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Ejercicio
    {
        public Ejercicio(int clave, string nombre)
        {
            Clave = clave;
            Nombre = nombre;
        }

        public Ejercicio() { }

        public int Clave { get; set; }

        public String Nombre { get; set; }

        public int Repeticiones { get; set; }

        public int Series { get; set; }

    }
}
