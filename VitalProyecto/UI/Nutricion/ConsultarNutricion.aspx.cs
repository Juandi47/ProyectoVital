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
        ManejadorNutrición manejador = new ManejadorNutrición();
        private static List<ClienteNutricion> lista = new List<ClienteNutricion>();
        protected void Page_Load(object sender, EventArgs e)
        {
			if (new ControlSeguridad().validarClieNutri() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}

			if (!IsPostBack)
            {
                CargarLista();
            }
        }

        private void CargarLista()
        {

        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}