using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
    public class DAOCliente
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

        public List<TOCliente> ListaCliente()
        {
            List<TOCliente> listClientes = new List<TOCliente>();
            string qry = "Select * from Cliente";
            SqlCommand sent = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            conexion.Open();
            lector = sent.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    listClientes.Add(new TOCliente(lector["Cedula"].ToString(), lector["Nombre"].ToString(),
                        lector["Apellido1"].ToString(), lector["Apellido2"].ToString(), lector["Clave"].ToString(),
                        (DateTime)lector["Fecha_nacimiento"], int.Parse(lector["Telefono"].ToString()),
                        lector["Correo"].ToString(), lector["Observaciones"].ToString()));
                    
                }
                conexion.Close();
            }
            else
            {
                conexion.Close();
            }
            return listClientes;
        }
    }
}
