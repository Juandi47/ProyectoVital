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
        Encripcion encripta = new Encripcion();

		public Ingreso buscarUsuario(string correo, string contra)
		{
            TOIngreso usuarioTO = daoUsuar.buscarUsuario(correo, contra);
            if (usuarioTO.nombre_usuario != null && usuarioTO.clave != null) {
                if (encripta.desEncode(usuarioTO.clave, contra))
                {
                    return new Ingreso(usuarioTO.nombre_usuario, usuarioTO.clave, usuarioTO.rol);
            }
            else {
                return null;
            }
        }
            return null;
        }

        public Boolean registrarLogin(Ingreso login) {
            string cla = encripta.EncodePassword(login.clave);
            TOIngreso usuarioTO = new TOIngreso(login.nombre_usuario, cla, login.rol);

            int elementoAgregado = daoUsuar.registrarLogin(usuarioTO);

            return elementoAgregado > 0 ? true : false;
        }
        
	}
}
