using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SeguimientoRecord24
    {

        public int Seguimiento { set; get; }
        public string TiempoComida { set; get; }
        public string Descripcion { set; get; }


        public SeguimientoRecord24(int seguimiento, string tiempoComida, string descripcion)
        {
            Seguimiento = seguimiento;
            TiempoComida = tiempoComida;
            Descripcion = descripcion;
        }
         public SeguimientoRecord24() { }

        public SeguimientoRecord24(string tiempoComida, string descripcion)
        {
            TiempoComida = tiempoComida;
            Descripcion = descripcion;
        }
    }
}
