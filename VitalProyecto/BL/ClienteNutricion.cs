using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClienteNutricion
    {
        public DateTime Fecha_Nacimiento { set; get; }
        public char Sexo { set; get; }
        public string Estado_Civil { set; get; }
        public int Telefono { set; get; }
        public string Residencia { set; get; } 
        public string Ocupacion { set; get; }
        public string Cedula { set; get; }

        public ClienteNutricion(DateTime fecha_Nacimiento, char sexo, string estado_Civil, int telefono, string residencia, string ocupacion, string cedula)
        {
            Fecha_Nacimiento = fecha_Nacimiento;
            Sexo = sexo;
            Estado_Civil = estado_Civil;
            Telefono = telefono;
            Residencia = residencia;
            Ocupacion = ocupacion;
            Cedula = cedula;
        }

    }
}
