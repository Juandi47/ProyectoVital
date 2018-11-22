using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
	public class ManejadorIngreso
	{
		public DAOIngreso daoUsuar = new DAOIngreso();
		public BL.Ingreso buscarUsuario(string correo, string contra)
		{
			TOIngreso usuarioTO = daoUsuar.buscarUsuario(correo, contra);
			if (usuarioTO == null)
			{
				return null;
			}
			return new Ingreso(usuarioTO.nombre_usuario, usuarioTO.clave, usuarioTO.rol);
		}

        public Boolean registrarLogin(Ingreso login) {
            TOIngreso usuarioTO = new TOIngreso(login.nombre_usuario, login.clave, login.rol);

            int elementoAgregado = daoUsuar.registrarLogin(usuarioTO);

            return elementoAgregado > 0 ? true : false;
        }



	}
}
