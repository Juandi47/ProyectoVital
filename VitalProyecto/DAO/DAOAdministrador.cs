using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOAdministrador
    {

        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

        public List<TOAdministrador> ListaAdministrador()
        {
            List<TOAdministrador> listAdministrador = new List<TOAdministrador>();
            string qry = "Select * from Administrador";
            SqlCommand sent = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            conexion.Open();
            lector = sent.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    listAdministrador.Add(new TOAdministrador(lector["Cedula"].ToString(), lector["Nombre"].ToString(),
                        lector["Clave"].ToString(), lector["Apellido1"].ToString(), lector["Apellido2"].ToString()));

                }
                conexion.Close();
            }
            else
            {
                conexion.Close();
            }
            return listAdministrador;
        }



        public void agregarAdmin(TOAdministrador administrador) {
            try {
                string qry = "insert into Administrador values ('@ced', '@nom', '@cla', '@ape1', '@ape2')";

                SqlCommand sent = new SqlCommand(qry, conexion);
                sent.Parameters.AddWithValue("@ced", administrador.Cedula);
                sent.Parameters.AddWithValue("@nom", administrador.Nombre);
                sent.Parameters.AddWithValue("@cla", administrador.Clave);
                sent.Parameters.AddWithValue("@ape1", administrador.Apellido1);
                sent.Parameters.AddWithValue("@ape2", administrador.Apellido2);
                
                conexion.Open();
                sent.ExecuteNonQuery();
            } catch (Exception e) {

            }
            
        }


        public void eliminarAdmin(TOAdministrador administrador)
        {
            try
            {
                string qry = "insert into Administrador values ('@ced', '@nom', '@cla', '@ape1', '@ape2')";

                SqlCommand sent = new SqlCommand(qry, conexion);
                sent.Parameters.AddWithValue("@ced", administrador.Cedula);
                sent.Parameters.AddWithValue("@nom", administrador.Nombre);
                sent.Parameters.AddWithValue("@cla", administrador.Clave);
                sent.Parameters.AddWithValue("@ape1", administrador.Apellido1);
                sent.Parameters.AddWithValue("@ape2", administrador.Apellido2);

                conexion.Open();
                sent.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                int var1 = 0;
            }

        }


    }

}
