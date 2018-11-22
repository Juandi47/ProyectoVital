using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
	public class ManejadorLogin
	{
		public DAOLogin daoUsuar = new DAOLogin();
		public BL.Login buscarUsuario(string correo, string contra)
		{
			TOLogin usuarioTO = daoUsuar.buscarUsuario(correo, contra);
			if (usuarioTO == null)
			{
				return null;
			}
			return new Login(usuarioTO.nombre_usuario, usuarioTO.clave, usuarioTO.rol);
		}

	}
}
