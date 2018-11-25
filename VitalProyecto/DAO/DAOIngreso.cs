using System;
using System.Collections.Generic;
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
				SqlCommand buscar = new SqlCommand("SELECT * FROM Login WHERE Nombre_usuario = @corrusu and Clave = @contus", conexion);
				buscar.Parameters.AddWithValue("@corrusu", correo_usuario);
                //string hash = Helper.EncodePassword(string.Concat(usuario, contra));
				buscar.Parameters.AddWithValue("@contus", contra);
				//buscar.Parameters.AddWithValue("@contus", hash);
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

        internal class Helper
        {
            public static string EncodePassword(string originalPassword)
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();

                byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
                byte[] hash = sha1.ComputeHash(inputBytes);

                return Convert.ToBase64String(hash);
            }
        }

        public int registrarLogin(TOIngreso tOlogin) {
            SqlCommand cmd = new SqlCommand("insert into Login values (@nomUs,@pass,@rol)", conexion);
            cmd.Parameters.AddWithValue("@nomUs", tOlogin.nombre_usuario);
            cmd.Parameters.AddWithValue("@pass", tOlogin.clave);
            cmd.Parameters.AddWithValue("@rol", tOlogin.rol);

            conexion.Open();

            int res = 0;
            try {
                res = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e) {
                conexion.Close();
            }
            return res;
        }
	}
}
