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

        public void eliminarRutina(String nombre) {
            DAORutina dao = new DAORutina();
            dao.EliminarRutina(nombre);
        }

        public List<HojaRutina> MostrarRutina(String nombre)
        {

            Rutina rutina = new Rutina();

            List<Ejercicio> ejercicios;

            List<HojaRutina> hojas = new List<HojaRutina>();

            TORutina toRutina = new TORutina();

            ManejadorEjercicio manejador = new ManejadorEjercicio();

            DAORutina dao = new DAORutina();

            toRutina = dao.CargarRutina(nombre);

            ejercicios = manejador.pasarListaTOaBL(toRutina.Ejercicios);

            foreach (Ejercicio x in ejercicios)
            {
                HojaRutina hoja = new HojaRutina();
                hoja.Ejercicio = x.Nombre;
                hoja.Repeticiones = x.Repeticiones;
                hoja.Series = x.Series;

                hojas.Add(hoja);
            }

            return hojas;
        }
    }
}
