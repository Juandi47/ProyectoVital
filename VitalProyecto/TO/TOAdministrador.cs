﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOAdministrador
    {
        public TOAdministrador(string cedula, string nombre, string clave, string apellido1, string apellido2)
        {
            Cedula = cedula;
            Nombre = nombre;
            Clave = clave;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            
        }

        public TOAdministrador()
        {
        }


        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Clave { get; set; }


    }
}