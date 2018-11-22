using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class ManejadorNutrición
	{
		public string cedula { set; get; }
		public string correo { set; get; }
		public string nombre { set; get; }
		public string apellido1 { set; get; }
		public string apellido2 { set; get; }
		public string rol { set; get; }

		public Usuario(string cedula, string correo, string nombre, string apellido1, string apellido2, string rol)
        DAOClienteNutricion daoClienteNutricion = new DAOClienteNutricion();
        public Boolean CrearCliente(string cedula, string nombre, string apellido1, string apellido2, DateTime fecha_Nacimiento, char sexo, string estado_Civil, int telefono, string residencia, string ocupacion)
        {
            if (cedula.Equals(""))
		{
			this.cedula = cedula;
			this.correo = correo;
			this.nombre = nombre;
			this.apellido1 = apellido1;
			this.apellido2 = apellido2;
			this.rol = rol;
                return false;
            }
            TOClienteNutricion usuario = new TOClienteNutricion(cedula, nombre, apellido1, apellido2,fecha_Nacimiento,sexo,estado_Civil,telefono,residencia,ocupacion);
            return daoClienteNutricion.CrearUsuario(usuario);
		}

		}
	}
