using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
	public class Login
	{
		public string nombre_usuario { set; get; }
		public string clave { set; get; }
		public string rol { set; get; }

		public Login(string nombre_Usua, string clave, string rol)
		{
			this.nombre_usuario = nombre_Usua;
			this.clave = clave;
			this.rol = rol;
		}

		public Login()
		{

		}
	}
}
