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


        public List<TORutina> CargarRutinas()
        {

            DataTable tabla = new DataTable();

            List<TORutina> lista = new List<TORutina>();

            String query = "select * from Rutina order by Fecha_Creacion desc";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows)
            {
                TORutina rutina = new TORutina();
                rutina.Clave = Int32.Parse(x["Clave_Rutina"].ToString());
                rutina.Fecha = x["Fecha_Creacion"].ToString();
                rutina.Nombre = x["Nombre"].ToString().ToUpper();
                rutina.Ejercicios = CargarEjercicioRutina(Int32.Parse(x["Clave_Rutina"].ToString()));

                lista.Add(rutina);
            }

            return lista;
        }

        public TORutina CargarRutina(String nombre)
        {

            DataTable tabla = new DataTable();

            TORutina rutina = new TORutina();

            String query = "select * from Rutina where Nombre = @nom";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            adapter.SelectCommand.Parameters.AddWithValue("@nom", nombre);

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows)
            {
                rutina.Clave = Int32.Parse(x["Clave_Rutina"].ToString());
                rutina.Fecha = x["Fecha_Creacion"].ToString();
                rutina.Nombre = x["Nombre"].ToString().ToUpper();
                rutina.Ejercicios = CargarEjercicioRutina(Int32.Parse(x["Clave_Rutina"].ToString()));

            }

            return rutina;
        }

        public String rutinaAleatoria()
        {

            DataTable tabla = new DataTable();

            TORutina rutina = new TORutina();

            String query = "SELECT TOP 1 Nombre from Rutina ORDER BY NEWID()";

            SqlCommand comando = new SqlCommand(query, conexion);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            String nombre = (String)comando.ExecuteScalar();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }


            return nombre;
        }

        public void EliminarRutina(String Nombre)
        {

            int clave = buscarClaveRutina(Nombre);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            String query = "delete from Rutina where Nombre = @nom";

            String query2 = "delete from Ejercicios_Rutina where Clave_Rutina = @clave";

            SqlCommand comando1 = new SqlCommand(query, conexion);

            SqlCommand comando2 = new SqlCommand(query2, conexion);

            comando1.Parameters.AddWithValue("@nom", Nombre);

            comando2.Parameters.AddWithValue("@clave", clave);

            comando2.ExecuteNonQuery();

            comando1.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

        }

        public int buscarClaveRutina(String Nombre)
        {

            int clave;
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            String query = "select Clave_Rutina from Rutina where Nombre = @nom";

            SqlCommand comando1 = new SqlCommand(query, conexion);

            comando1.Parameters.AddWithValue("@nom", Nombre);

            clave = int.Parse(comando1.ExecuteScalar().ToString());

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return clave;

        }

        public List<TOEjercicio> CargarEjercicioRutina(int claveRutina)
        {
            DataTable tabla = new DataTable();

            List<TOEjercicio> lista = new List<TOEjercicio>();

            string query = "select Ejercicio.*, Ejercicios_Rutina.Numero_Series,Ejercicios_Rutina.Repeticiones from Ejercicio, Ejercicios_Rutina where Ejercicios_Rutina.Clave_Rutina = @claRu and Ejercicios_Rutina.Clave_Ejercicio = Ejercicio.Clave_Ejercicio;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            adapter.SelectCommand.Parameters.AddWithValue("@claRu", claveRutina);

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows)
            {

                TOEjercicio ejercicio = new TOEjercicio();
                ejercicio.Clave = int.Parse(x["Clave_Ejercicio"].ToString());
                ejercicio.Nombre = x["Nombre"].ToString().ToUpper();
                ejercicio.Series = Int32.Parse(x["Numero_Series"].ToString());
                ejercicio.Repeticiones = Int32.Parse(x["Repeticiones"].ToString());

                lista.Add(ejercicio);
            }

            return lista;
        }

        public List<TOEjercicio> CargarEjercicios()
        {
            DataTable tabla = new DataTable();

            List<TOEjercicio> lista = new List<TOEjercicio>();

            string query = "select * from Ejercicio order by Nombre";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows)
            {

                TOEjercicio ejercicio = new TOEjercicio();
                ejercicio.Clave = int.Parse(x["Clave_Ejercicio"].ToString());
                ejercicio.Nombre = x["Nombre"].ToString().ToUpper();

                lista.Add(ejercicio);
            }

            return lista;
        }

        public void agregarEjercicio(String ejercicio)
        {
            String query = "Insert into Ejercicio values(@ejer);";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@ejer", ejercicio.ToUpper());

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            comando.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        public void eliminarEjercicio(String ejercicio)
        {
            String query = "delete from Ejercicio where Nombre= @ejer;";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@ejer", ejercicio);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            comando.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        public int buscarClaveEjercicio(String Nombre)
        {

            int clave;
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            String query = "select Clave_Ejercicio from Ejercicio where Nombre = @nom";

            SqlCommand comando1 = new SqlCommand(query, conexion);

            comando1.Parameters.AddWithValue("@nom", Nombre);

            clave = int.Parse(comando1.ExecuteScalar().ToString());

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return clave;

        }

        public void agregarRutina(TORutina rutina)
        {

            String query = "insert into Rutina values(@fecha,@nom);";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@fecha", rutina.Fecha);
            comando.Parameters.AddWithValue("@nom", rutina.Nombre.ToUpper());            

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            comando.ExecuteNonQuery();

            int claveRutina = buscarClaveRutina(rutina.Nombre);

            agregarEjerciciosRutina(rutina, claveRutina);

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            


        }

        public void agregarEjerciciosRutina(TORutina rutina, int claveRutina)
        {

            

            for (int i = 0; i < rutina.Ejercicios.Count; i++)
            {
                String query = "insert into Ejercicios_Rutina values(@claRu,@claEjer,@numSer,@numRep );";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@claRu", claveRutina);
                comando.Parameters.AddWithValue("@claEjer", buscarClaveEjercicio(rutina.Ejercicios[i].Nombre.ToUpper()));
                comando.Parameters.AddWithValue("@numSer", rutina.Ejercicios[i].Series);
                comando.Parameters.AddWithValue("@numRep", rutina.Ejercicios[i].Repeticiones);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }


        }



        public List<TOEjercicio> buscarEjercicio(String ejercicio)
        {
            DataTable tabla = new DataTable();

            List<TOEjercicio> lista = new List<TOEjercicio>();

            string query = "select * from Ejercicio where Nombre=@ejer order by Nombre";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            adapter.SelectCommand.Parameters.AddWithValue("@ejer",ejercicio);

            adapter.Fill(tabla);

            foreach (DataRow x in tabla.Rows)
            {

                TOEjercicio Toejercicio = new TOEjercicio();
                Toejercicio.Clave = int.Parse(x["Clave_Ejercicio"].ToString());
                Toejercicio.Nombre = x["Nombre"].ToString().ToUpper();
            
                lista.Add(Toejercicio);
        }

            return lista;
        }

        //public Boolean verificarExistenciaRutina() {

        //}



    }
}
