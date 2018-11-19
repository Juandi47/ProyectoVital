using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
	public class DAOLogin
	{
		SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

		public TOLogin BuscarUsuario(String correo_usuario, String contra)
		{
			try
			{
				TOLogin usuario = new TOLogin();
				SqlCommand buscar = new SqlCommand("SELECT * FROM Login WHERE Nombre_usuario = @corrusu and Clave = @contus", conexion);
				buscar.Parameters.AddWithValue("@corrusu", correo_usuario);
				buscar.Parameters.AddWithValue("@contus", contra);
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
	}
}
