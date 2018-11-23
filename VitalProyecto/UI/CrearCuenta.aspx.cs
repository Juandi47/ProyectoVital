using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
	public partial class CrearCuenta : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnCrearCuenta_Click(object sender, EventArgs e)
		{
			if(txtCorreo != null && !txtCorreo.Equals("") && txtContra != null && !txtContra.Equals("") && txtRepetir != null && !txtRepetir.Equals(""))
			{

			}
		}
	}
}