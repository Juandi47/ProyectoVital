using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SeguimientoNutri
    {
       
        public string Cedula { set; get; }
        public int DiasEjercicio { set; get; }
        public string ComidaExtra { set; get; }
        public string NivelAnsiedad { set; get; }

        public SeguimientoNutri(string cedula, int diasEjercicio, string comidaExtra, string nivelAnsiedad)
        {
            Cedula = cedula;
            DiasEjercicio = diasEjercicio;
            ComidaExtra = comidaExtra;
            NivelAnsiedad = nivelAnsiedad;
        }

        public SeguimientoNutri() { }
    }
}
