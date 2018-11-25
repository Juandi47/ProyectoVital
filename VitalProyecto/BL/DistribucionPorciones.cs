using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DistribucionPorciones
    {
        public string Cedula { set; get; }
        public string Ayunas { set; get; }
        public string Desayuno { set; get; }
        public string MediaMañana { set; get; }
        public string Almuerzo { set; get; }
        public string MediaTarde { set; get; }
        public string Cena { set; get; }
        public string ColacionNocturna { set; get; }

        public DistribucionPorciones(string cedula, string ayunas, string desayuno, string mediaMañana, string almuerzo, string mediaTarde, string cena, string colacionNocturna)
        {
            Cedula = cedula;
            Ayunas = ayunas;
            Desayuno = desayuno;
            MediaMañana = mediaMañana;
            Almuerzo = almuerzo;
            MediaTarde = mediaTarde;
            Cena = cena;
            ColacionNocturna = colacionNocturna;
        }
        public DistribucionPorciones() { }



    }
}
