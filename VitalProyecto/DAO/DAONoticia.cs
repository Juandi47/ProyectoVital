using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
    public class DAONoticia
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

        public bool CrearNoticia(TONoticia noti)
        {
            String query1 = "Insert into Noticia values(@fech,@encab,@txt,@img,@tipo);";
            
            SqlCommand cmd = new SqlCommand(query1, conexion);

            try
            {
                cmd.Parameters.AddWithValue("@fech", noti.Fecha);
                cmd.Parameters.AddWithValue("@encab", noti.Encabezado);
                cmd.Parameters.AddWithValue("@txt", noti.Texto);
                cmd.Parameters.AddWithValue("@img", noti.Imagen);
                cmd.Parameters.AddWithValue("@tipo", noti.TipoNoticia);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                
                cmd.ExecuteNonQuery();

                conexion.Close();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public List<TONoticia> CargarNoticias()
        {
            List<TONoticia> ListaNoticia = new List<TONoticia>();
            string qry = "Select * from Noticia order by Fecha desc;";
            SqlCommand buscar = new SqlCommand(qry, conexion);
            SqlDataReader lector;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            lector = buscar.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ListaNoticia.Add(new TONoticia(Int32.Parse(lector["Clave_Noticia"].ToString()),
                        DateTime.Parse(lector["Fecha"].ToString()), lector["Encabezado"].ToString(),
                        lector["Texto"].ToString(), lector["Imagen"].ToString(), Int32.Parse(lector["TipoNoticia"].ToString())));

                }
                conexion.Close();
                return ListaNoticia;
            }
            else
            {
                conexion.Close();
                return null;
            }
        }
    }
}
