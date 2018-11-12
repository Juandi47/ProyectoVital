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

        public Boolean AgregarMedida(string frec_Cardiaca, decimal peso, decimal porcent_Grasa, decimal iMC, decimal cintura, decimal abdomen, decimal cadera, decimal muslo, decimal estatura, String ced_Cliente)
        {
            TOMedida nuevaMedida = new TOMedida(frec_Cardiaca, peso, porcent_Grasa, iMC, cintura, abdomen,
                cadera, muslo, estatura, ced_Cliente);
                return (medidaDAO.AgregarMedida(nuevaMedida));
        }

       

    }
}
