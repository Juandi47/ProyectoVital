using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOSeguimMensual
    {
        public TOSeguimMensual(TOSeguimientoNutri nutri, List<TOSeguimientoRecord24> record, TOSegAntropometria antrop)
        {
            this.nutri = nutri;
            this.antrop = antrop;
            this.record = record;

        }
        public TOSeguimMensual(int id, TOSeguimientoNutri seg)
        {
            this.nutri = seg;
            this.id = id;
        }
        public int id { set; get; }
        public TOSeguimientoNutri nutri { set; get; }

        public TOSegAntropometria antrop { set; get; }

        public List<TOSeguimientoRecord24> record { set; get; }


    }
}
