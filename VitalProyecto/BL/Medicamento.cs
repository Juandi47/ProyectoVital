using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Medicamento
    {

        public string Cedula { set; get; }
        public string Nombre { set; get; }
        public string Motivo { set; get; }
        public string Frecuencia { set; get; }
        public string Dosis { set; get; }


        public Medicamento(string cedula, string nombre, string motivo, string frecuencia, string dosis)
        {
            Cedula = cedula;
            Nombre = nombre;
            Motivo = motivo;
            Frecuencia = frecuencia;
            Dosis = dosis;
        }

        public Medicamento() { }
    }
}
