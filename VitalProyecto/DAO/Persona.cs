using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Persona
    {

        public String ced { get; set; }
        public String nom { get; set; }
        public String ap1 { get; set; }
        public String ap2 { get; set; }

        public Persona(String ced, String nom, String ap1, String ap2) {
            this.ced = ced;
            this.nom = nom;
            this.ap1 = ap1;
            this.ap2 = ap2;
        }

        

    }
}
