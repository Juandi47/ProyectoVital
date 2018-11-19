using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
	public class TOLogin
	{
		public string nombre_usuario { set; get; }
		public string clave { set; get; }
		public string rol { set; get; }

		public TOLogin(string nombre_Usua, string clave, string rol)
		{
			this.nombre_usuario = nombre_Usua;
			this.clave = clave;
			this.rol = rol;
		}

		public TOLogin()
		{

		}
	}
}
