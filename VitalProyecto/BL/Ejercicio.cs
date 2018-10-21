using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Ejercicio
    {
        public Ejercicio(int clave, string nombre, string categoria, string descripcion)
        {
            Clave = clave;
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
        }

        public Ejercicio() { }

        public int Clave { get; set; }

        public String Nombre { get; set; }

        public String Categoria { get; set; }

        public String Descripcion { get; set; }

        public int Repeticiones { get; set; }

        public int Series { get; set; }

    }
}
