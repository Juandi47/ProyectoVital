using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class MostrarRutina : System.Web.UI.Page
    {
        private String nombreRutina;

        private ManejadorRutina manejador = new ManejadorRutina();
        protected void Page_Load(object sender, EventArgs e)
        {
			if (new ControlSeguridad().validarAdmin() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}

			nombreRutina = Session["Rutina"] as String;
                llenarGrid();
            
            
        }

        private void llenarGrid() {
            List<HojaRutina> ejercicios = manejador.MostrarRutina(nombreRutina);
            grdEjercicios.DataSource = ejercicios;
            grdEjercicios.DataBind();
        }

        
    }
}