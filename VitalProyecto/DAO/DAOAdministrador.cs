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



        public string agregarAdmin(TOAdministrador administrador) {
            try {
                string mensaje = "";
                string qry = "insert into Administrador values (@ced, @nom, @cla, @ape1, @ape2)";

                SqlCommand sent = new SqlCommand(qry, conexion);
                sent.Parameters.AddWithValue("@ced", administrador.Cedula);
                sent.Parameters.AddWithValue("@nom", administrador.Nombre);
                sent.Parameters.AddWithValue("@cla", administrador.Clave);
                sent.Parameters.AddWithValue("@ape1", administrador.Apellido1);
                sent.Parameters.AddWithValue("@ape2", administrador.Apellido2);
                
                conexion.Open();
               int number = sent.ExecuteNonQuery();
                if (number == 1)
                {
                    mensaje = "ADMINISTRADOR REGISTRADO";
                }
                else {
                    mensaje = "LA CEDULA YA SE ENCONTRABA REGISTRADA";
                }
               return mensaje;
            } catch (Exception e) {
                return "LA CEDULA YA SE ENCONTRABA REGISTRADA";
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

       

        public string modificarAdmin(TOAdministrador administrador) {
            string mensaje = "";
            try
            {
                
                string qry = "UPDATE Administrador SET Nombre = @nom, Clave = @cla, Apellido1 = @ape1, Apellido2 = @ape2  where Cedula = @ced;";

                SqlCommand sent = new SqlCommand(qry, conexion);
                sent.Parameters.AddWithValue("@ced", administrador.Cedula);
                sent.Parameters.AddWithValue("@cla", administrador.Clave);
                sent.Parameters.AddWithValue("@nom", administrador.Nombre);
                sent.Parameters.AddWithValue("@ape1", administrador.Apellido1);
                sent.Parameters.AddWithValue("@ape2", administrador.Apellido2);
                
                conexion.Open();
                int modificadas = sent.ExecuteNonQuery();
                if (modificadas == 1) {
                    mensaje = "Se ha modificado los datos del administrador";
                }
            }
            catch (Exception e)
            {

            }
            return mensaje;
        }

        public TOAdministrador consultaAdmin(string cedula) {
            TOAdministrador administrador = new TOAdministrador();
            string qry = "select * from Administrador where Cedula = @ced;";
            SqlCommand sent = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            sent.Parameters.AddWithValue("@ced", cedula);
            conexion.Open();
            lector = sent.ExecuteReader();
            
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    administrador = new TOAdministrador(lector["Cedula"].ToString(), lector["Nombre"].ToString(),
                        lector["Clave"].ToString(), lector["Apellido1"].ToString(), lector["Apellido2"].ToString());
                }
                conexion.Close();
            }
            else
            {
                conexion.Close();
            }
            return administrador;
        }



        }

   

    }
