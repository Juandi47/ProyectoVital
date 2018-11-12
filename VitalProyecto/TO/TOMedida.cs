using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOMedida
    {
        public String Frec_Cardiaca { set; get; }
        public double Peso { set; get; }
        public double Porcent_Grasa { set; get; }
        public double IMC { set; get; }
        public double Cintura { set; get; }
        public double Abdomen { set; get; }
        public double Cadera { set; get; }
        public double Muslo { set; get; }
        public double Estatura { set; get; }
        public double Ced_Cliente { set; get; }

         public TOMedida(string frec_Cardiaca, double peso, double porcent_Grasa, double iMC, double cintura, double abdomen, double cadera, double muslo, double estatura, double ced_Cliente)
        {
            Frec_Cardiaca = frec_Cardiaca;
            Peso = peso;
            Porcent_Grasa = porcent_Grasa;
            IMC = iMC;
            Cintura = cintura;
            Abdomen = abdomen;
            Cadera = cadera;
            Muslo = muslo;
            Estatura = estatura;
            Ced_Cliente = ced_Cliente;
        }
    }
}
