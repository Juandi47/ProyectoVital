using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TORecordatorio24H
    {
        public string Cedula { set; get; }
        public string TiempoComida { set; get; }
        public string Comida { set; get; }
        public string Cantidad { set; get; }
        public string Descripcion { set; get; }


        public TORecordatorio24H(string cedula, string tiempoComida, string comida, string cantidad, string descripcion)
        {
            Cedula = cedula;
            TiempoComida = tiempoComida;
            Comida = comida;
            Cantidad = cantidad;
            Descripcion = descripcion;
        }
        public TORecordatorio24H() { }
    }
}
