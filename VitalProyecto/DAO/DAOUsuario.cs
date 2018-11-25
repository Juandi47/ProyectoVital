using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
	public class DAOUsuario
	{
		SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

		public TOUsuario buscarUsuario(String correo_usuario)
		{

			try
			{
				TOUsuario usuario = new TOUsuario();
				SqlCommand buscar = new SqlCommand("select * from usuario where correo = @corrusu", conexion);
				buscar.Parameters.AddWithValue("@corrusu", correo_usuario);
			
				conexion.Open();
				SqlDataReader lector = buscar.ExecuteReader();

				if (lector.HasRows)
				{
					while (lector.Read())
					{
						usuario.cedula = lector.GetString(0);
						usuario.correo = lector.GetString(1);
						usuario.nombre = lector.GetString(2);
						usuario.apellido1 = lector.GetString(3);
						usuario.apellido2 = lector.GetString(4);
						usuario.rol = lector.GetString(5);
						//string rol = usuario.rol;
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

	}
}
