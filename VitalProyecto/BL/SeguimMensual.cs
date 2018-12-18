using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SeguimMensual
    {

        public SeguimMensual(SeguimientoNutri nutri, SeguimientoRecord24 record, SegAntropometria antrop) {
            this.nutri = nutri;
            this.antrop = antrop;
            this.record = record;

        }

        public SeguimientoNutri nutri { set; get; }

        public SegAntropometria antrop { set; get; }

        public SeguimientoRecord24 record { set; get; }


    }
}
