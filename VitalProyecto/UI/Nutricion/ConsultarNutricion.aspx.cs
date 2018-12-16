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
            HistorialMedico hm = new HistorialMedico();
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
                       "</div></div></div></div>";
            hm = manejador.TraerHistorial(cl.Cedula);
           
            if (hm != null) {
                string l = "";
                string f = "";
                if (hm.ConsumeLicor == 1) { l="Sí"; } else {l= "No"; }
                if (hm.Fuma == 1) { f = "Sí"; } else { f = "No"; }
                t += "<div id = \"HistorialMedico\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">" +
                 "Antecedentes Familiares: "+hm.Antecedentes+"<br />Patologías que padece: "+hm.Patologias+"<br /> Consume Licor: "+ l +", Frecuencia: "+hm.FrecLicor+"<br />" +
                 "Fuma: "+f+", Frecuencia: "+hm.FrecFuma+"<br />Fecha de últimos exámenes de sangre o revisión médica: "+ hm.UltimoExamen.ToString("dd/MM/yyyy") + "<br />Medicamentos o suplementos que consume:<br />" + CargarSuplemnto(cl.Cedula);
               
            } else { t += "<div id = \"HistorialMedico\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">No existe registro de historial médico</div></div></div></div>"; }

            t +=  "<div id = \"HabitosAlimentarios\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">" +
                       "¿Acostumbra a comer a las horas al día?: <br />¿Cuántas veces a la semana come fuera o pide un express?: <br />" +
                       "¿Generalmente que come fuera de la casa?: <br />¿Cuánta azucar le agrega a las bebidas?: <br/>" +
                       "Los alimentos que cocina los elabora generalmente con: <br /></div><div class=\"col-50\">¿Cuántos vasos de agua toma al día?: <br />¿Cuántas veces come al día?: <br />" +
                       "¿Agrega salsa de tomate, mayonesa, mantequilla o natilla a la comida?: <br />Le gustan la mayoría de: <br/>" +
                       "</div></div><div class=\"row\"><div class=\"col-75\">Recordatorio de 24 Horas:</div></div></div></div>" +
                       
                       "<div id=\"Antropometría\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">" +
                       "Antopometria<br />GEB: , GET: <br />Porciones: <br />Distribución de porciones entregadas:<br /></div></div></div></div>"+

                        "<div id=\"SegSemanal\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div id=\"div1\"><table>"+CargarSeguimientoSemanal(cl.Cedula)+"</table></div></div></div></div>" +

                        "<div id=\"SegMensual\" class=\"tab-pane fade\"><div class=\"container\"><div class=\"row\"><div class=\"col-50\">" +
                        "Seguimiento Mensual</div></div></div></div></div>";
            return t;
        }
        
        public static string CargarSuplemnto(string ced)
        {
            string txt = "<table><tr><th>Nombre</th><th>Motivo</th><th>Frecuencia</th><th>Dosis</th></tr>";
            List<Medicamento> medicamSupl = new List<Medicamento>();
            medicamSupl = manejador.traerSuplMed(ced);
            if (medicamSupl != null)
            {
                foreach (Medicamento med in medicamSupl)
                {
                    txt += "<tr><td>" + med.Nombre + "</td><td>" + med.Motivo + "</td><td>" + med.Frecuencia + "</td><td>" + med.Dosis + "</td></tr>";
                }
                txt += "</table></div></div></div></div>";
            }
            else
            {
                txt += "No consume medicamentos ni suplementos</div></div></div></div>";
            }
            return txt;
        }
       public static string CargarSeguimientoSemanal(string ced)
        {
            string lista = "";
            List<SeguimientoSemanal>  listaSeguimientos = manejador.TraerLista(ced);
            if (listaSeguimientos != null)
            {
                lista= "<tr><th>Sesión</th><th>Fecha</th><th>Peso</th><th>Oreja</th><th>Ejercicio</th></tr>";
                foreach (SeguimientoSemanal seg in listaSeguimientos)
                {
                    lista += "<tr><td>" + seg.Sesion + "</td><td>" + seg.Fecha.ToString("dd/MM/yyyy") + "</td><td>" + seg.Peso + "</td><td>" + seg.Oreja + "</td><td>" + seg.Ejercicio + "</td></tr>";
                }
            }
            else
            {
                lista = "<tr><th>No existen Seguimientos Semanales de este usuario.</th></tr>";
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