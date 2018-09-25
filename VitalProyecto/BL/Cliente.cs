using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Clave { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Observacion { get; set; }

        public Cliente(string cedula, string nombre, string apellido1, string apellido2, string clave, DateTime fecha_Nacimiento, int telefono, string correo, string observacion)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Clave = clave;
            Fecha_Nacimiento = fecha_Nacimiento;
            Telefono = telefono;
            Correo = correo;
            Observacion = observacion;
        }

        public Cliente() { }
    }
}
