using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOSeguimientoRecord24
    {
        public int Seguimiento { set; get; }
        public string TiempoComida { set; get; }
        public string Descripcion { set; get; }


        public TOSeguimientoRecord24(int seguimiento, string tiempoComida, string descripcion)
        {
            Seguimiento = seguimiento;
            TiempoComida = tiempoComida;
            Descripcion = descripcion;
        }
        public TOSeguimientoRecord24() { }

        public TOSeguimientoRecord24(string tiempoComida, string descripcion)
        {
            TiempoComida = tiempoComida;
            Descripcion = descripcion;
        }
    }
}
