using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOEjercicio
    {
        

        public TOEjercicio() { }

        public TOEjercicio(int clave, string nombre, int repeticiones, int series)
        {
            Clave = clave;
            Nombre = nombre;
            Repeticiones = repeticiones;
            Series = series;
        }

        public int Clave { get; set; }

        public String Nombre { get; set; }

        public int Repeticiones { get; set; }

        public int Series { get; set; }

    }
}

