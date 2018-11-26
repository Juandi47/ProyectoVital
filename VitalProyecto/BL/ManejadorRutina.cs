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

        public List<Ejercicio> pasarAEjercicios(List<HojaRutina> hojas)
        {

            Rutina rutina = new Rutina();

            List<Ejercicio> ejercicios = new List<Ejercicio>();

            ManejadorEjercicio manejador = new ManejadorEjercicio();

            DAORutina dao = new DAORutina();

            foreach (HojaRutina x in hojas)
            {
                Ejercicio ejercicio = new Ejercicio();
                ejercicio.Clave = 0;
                ejercicio.Nombre = x.Ejercicio;
                ejercicio.Repeticiones = x.Repeticiones;
                ejercicio.Series = x.Series;

                ejercicios.Add(ejercicio);
            }

            return ejercicios;
        }

        public TORutina rutinaATO(Rutina rutina) {
            ManejadorEjercicio manejo = new ManejadorEjercicio();
            List<TOEjercicio> toEjercicio = manejo.pasarListaBLaTO(rutina.Ejercicios);

            return new TORutina(0,rutina.Fecha,rutina.Nombre,toEjercicio);
        }

        public void agregarRutina(Rutina rutina) {
            DAORutina dao = new DAORutina();
            dao.agregarRutina(rutinaATO(rutina));

        }

        public String rutinaAleatoria() {

            DAORutina dao = new DAORutina();

            return dao.rutinaAleatoria();
        }

        public Boolean existenciaRutina(String nombre) {
            DAORutina dao = new DAORutina();
            return dao.verificarExistenciaRutina(nombre);
        }
    }
}
