using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOMedida
    {
        public int Clave { set; get; }
        public string Frec_Cardiaca { set; get; }
        public decimal Peso { set; get; }
        public decimal Porcent_Grasa { set; get; }
        public decimal IMC { set; get; }
        public decimal Cintura { set; get; }
        public decimal Abdomen { set; get; }
        public decimal Cadera { set; get; }
        public decimal Muslo { set; get; }
        public decimal Estatura { set; get; }
        public string Ced_Cliente { set; get; }
		public DateTime Fecha_medida { set; get; }



		public TOMedida(string frec_Cardiaca, decimal peso, decimal porcent_Grasa, decimal iMC, decimal cintura, decimal abdomen, decimal cadera, decimal muslo, decimal estatura, string ced_Cliente, DateTime fecha)
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
			Fecha_medida = fecha;
        }

		public TOMedida(int clave, string frec_Cardiaca, decimal peso, decimal porcent_Grasa, decimal iMC, decimal cintura, decimal abdomen, decimal cadera, decimal muslo, decimal estatura, string ced_Cliente)
		{
			Clave = clave;
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

		public TOMedida(string frec_Cardiaca, decimal peso, decimal porcent_Grasa, decimal iMC, decimal cintura, decimal abdomen, decimal cadera, decimal muslo, decimal estatura, String ced_Cliente)
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

		public TOMedida ()
		{

		}

    }
}
