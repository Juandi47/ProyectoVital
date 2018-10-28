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
                string qry = "insert into Administrador values (@ced, @nom, @cla, @ape1, @ape2)";

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


        public int eliminarAdmin(string cedula)
        {
            int eliminado = -1;
            try
            {
                int con = ListaAdministrador().Count();
                if (ListaAdministrador().Count() > 1)
                {
                    string qry = "delete from Administrador where Cedula = @ced";

                    SqlCommand sent = new SqlCommand(qry, conexion);
                    sent.Parameters.AddWithValue("@ced", cedula);
                    conexion.Open();
                    sent.ExecuteNonQuery();
                    eliminado = 2;
                }
                else {
                    //NonSerializedAttribute deberia quedar sin al menos un administrador
                    eliminado = 1;
                }
                
            }
            catch (Exception e)
            {
                
            }

            return eliminado;

        }

       

        public void modificarAdmin(TOAdministrador administrador) {
            try
            {
                string qry = "UPDATE Administrador SET Clave = @cla where Cedula = @ced;";

                SqlCommand sent = new SqlCommand(qry, conexion);
                sent.Parameters.AddWithValue("@ced", administrador.Cedula);
                sent.Parameters.AddWithValue("@cla", administrador.Clave);

                conexion.Open();
                sent.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
        }




    }

}
