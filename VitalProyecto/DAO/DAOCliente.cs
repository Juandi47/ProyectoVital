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
    public class DAOCliente
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

		public List<TOCliente> ListaCliente()
        {
            List<TOCliente> listClientes = new List<TOCliente>();
            string qry = "select * from Cliente c, Usuario u where c.Cedula = u.Cedula;";
            SqlCommand sent = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            conexion.Open();
            lector = sent.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    TOCliente c = new TOCliente();
                    c.Cedula = lector["Cedula"].ToString();
                    c.Nombre = lector["Nombre"].ToString();
                    c.Apellido1 = lector["Apellido1"].ToString();
                    c.Apellido2= lector["Apellido2"].ToString();
                    c.Fecha_Mensualidad = DateTime.Parse(lector["Fecha_mensualidad"].ToString());


                    listClientes.Add(c);


                    /*
                     *
                     *
                     * new TOCliente(lector["Cedula"].ToString(), lector["Nombre"].ToString(),
                        lector["Apellido1"].ToString(), lector["Apellido2"].ToString(), 
                        (DateTime)lector["Fecha_nacimiento"], int.Parse(lector["Telefono"].ToString()),
                        lector["Correo"].ToString(), lector["Observaciones"].ToString())
                     * */
                }
                conexion.Close();
            }
            else
            {
                conexion.Close();
            }
            return listClientes;
        }

        public Boolean registrarClienteDAO(TOCliente c) {

            String query = "Insert into Cliente values(@ced,@fecha_n,@tel,@obs,@men);";
            String query2 = "Insert into Usuario values(@ced,@cor,@nomb,@ape1,@ape2);";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);

            try
            {
                //Cliente padre
                //ced, fecha, tel, obs, mens

                cmd.Parameters.AddWithValue("@ced", c.Cedula);
                cmd.Parameters.AddWithValue("@fecha_n", c.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@tel", c.Telefono);
                cmd.Parameters.AddWithValue("@obs", c.Observacion);
                cmd.Parameters.AddWithValue("@men", System.DateTime.Now);

                //Usuario
                //ced, correo, nom, ape1, ape2
                cmd2.Parameters.AddWithValue("@ced", c.Cedula);
                cmd2.Parameters.AddWithValue("@cor", c.Correo);
                cmd2.Parameters.AddWithValue("@nomb", c.Nombre);
                cmd2.Parameters.AddWithValue("@ape1", c.Apellido1);
                cmd2.Parameters.AddWithValue("@ape2", c.Apellido2);


                conexion.Open();
                //inserta hijo
                cmd2.ExecuteNonQuery();
                //inserta padre
                cmd.ExecuteNonQuery();
                
                conexion.Close();

                return true;
            }
            catch (SqlException) {
                return false;
            }
        }


        public Boolean verificarCliente(String cedula) {

            String query = "select count(*) from Cliente where Cedula = @ced;";

            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@ced", cedula);

            int existencia = 0;

            if (ConnectionState.Open != conexion.State)
            {
                conexion.Open();
            }

            existencia = Int32.Parse(comando.ExecuteScalar().ToString());

            if (ConnectionState.Closed != conexion.State)
            {
                conexion.Close();
            }

            return existencia > 0 ? true : false;

        }

        public TOCliente filtrarDatosCliente(String ced) {
            TOCliente cliente = new TOCliente();

            if (ConnectionState.Open != conexion.State)
            {
                conexion.Open();
            }

            SqlCommand cmd = new SqlCommand("select * from Persona where Cedula = @ced;", conexion);
            cmd.Parameters.AddWithValue("@ced", ced);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cliente.Cedula = reader["Cedula"].ToString();
                    cliente.Nombre = reader["Nombre"].ToString();
                    cliente.Apellido1 = reader["Apellido1"].ToString();
                    cliente.Apellido2 = reader["Apellido2"].ToString();
                }

            }
            else
            {
                cliente.Cedula = "";
                cliente.Nombre = "";
                cliente.Apellido1 = "";
                cliente.Apellido2 = "";
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return cliente;
        }

		public TOCliente buscarCliente(String cedula)
		{
			try
			{
				TOCliente cliente = new TOCliente();
				
				SqlCommand buscar = new SqlCommand("select * from cliente where cedula = @cedula", conexion);
				buscar.Parameters.AddWithValue("@cedula", cedula);
				conexion.Open();
				SqlDataReader lector = buscar.ExecuteReader();

				if (lector.HasRows)
				{
					while (lector.Read())
					{
						cliente.Cedula = lector["Cedula"].ToString();
						cliente.Fecha_Nacimiento = DateTime.Parse(lector["Fecha_nacimiento"].ToString());
						cliente.Telefono = Int32.Parse(lector["Telefono"].ToString());
						cliente.Observacion = lector["Observaciones"].ToString();
						cliente.Fecha_Mensualidad = DateTime.Parse(lector["Fecha_mensualidad"].ToString());

					}
					lector.Close();
				}
				conexion.Close();
				return cliente;
			}
			catch (Exception)
			{
				return null;
			}
		}


		//FIN
	}
}
