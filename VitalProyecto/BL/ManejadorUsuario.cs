using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
	public class ManejadorUsuario
	{
		DAOUsuario usuaDAO = new DAOUsuario();
        DAOIngreso ingreso = new DAOIngreso();
        Encripcion encripta = new Encripcion();

		public Usuario buscarUsuario(string correo)
		{
			TOUsuario usuaTO = usuaDAO.buscarUsuario(correo);
			if (usuaTO == null)
			{
				return null;
			}
			return new Usuario(usuaTO.cedula, usuaTO.correo, usuaTO.nombre, usuaTO.apellido1, usuaTO.apellido2, usuaTO.rol);
		}

        public string  modificarUsuario(String contraseña) {
            string contrasenna = encripta.EncodePassword(contraseña);
            return ingreso.modificarUsuario(contrasenna);

        }



    }
}
