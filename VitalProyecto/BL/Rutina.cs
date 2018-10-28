using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rutina
    {
        public int Clave { get; set; }

        public String Fecha { get; set; }

        public String Nombre { get; set; }

        public List<Ejercicio> Ejercicios
        {
            get
            {
                return ejercicios;
            }

            set
            {
                ejercicios = value;
            }
        }

        private List<Ejercicio> ejercicios = new List<Ejercicio>();

        public Rutina(int clave, string fecha, string nombre, List<Ejercicio> ejecicios)
        {
            Clave = clave;
            Fecha = fecha;
            Nombre = nombre;
            this.ejercicios = ejecicios;
        }

        public Rutina() { }
    }
}
