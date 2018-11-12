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
            nombreRutina = Session["Rutina"] as String;
            Session.Remove("Rutina");
            llenarGrid();
        }

        private void llenarGrid() {
            List<HojaEjercicio> ejercicios = manejador.MostrarRutina(nombreRutina);
            grdEjercicios.DataSource = ejercicios;
            grdEjercicios.DataBind();
        }

        
    }
}