using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class ManejadorNutrición
    {
        DAOClienteNutricion daoClienteNutricion = new DAOClienteNutricion();
        public Boolean CrearCliente(string cedula, string nombre, string apellido1, string apellido2, DateTime fecha_Nacimiento, string sexo, string estado_Civil, int telefono, string residencia, string ocupacion, DateTime fechaIngreso)
        {
            if (cedula.Equals(""))
            {
                return false;
            }
            TOClienteNutricion usuario = new TOClienteNutricion(cedula, nombre, apellido1, apellido2,fecha_Nacimiento,sexo,estado_Civil,telefono,residencia,ocupacion,fechaIngreso);
            return daoClienteNutricion.CrearUsuario(usuario);
        }

        public Boolean AgregarHistorialMedico(HistorialMedico historial, List<Medicamento> listaMedicamentos)
        {
            List<TOMedicamento> lista = new List<TOMedicamento>();
            if(listaMedicamentos.Count != 0 && listaMedicamentos != null)
            {
                foreach (Medicamento medicamento in listaMedicamentos){
                    lista.Add(new TOMedicamento(medicamento.Cedula, medicamento.Nombre, medicamento.Motivo, medicamento.Frecuencia, medicamento.Dosis));
                }
            }
            else
            {
                lista = null;
            }
            return daoClienteNutricion.GuardarHistorial((new TOHistorialMedico(historial.Cedula, historial.Antecedentes, 
                historial.Patologias, historial.ConsumeLicor, historial.Fuma, historial.FrecFuma, historial.FrecLicor,
                historial.UltimoExamen, historial.ActividadFisica)),lista);
        }

        public Boolean AgregarHabitosAlimentarios(HabitoAlimentario habito, List<Recordatorio24H> listaRecordat)
        {
            List<TORecordatorio24H> lista = new List<TORecordatorio24H>();
            if (listaRecordat.Count != 0 && listaRecordat != null)
            {
                foreach (Recordatorio24H recordatorio in listaRecordat)
                {
                    lista.Add(new TORecordatorio24H(recordatorio.Cedula, recordatorio.TiempoComida, recordatorio.Comida, recordatorio.Cantidad, recordatorio.Descripcion));
                }
            }
            else
            {
                lista = null;
            }
            return daoClienteNutricion.GuardarHabitos(new TOHabitoAlimentario(habito.Cedula, habito.ComidaDiaria, habito.ComidaHorasDia,
                habito.AfueraExpress, habito.ComidaFuera, habito.AzucarBebida, habito.ComidaElaboradCon, habito.AguaDiaria,
                habito.Aderezos, habito.Fruta, habito.Verdura, habito.Leche, habito.Huevo, habito.Yogurt, habito.Carne,
                habito.Queso, habito.Aguacate, habito.Semillas), lista);
        }
        
    }
}
