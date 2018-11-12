using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TORutina
    {

        public int Clave { get; set; }

        public String Fecha { get; set; }

        public String Nombre { get; set; }

        public List<TOEjercicio> Ejercicios
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

        private List<TOEjercicio> ejercicios = new List<TOEjercicio>();

        public TORutina(int clave, string fecha, string nombre, List<TOEjercicio> ejecicios)
        {
            Clave = clave;
            Fecha = fecha;
            Nombre = nombre;
            this.ejercicios = ejecicios;
        }

        public TORutina() { }

    }
}
