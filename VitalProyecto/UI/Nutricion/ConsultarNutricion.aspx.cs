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

        private  void CargarLista()
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
            string t = "Cedula: " + cl.Cedula + "    Nombre: " + cl.Nombre +" "+ cl.Apellido1 + " " + cl.Apellido2 +  "                Fecha de Nacimiento: " + cl.Fecha_Nacimiento.ToString("ddmmyyyy") + Environment.NewLine + "Edad: " + CalcularCumple(cl.Fecha_Nacimiento) + "                " +
                "Telefono: " + cl.Telefono +"    "+ "      Sexo: " + cl.Sexo +  "  " + "Estado Civil: " + cl.Estado_Civil + "       " +
                "Residencia: " + cl.Residencia + "    " + "Ocupacion: " + cl.Ocupacion + "     " + "Fecha de Ingreso: " + cl.FechaIngreso.ToString("ddmmyyyy");
            return t;
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
            ConsultarNutricion c = new ConsultarNutricion();
            c.CargarLista();
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
                Response.Write("<script>alert('El registro no define la zona CST.')</script>");
            }
            catch (InvalidTimeZoneException)
            {
                Response.Write("<script>alert('El registro de datos en la zona CST ha sido corrupta .')</script>");
            }
        }
    }
}