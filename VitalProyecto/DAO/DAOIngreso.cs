using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
	public class DAOIngreso
	{
		SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

		public TOIngreso buscarUsuario(String correo_usuario, String contra)
		{
			try
			{
				TOIngreso usuario = new TOIngreso();

                SqlCommand buscar = new SqlCommand("SELECT * FROM Login WHERE Nombre_usuario = @corrusu", conexion);
				buscar.Parameters.AddWithValue("@corrusu", correo_usuario);
				conexion.Open();
				SqlDataReader lector = buscar.ExecuteReader();

				if (lector.HasRows)
				{
					while (lector.Read())
					{
                        usuario.nombre_usuario = lector.GetString(0);
						usuario.clave = lector.GetString(1);
						usuario.rol = lector.GetString(2);
						
					}
					lector.Close();
				}
                
				conexion.Close();
				return usuario;
			}
			catch (Exception)
			{
				return null;
			}
		}


        public int registrarLogin(TOIngreso tOlogin)
        {
            SqlCommand cmd = new SqlCommand("insert into Login values (@nomUs,@pass,@rol)", conexion);
            cmd.Parameters.AddWithValue("@nomUs", tOlogin.nombre_usuario);
            cmd.Parameters.AddWithValue("@pass", tOlogin.clave);
            cmd.Parameters.AddWithValue("@rol", tOlogin.rol);

            conexion.Open();

            int res = 0;
            try
            {
                res = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                conexion.Close();
            }
            return res;
        }


        public string modificarUsuario(string clave) {
           
            string mensaje = "";
            try
            {

                string qry = "UPDATE Login SET Clave = @clave where Nombre_usuario = 'nutri@gmail.com';";


                SqlCommand sent = new SqlCommand(qry, conexion);
                sent.Parameters.AddWithValue("@clave", clave);


                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                int modificadas = sent.ExecuteNonQuery();
                if (modificadas == 1)
                {
                    mensaje = "Se ha modificado los datos del Nutricionista";
                }
            }
            catch (Exception e)
            {
                return "No se pudo realizar la actualización";
            }
            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
            return mensaje;

        }
    }
}
