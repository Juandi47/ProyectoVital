using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BL;

namespace UI
{
    public partial class AdminPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (new ControlSeguridad().validarAdmin() == true)
            {
                Response.Redirect("~/IniciarSesion.aspx");
            }
        }

		protected void btnSalir_Click(object sender, EventArgs e)
		{
			Response.Redirect("PagInicio.aspx");
			new ControlSeguridad().salir();
		}
	}
}