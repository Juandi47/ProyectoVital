using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
	public partial class ClientePrincipal : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (new ControlSeguridad().validarCliente() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}
		}
	}
}