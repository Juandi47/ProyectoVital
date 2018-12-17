using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI.Nutricion
{
    public partial class SeguimSemanal : System.Web.UI.Page
    {
        private static List<SeguimientoSemanal> listaSeguimientos = new List<SeguimientoSemanal>();
        ManejadorNutrición manejadorNutrición = new ManejadorNutrición();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (new ControlSeguridad().validarClieNutri() == true)
            //{
            //    Response.Redirect("~/IniciarSesion.aspx");
            //}

        }

        protected void btnAgreg_Click(object sender, EventArgs e)
        {
            if (sCedula.Text.Equals("") || sPeso.Text.Equals("") || sOreja.Text.Equals("") || sEjercicio.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                bool creado = manejadorNutrición.AgregarSeguimiento(new SeguimientoSemanal(DateTime.Now, Convert.ToDecimal(sPeso.Text), sOreja.Text, sEjercicio.Text, sCedula.Text));
                if (creado)
                {
                    
                    if (listaSeguimientos != null)
                    {
                        listaSeguimientos.Add(new SeguimientoSemanal(listaSeguimientos[listaSeguimientos.Count - 1].Sesion + 1, DateTime.Now, Convert.ToDecimal(sPeso.Text), sOreja.Text, sEjercicio.Text, sCedula.Text));
                        LitSeguimiento.Text += "<tr><td>" + (listaSeguimientos[listaSeguimientos.Count - 1].Sesion) + "</td><td>" + DateTime.Now + "</td><td>" + sPeso.Text + "</td><td>" + sOreja.Text + "</td><td>" + sEjercicio.Text + "</td></tr>";
                    }
                    else
                    {
                        listaSeguimientos = new List<SeguimientoSemanal>();
                        listaSeguimientos.Add(new SeguimientoSemanal(1, DateTime.Now, Convert.ToDecimal(sPeso.Text), sOreja.Text, sEjercicio.Text, sCedula.Text));
                        LitSeguimiento.Text = "<tr><th>Sesión</th><th>Fecha</th><th>Peso</th><th>Oreja</th><th>Ejercicio</th></tr>";
                        LitSeguimiento.Text += "<tr><td>" + 1 + "</td><td>" + DateTime.Now + "</td><td>" + sPeso.Text + "</td><td>" + sOreja.Text + "</td><td>" + sEjercicio.Text + "</td></tr>";

                    }
                }
            }
            sCedula.Text = string.Empty; sPeso.Text = string.Empty; sOreja.Text = string.Empty; sEjercicio.Text = string.Empty;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (sCedula.Text.Equals(""))
            {
                Response.Write("<script>alert('Ingrese el numero de Cédula')</script>");
            }
            else
            {
                //validar Existe cliente!!
                listaSeguimientos = manejadorNutrición.TraerLista(sCedula.Text);
                if (listaSeguimientos != null)
                {
                    LitSeguimiento.Text = "<tr><th>Sesión</th><th>Fecha</th><th>Peso</th><th>Oreja</th><th>Ejercicio</th></tr>";
                    foreach (SeguimientoSemanal seg in listaSeguimientos)
                    {
                        LitSeguimiento.Text += "<tr><td>" + seg.Sesion + "</td><td>" + seg.Fecha + "</td><td>" + seg.Peso + "</td><td>" + seg.Oreja + "</td><td>" + seg.Ejercicio + "</td></tr>";
                    }
                }
                else
                {
                    LitSeguimiento.Text = "<tr><th>No existen Seguimientos Semanales de este usuario.</th></tr>";
                }
            }
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