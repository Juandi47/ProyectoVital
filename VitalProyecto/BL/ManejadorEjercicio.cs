using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class ManejadorEjercicio
    {
        public List<Ejercicio> pasarListaTOaBL(List<TOEjercicio> to) {
            List<Ejercicio> lista = new List<Ejercicio>();

            foreach (TOEjercicio x in to)
            {
                Ejercicio ejercicio = new Ejercicio();

                ejercicio.Clave = x.Clave;
                ejercicio.Nombre = x.Nombre;
                ejercicio.Series = x.Series;
                ejercicio.Repeticiones = x.Repeticiones;

                lista.Add(ejercicio);
            }


            return lista;
        }

        public List<HojaEjercicio> mostrarEjercicios()
        {
            DAORutina dao = new DAORutina();

            List<HojaEjercicio> lista = new List<HojaEjercicio>();

            List<TOEjercicio> to = dao.CargarEjercicios();

            foreach (TOEjercicio x in to)
            {
                HojaEjercicio hojaEjercicio = new HojaEjercicio();
                hojaEjercicio.Ejercicio = x.Nombre;

                lista.Add(hojaEjercicio);
            }


            return lista;
        }

        public void agregarEjercicio(String ejercicio) {
            DAORutina dao = new DAORutina();

            dao.agregarEjercicio(ejercicio);
        }

        public void eliminarEjercicio(String ejercicio) {
            DAORutina dao = new DAORutina();

            dao.eliminarEjercicio(ejercicio);
        }
    }
}
