﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
	public class TOUsuario
	{
		public string cedula { set; get; }
		public string correo { set; get; }
		public string nombre { set; get; }
		public string apellido1 { set; get; }
		public string apellido2 { set; get; }
		public string rol { set; get; }

		public TOUsuario(string cedula, string correo, string nombre, string apellido1, string apellido2, string rol)
		{
			this.cedula = cedula;
			this.correo = correo;
			this.nombre = nombre;
			this.apellido1 = apellido1;
			this.apellido2 = apellido2;
			this.rol = rol;
		}

		public TOUsuario()
		{


		}

	}
}
