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
    }

}
