using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI.Nutricion
{
    public partial class ConsultarNutricion : System.Web.UI.Page
    {
        private static ManejadorNutrición manejador = new ManejadorNutrición();
        private static List<ClienteNutricion> lista = new List<ClienteNutricion>();
        private static List<SeguimientoSemanal> listaSeguimientos = new List<SeguimientoSemanal>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //    if (new ControlSeguridad().validarClieNutri() == true)
            //    {
            //        Response.Redirect("~/IniciarSesion.aspx");
            //    }
            if (!IsPostBack)
            {
                CargarLista();
            }

        }

    
        private void CargarLista()
        {
            LitConsultar.Text = "";
            lista = manejador.ListaClientes();
            if (lista != null)
            {
                foreach (ClienteNutricion c in lista)
                {
                    LitConsultar.Text += "<tr><td>" + c.Nombre + " " + c.Apellido1 + " " + c.Apellido2 + "</td>" +
                        "<td><a \"href=\"#\" onclick=\"Ver_Click(" + c.Cedula + ")\" id=\"btnVer\">Ver</a></td>"+
                         "<td><a \"href=\"#\" onclick=\"Eliminar_Click(" + c.Cedula + ")\" id=\"btnVer\">Eliminar</a></td></tr>";
                }

            }
            btnAtras.Visible = false;
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            LitConsultar.Text = "";
            if (sBusqueda.Text != (""))
            {
                foreach (ClienteNutricion cl in lista)
                {
                    if (cl.Cedula.Equals(sBusqueda.Text) || cl.Nombre.Equals(sBusqueda.Text) || cl.Apellido1.Equals(sBusqueda.Text))
                    {
                        LitConsultar.Text += "<tr><td>" + cl.Nombre + " " + cl.Apellido1 + " " + cl.Apellido2 + "</td>" +
                        "<td><a \"href=\"#\" onclick=\"Ver_Click(" + cl.Cedula + ")\" id=\"btnVer\">Ver</a></td>" +
                         "<td><a \"href=\"#\" onclick=\"Eliminar_Click(" + cl.Cedula + ")\" id=\"btnVer\">Eliminar</a></td></tr>";
                    }
                }
            }
            btnAtras.Visible=true;
        }

        [System.Web.Services.WebMethod]
        public static string VerDetalleCliente(string ced)
        {
           
            ClienteNutricion cl = lista.Find(x => x.Cedula.Equals(ced));
            string t = "<ul class=\"nav nav-tabs\"><li class=\"active\"><a data-toggle=\"tab\" href=\"#DatosPersonales\"> Datos Personales</a></li>" +
                       "<li><a data-toggle= \"tab\" href= \"#HistorialMedico\"> Historial Médico</a></li>" +
                       "<li><a data-toggle= \"tab\" href= \"#HabitosAlimentarios\">Habitos Alimentarios</a></li>" +
                       "<li><a data-toggle= \"tab\" href= \"#Antropometría\"> Antropometría </a></li>" +
                       "<li><a data-toggle= \"tab\" href= \"#SegSemanal\"> Seguimiento Semanal </a></li>" +
                       "<li><a data-toggle= \"tab\" href= \"#SegMensual\"> Seguimiento Nutricional </a></li>" +
                       "</ul><div class=\"tab-content\">" +

                       "<div id = \"DatosPersonales\" class=\"tab-pane fade in active\">" +
                       "<div class=\"container\"><div class=\"row\"><div class=\"col-50\">" +
                       "Cedula: " + cl.Cedula + " <br /> Nombre: " + cl.Nombre + " " + cl.Apellido1 + " " + cl.Apellido2 + "<br />Fecha de Nacimiento: " + cl.Fecha_Nacimiento.ToString("dd/MM/yyyy") + "<br />Edad: " + CalcularCumple(cl.Fecha_Nacimiento) +
                       "<br />Telefono: " + cl.Telefono + "</div><div class=\"col-50\">Sexo: " + cl.Sexo + "  " + "<br />Estado Civil: " + cl.Estado_Civil + "       " +
                       "<br />Residencia: " + cl.Residencia + "<br />Ocupacion: " + cl.Ocupacion + "<br />Fecha de Ingreso: " + cl.FechaIngreso.ToString("dd/MM/yyyy") +
                       "</div></div></div></div>" +

                       "<div id = \"HistorialMedico\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">" +CargarHistorialMed(cl.Cedula)+ "</div></div></div></div>"+
                       "<div id = \"HabitosAlimentarios\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">" + CargarHabitoAlimentario(cl.Cedula) + "</div></div></div></div>"+
                       "<div id=\"Antropometría\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">" +
                       "Antopometria<br />GEB: , GET: <br />Porciones: <br />Distribución de porciones entregadas:<br /></div></div></div></div>"+

                        "<div id=\"SegSemanal\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\">"+CargarSeguimientoSemanal(cl.Cedula)+"</div></div></div>" +

                        "<div id=\"SegMensual\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">" +
                        "Seguimiento Mensual</div></div></div></div></div>";
            return t;
        }
        public static string CargarHistorialMed(string ced)
        {
            string txt = "";
            HistorialMedico hm = manejador.TraerHistorial(ced);
            if (hm != null)
            {
                string l = "";
                string f = "";
                if (hm.ConsumeLicor == 1) { l = "Sí"; } else { l = "No"; }
                if (hm.Fuma == 1) { f = "Sí"; } else { f = "No"; }
                txt += 
                 "Antecedentes Familiares: " + hm.Antecedentes + "<br />Patologías que padece: " + hm.Patologias + "<br /> Consume Licor: " + l + ", Frecuencia: " + hm.FrecLicor + "</div><div class=\"col-50\">" +
                 "Fuma: " + f + ", Frecuencia: " + hm.FrecFuma + "<br />Fecha de últimos exámenes de sangre o revisión médica: " + hm.UltimoExamen.ToString("dd/MM/yyyy") +
                 "</div></div><div class=\"row\"><div class=\"col-75\">Medicamentos o suplementos que consume:<br />" + CargarSuplemnto(ced);

            }
            else { txt = "No existe registro de historial médico."; }

            return txt;
        }
        public static string CargarHabitoAlimentario(string ced)
        {
            string txt = "";
            HabitoAlimentario hab = manejador.TraerHabitosAlimentario(ced);
            if (hab != null)
            {
                string horasdia = ""; if (hab.ComidaHorasDia == 1) { horasdia = "Sí"; } else { horasdia = "No"; }
                string comExpress = ""; if (hab.AfueraExpress == 1) { comExpress = "Sí"; } else { comExpress = "No"; }
                string vecesCom = ""; if (hab.ComidaDiaria == 1) { vecesCom = "Sí"; } else { vecesCom = "No"; }
                string aderez = ""; if (hab.Aderezos == 1) { aderez = "Sí"; } else { aderez = "No"; }
                string fruta = ""; if (hab.Fruta == 1) { fruta = "Sí"; } else { fruta = "No"; }
                string verdur = ""; if (hab.Verdura == 1) { verdur = "Sí"; } else { verdur = "No"; }
                string leche = ""; if (hab.Leche == 1) { leche = "Sí"; } else { leche = "No"; }
                string huevo = ""; if (hab.Huevo == 1) { huevo = "Sí"; } else { huevo = "No"; }
                string yogurt = ""; if (hab.Yogurt == 1) { yogurt = "Sí"; } else { yogurt = "No"; }
                string carne = ""; if (hab.Carne == 1) { carne = "Sí"; } else { carne = "No"; }
                string queso = ""; if (hab.Queso == 1) { queso = "Sí"; } else { queso = "No"; }
                string aguacate = ""; if (hab.Aguacate == 1) { aguacate = "Sí"; } else { aguacate = "No"; }
                string semillas = ""; if (hab.Semillas == 1) { semillas = "Sí"; } else { semillas = "No"; }

                txt += "¿Acostumbra a comer a las horas al día?: " + horasdia + "<br />¿Cuántas veces a la semana come fuera o pide un express?: " + comExpress + "<br />" +
                           "¿Generalmente que come fuera de la casa?: " + hab.ComidaFuera + "<br />¿Cuánta azucar le agrega a las bebidas?: " + hab.AzucarBebida + "</div><div class=\"col-50\">" +
                           "Los alimentos que cocina los elabora generalmente con: " + hab.ComidaElaboradCon + "<br /¿Cuántos vasos de agua toma al día?: " + hab.AguaDiaria + "<br />¿Cuántas veces come al día?: " + vecesCom + "<br />" +
                           "¿Agrega salsa de tomate, mayonesa, mantequilla o natilla a la comida?: " + aderez + "</div></div><div class=\"row\"><div class=\"col-50\">Le gustan la mayoría de: <br/>" +
                           "Fruta: " + fruta + "<br />Verdura: " + verdur + "</div><div class=\"col-25\">Leche: " + leche + "<br />Huevo: " + huevo + "</div><div class=\"col-25\">Yogurt: " + yogurt + "<br />Carne: " + carne + "</div><div class=\"col-25\">Queso: " + queso + "<br />Aguacate: " + aguacate + "<br />Semillas: " + semillas +
                           "</div></div><div class=\"row\"><div class=\"col-75\">Recordatorio de 24 Horas:<br />";
                List<Recordatorio24H> record = manejador.TraerRecordatorio24h(ced);
                if (record != null || record.Count >= 1)
                {
                    txt += "<table><tr><th>Tiempo de Comida</th><th>Alimento</th><th>Cantidad</th><th>Descripción</th></tr>";
                    foreach (Recordatorio24H r in record)
                    {
                        txt += "<tr><td>" + r.TiempoComida + "</td><td>" + r.Comida + "</td><td>" + r.Cantidad + "</td><td>" + r.Descripcion + "</td></tr>";
                    }
                    txt += "</table>";
                }
                else
                {
                    txt = "No hay registro del recordatorio de 24 horas.";
                }

            }
            else
            {
                txt = "No hay registro de los habitos alimentarios de este usuario.";
            }
            return txt;
        }
        public static string CargarSuplemnto(string ced)
        {
            string txt = "<div id=\"div1\"><table><tr><th>Nombre</th><th>Motivo</th><th>Frecuencia</th><th>Dosis</th></tr>";
            List<Medicamento> medicamSupl = new List<Medicamento>();
            medicamSupl = manejador.traerSuplMed(ced);
            if (medicamSupl != null)
            {
                foreach (Medicamento med in medicamSupl)
                {
                    txt += "<tr><td>" + med.Nombre + "</td><td>" + med.Motivo + "</td><td>" + med.Frecuencia + "</td><td>" + med.Dosis + "</td></tr>";
                }
                txt += "</table></div>";
            }
            else
            {
                txt = "No consume medicamentos ni suplementos";
            }
            return txt;
        }
       public static string CargarSeguimientoSemanal(string ced)
        {
            string lista = "";
            List<SeguimientoSemanal>  listaSeguimientos = manejador.TraerLista(ced);
            if (listaSeguimientos != null)
            {
                lista= "<table><tr><th>Sesión</th><th>Fecha</th><th>Peso</th><th>Oreja</th><th>Ejercicio</th></tr>";
                foreach (SeguimientoSemanal seg in listaSeguimientos)
                {
                    lista += "<tr><td>" + seg.Sesion + "</td><td>" + seg.Fecha.ToString("dd/MM/yyyy") + "</td><td>" + seg.Peso + "</td><td>" + seg.Oreja + "</td><td>" + seg.Ejercicio + "</td></tr>";
                }
                lista += "</table>";
            }
            else
            {
                lista = "No existen Seguimientos Semanales de este usuario.";
            }
            return lista;
        }
       
        protected static int CalcularCumple(DateTime fechaNac)
        {
            if (fechaNac.Equals(""))
            {
                return 0;
            }
            else
            {
               
                int años = DateTime.Now.Year - fechaNac.Year;
                if (fechaNac.Month > DateTime.Now.Month)
                {
                    return años - 1;
                }
                else
                {
                    if (fechaNac.Month == DateTime.Now.Month)
                    {
                        if (fechaNac.Day < DateTime.Now.Day)
                        {
                            return años - 1;
                        }
                        else
                        {
                            return años;
                        }
                    }
                    else
                    {
                       return años;
                    }
                }
            }
        }

        [System.Web.Services.WebMethod]
        public static void EliminarCliente(string ced)
        {
            manejador.EliminarExpediente(ced);
            
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        protected void timerTest_Tick(object sender, EventArgs e)
        {
            DateTime timeUtc = DateTime.UtcNow;
            try
            {
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
                DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cstZone);
                Fecha.Text = "Fecha: " + cstTime;
            }
            catch (TimeZoneNotFoundException)
            {
                Response.Write("El registro no define la zona CST.");
            }
            catch (InvalidTimeZoneException)
            {
                Response.Write("El registro de datos en la zona CST ha sido corrupta.");
            }
        }
    }
}