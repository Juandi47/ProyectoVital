using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Administrador
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }

        


        public Administrador()
        {
        }

        public Administrador(string cedula, string nombre, string clave, string apellido1, string apellido2, string correo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Clave = clave;
            Correo = correo;
        }
    }
}
