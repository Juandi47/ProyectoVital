using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class ManejadorRutina
    {
        public List<Rutina> CargarRutinas()
        {
            List<Rutina> lista = new List<Rutina>();

            List<TORutina> listaTO = new List<TORutina>();

            ManejadorEjercicio manejador = new ManejadorEjercicio();

            DAORutina dao = new DAORutina();

            listaTO = dao.CargarRutinas();

            foreach (TORutina x in listaTO)
            {
                Rutina rutina = new Rutina();
                rutina.Clave = x.Clave;
                rutina.Fecha = x.Fecha;
                rutina.Nombre = x.Nombre;
                rutina.Ejercicios = manejador.pasarListaTOaBL(x.Ejercicios);

                lista.Add(rutina);
            }

            return lista;

        }
    }
}
