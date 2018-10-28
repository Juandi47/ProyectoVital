using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TO;

namespace DAO
{
    public class DAORutina
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

        


        public List<TORutina> CargarRutinas() {

            DataTable tabla = new DataTable();

            List<TORutina> lista = new List<TORutina>();

            String query = "select * from Rutina";

            SqlDataAdapter adapter = new SqlDataAdapter(query,conexion);

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows)
            {
                TORutina rutina = new TORutina();
                rutina.Clave = Int32.Parse(x["Clave_Rutina"].ToString());
                rutina.Fecha = x["Fecha_Creacion"].ToString();
                rutina.Nombre = x["Nombre"].ToString();
                rutina.Ejercicios = CargarEjercicioRutina(Int32.Parse(x["Clave_Rutina"].ToString()));

                lista.Add(rutina);
            }

            return lista;
        }

        public List<TOEjercicio> CargarEjercicioRutina(int claveRutina)
        {
            DataTable tabla = new DataTable();

            List<TOEjercicio> lista = new List<TOEjercicio>();

            string query = "select Ejercicio.*, Ejercicios_Rutina.Numero_Series,Ejercicios_Rutina.Repeticiones from Ejercicio, Ejercicios_Rutina where Ejercicios_Rutina.Clave_Rutina = @claRu and Ejercicios_Rutina.Clave_Ejercicio = Ejercicio.Clave_Ejercicio;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            adapter.SelectCommand.Parameters.AddWithValue("@claRu",claveRutina);

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows)
            {
                
                TOEjercicio ejercicio = new TOEjercicio();
                ejercicio.Clave = int.Parse(x["Clave_Ejercicio"].ToString());
                ejercicio.Nombre = x["Nombre"].ToString();
                ejercicio.Categoria = x["Categoria"].ToString();
                ejercicio.Descripcion = x["Descripcion_Ejercicio"].ToString();
                ejercicio.Series = Int32.Parse(x["Numero_Series"].ToString());
                ejercicio.Repeticiones = Int32.Parse(x["Repeticiones"].ToString());

                lista.Add(ejercicio);
            }

            return lista;
        }
    }
}
