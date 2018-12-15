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

        public List<ClienteNutricion> ListaClientes()
        {
            List<ClienteNutricion> ListaClient = new List<ClienteNutricion>();
            List<TOClienteNutricion> listaTO = daoClienteNutricion.ListarCliente();
            if (listaTO != null)
            {
                foreach (TOClienteNutricion cliente in listaTO)
                {
                    ListaClient.Add(new ClienteNutricion(cliente.Cedula, cliente.Nombre, cliente.Apellido1, cliente.Apellido2, cliente.Fecha_Nacimiento, cliente.Sexo, cliente.Estado_Civil, cliente.Telefono, cliente.Residencia, cliente.Ocupacion, cliente.FechaIngreso));
                }
                return ListaClient;
            }
            else
            {
                return null;
            }
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

        public bool AgregarAntropometria(Antropometria antrop, Porciones porcion, DistribucionPorciones distrib)
        {
            TOAntropometria antropom = new TOAntropometria();
            antropom.Cedula = antrop.Cedula;
            antropom.Talla = antrop.Talla;
            antropom.PesoIdeal = antrop.PesoIdeal;
            antropom.Edad = antrop.Edad;
            antropom.PMB = antrop.PMB;
            antropom.Peso = antrop.Peso;
            antropom.PesoMaxTeoria = antrop.PesoMaxTeoria;
            antropom.IMC = antrop.IMC;
            antropom.PorcGrasaAnalizador = antrop.PorcGrasaAnalizador;
            antropom.PorcGr_Bascula = antrop.PorcGr_Bascula;
            antropom.GB_BI = antrop.GB_BI;
            antropom.GB_BD = antrop.GB_BD;
            antropom.GB_PI = antrop.GB_PI;
            antropom.GB_PD = antrop.GB_PD;
            antropom.GB_Tronco = antrop.GB_Tronco;
            antropom.AguaCorporal = antrop.AguaCorporal;
            antropom.MasaOsea = antrop.MasaOsea;
            antropom.Complexión = antrop.Complexión;
            antropom.EdadMetabolica = antrop.EdadMetabolica;
            antropom.Cintura = antrop.Cintura;
            antropom.Abdomen = antrop.Abdomen;
            antropom.Cadera = antrop.Cadera;
            antropom.Muslo = antrop.Muslo;
            antropom.CBM = antrop.CBM;
            antropom.CircunfMunneca = antrop.CircunfMunneca;
            antropom.PorcentMusculo = antrop.PorcentMusculo;
            antropom.PM_BI = antrop.PM_BI;
            antropom.PM_PD = antrop.PM_PD;
            antropom.PM_BD = antrop.PM_BD;
            antropom.PM_PI = antrop.PM_PI;
            antropom.PM_Tronco = antrop.PM_Tronco;
            antropom.Observaciones = antrop.Observaciones;
            antropom.GEB = antrop.GEB;
            antropom.GET = antrop.GET;
            antropom.CHOPorc = antrop.CHOPorc;
            antropom.CHOGram = antrop.CHOGram;
            antropom.CHO_kcal = antrop.CHO_kcal;
            antropom.ProteinaPorc = antrop.ProteinaPorc;
            antropom.ProteinaGram = antrop.ProteinaGram;
            antropom.Proteinakcal = antrop.Proteinakcal;
            antropom.GrasaPorc = antrop.GrasaPorc;
            antropom.GrasaGram = antrop.GrasaGram;
            antropom.Grasakcal = antrop.Grasakcal;
            TOPorciones porci = new TOPorciones(porcion.Cedula, porcion.Leche, porcion.Carne, porcion.Vegetales, porcion.Grasa,
               porcion.Fruta, porcion.Azucar, porcion.Harina, porcion.Suplemento);

            TODistribucionPorciones distribuc = new TODistribucionPorciones(distrib.Cedula, distrib.Ayunas, distrib.Desayuno,
                distrib.MediaMañana, distrib.Almuerzo, distrib.MediaTarde, distrib.Cena, distrib.ColacionNocturna);
            
            return daoClienteNutricion.GuardarAntropometria( antropom, porci, distribuc);

        }

        public bool AgregarSeguimiento(SeguimientoSemanal seguimiento)
        {
            return daoClienteNutricion.AgregarSeguimiento(new TOSeguimientoSemanal(seguimiento.Fecha, seguimiento.Peso, seguimiento.Oreja,seguimiento.Ejercicio, seguimiento.Cedula));
        }

        public List<SeguimientoSemanal> TraerLista(string cedula) 
        {
            List<SeguimientoSemanal> listaSeguimiento = new List<SeguimientoSemanal>();
            List<TOSeguimientoSemanal> lista = daoClienteNutricion.ListarSeguimSemanal(cedula);
            if (lista != null)
            {
                foreach (TOSeguimientoSemanal seg in lista)
                {
                    listaSeguimiento.Add(new SeguimientoSemanal(seg.Sesion, seg.Fecha, seg.Peso, seg.Oreja, seg.Ejercicio, seg.Cedula));
                }
                return listaSeguimiento;
            }
            else
            {
                return null;
            }
        }

        public bool AgregaSegNutri(SeguimientoNutri nutri, List<SeguimientoRecord24> lista, SegAntropometria segAntrop)
        {

            TOSeguimientoNutri seg = new TOSeguimientoNutri();
            List<TOSeguimientoRecord24> lisSeg = new List<TOSeguimientoRecord24>();
            TOSegAntropometria segAnt = new TOSegAntropometria();
            seg.Cedula = nutri.Cedula;
            seg.DiasEjercicio = nutri.DiasEjercicio;
            seg.ComidaExtra = nutri.ComidaExtra;
            seg.NivelAnsiedad = nutri.NivelAnsiedad;
            if(lisSeg != null)
            {
                foreach (SeguimientoRecord24 record in lista)
                {
                    lisSeg.Add(new TOSeguimientoRecord24(record.TiempoComida, record.Descripcion));
                }
            }
            segAnt.Talla = segAntrop.Talla;
            segAnt.PesoIdeal = segAntrop.PesoIdeal;
            segAnt.Edad = segAntrop.Edad;
            segAnt.PMB = segAntrop.PMB;
            segAnt.Fecha_SA = segAntrop.Fecha_SA;
            segAnt.Peso = segAntrop.Peso;
            segAnt.IMC = segAntrop.IMC;
            segAnt.PorcGrasaAnalizador = segAntrop.PorcGrasaAnalizador;
            segAnt.PorcGr_Bascula = segAntrop.PorcGr_Bascula;
            segAnt.GB_BI = segAntrop.GB_BI;
            segAnt.GB_BD = segAntrop.GB_BD;
            segAnt.GB_PI = segAntrop.GB_PI;
            segAnt.GB_PD = segAntrop.GB_PD;
            segAnt.GB_Tronco = segAntrop.GB_Tronco;
            segAnt.PorcentGViceral = segAntrop.PorcentGViceral;
            segAnt.PorcentMusculo = segAntrop.PorcentMusculo;
            segAnt.PM_BI = segAntrop.PM_BI;
            segAnt.PM_PD = segAntrop.PM_PD;
            segAnt.PM_BD = segAntrop.PM_BD;
            segAnt.PM_PI = segAntrop.PM_PI;
            segAnt.PM_Tronco = segAntrop.PM_Tronco;
            segAnt.AguaCorporal = segAntrop.AguaCorporal;
            segAnt.MasaOsea = segAntrop.MasaOsea;
            segAnt.Complexión = segAntrop.Complexión;
            segAnt.EdadMetabolica = segAntrop.EdadMetabolica;
            segAnt.Cintura = segAntrop.Cintura;
            segAnt.Abdomen = segAntrop.Abdomen;
            segAnt.Cadera = segAntrop.Cadera;
            segAnt.Muslo = segAntrop.Muslo;
            segAnt.Brazo = segAntrop.Brazo;
            segAnt.Observaciones = segAntrop.Observaciones;

            return daoClienteNutricion.GuardarSeguimiento(seg, lisSeg,segAnt);
            
        }

        public void EliminarExpediente(string cedula)
        {
            
            daoClienteNutricion.EliminarExpediente(cedula);
        }

        public HistorialMedico TraerHistorial(string Ced)
        {
            HistorialMedico hist = new HistorialMedico();
            TOHistorialMedico hm= daoClienteNutricion.TraerHistorialMed(Ced);
            if (hm != null)
            {
                hist.Cedula = hm.Cedula;
                hist.Antecedentes = hm.Antecedentes;
                hist.Patologias = hm.Patologias;
                hist.ConsumeLicor = hm.ConsumeLicor;
                hist.Fuma = hm.Fuma;
                hist.FrecFuma = hm.FrecFuma;
                hist.FrecLicor = hm.FrecLicor;
                hist.UltimoExamen = hm.UltimoExamen;
                hist.ActividadFisica = hm.ActividadFisica;
                return hist;
            }
            else { return null; }
            
        }
        public List<Medicamento> traerSuplMed(string ced)
        {
            List<Medicamento> MedList = new List<Medicamento>();
            List<TOMedicamento> list = daoClienteNutricion.ListaSuplMed(ced);
            if(list != null)
            {
                foreach(TOMedicamento med in list)
                {
                    MedList.Add(new Medicamento(med.Cedula,med.Nombre,med.Motivo,med.Frecuencia,med.Dosis));
                }
                
            }
            else { return null; }
            return MedList;
        }
    }
}
