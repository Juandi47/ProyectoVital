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

	}

}

