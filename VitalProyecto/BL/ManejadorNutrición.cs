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

        public void AgregarHistorialMedico(HistorialMedico historial, List<Medicamento> listaMedicamentos)
        {
            //daoClienteNutricion.GuardarHistorial(new TOHistorialMedico(historial.Cedula, historial.Antecedentes, historial.Patologias, historial.ConsumeLicor, historial.Fuma, historial.FrecFuma, historial.FrecLicor, historial.UltimoExamen));
        }
        
    }
}
