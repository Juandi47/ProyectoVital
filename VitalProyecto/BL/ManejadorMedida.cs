using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class ManejadorMedida
    {
        DAOMedida medidaDAO = new DAOMedida();

        public Boolean AgregarMedida(string frec_Cardiaca, decimal peso, decimal porcent_Grasa, decimal iMC, decimal cintura, decimal abdomen, decimal cadera, decimal muslo, decimal estatura, string ced_Cliente, DateTime fechaMedida)
        {
            TOMedida nuevaMedida = new TOMedida(frec_Cardiaca, peso, porcent_Grasa, iMC, cintura, abdomen,
                cadera, muslo, estatura, ced_Cliente, fechaMedida);
                return (medidaDAO.AgregarMedida(nuevaMedida));
        }

		public Medida buscarMedidaCliente(string cedula)
		{
			TOMedida medidaTO = medidaDAO.buscarMedidasCliente(cedula);
			if (medidaTO == null)
			{
				return null;
			}
			return new Medida (medidaTO.Frec_Cardiaca, 
				medidaTO.Peso, medidaTO.Porcent_Grasa, medidaTO.IMC, 
				medidaTO.Cintura, medidaTO.Abdomen, medidaTO.Cadera, 
				medidaTO.Muslo, medidaTO.Estatura, medidaTO.Ced_Cliente);
		}


		public List<Medida> listaMedidas(string cedula)
		{
			List<TOMedida> listaTO = medidaDAO.ListaMedidas(cedula);
			List<Medida> listaBLMedida = new List<Medida>();
			foreach (TOMedida toMedida in listaTO)
			{
				Medida m = new Medida();
				m.Frec_Cardiaca = toMedida.Frec_Cardiaca;
				m.Peso = toMedida.Peso;
				m.Porcent_Grasa = toMedida.Porcent_Grasa;
				m.IMC = toMedida.IMC;
				m.Cintura = toMedida.Cintura;
				m.Abdomen = toMedida.Abdomen;
				m.Cadera = toMedida.Cadera;
				m.Muslo = toMedida.Muslo;
				m.Estatura = toMedida.Estatura;
				m.Fecha_Medida = toMedida.Fecha_medida;
			
				listaBLMedida.Add(m);

			}
			return listaBLMedida;
		}

	}

}

