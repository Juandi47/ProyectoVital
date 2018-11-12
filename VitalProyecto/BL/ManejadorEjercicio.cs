using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

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
                ejercicio.Categoria = x.Categoria;
                ejercicio.Descripcion = x.Descripcion;
                ejercicio.Series = x.Series;
                ejercicio.Repeticiones = x.Repeticiones;

                lista.Add(ejercicio);
            }


            return lista;
        }
    }
}
