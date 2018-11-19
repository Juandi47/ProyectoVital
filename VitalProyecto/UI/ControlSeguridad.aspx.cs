using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
	public partial class ControlSeguridad : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public void salir()
		{
			Session["usuario"] = null;
		}

		public BL.Login usuario()
		{
			return (BL.Login)Session["usuario"];
		}

		public Boolean validarCliente()
		{
			if (usuario() == null || !usuario().rol.Equals("cliente") || usuario().rol.Equals(""))
			{
				return true;
			}
			return false;
		}

		public Boolean validarAdmin()
		{
			if (usuario() == null || !usuario().rol.Equals("admin") || usuario().rol.Equals(""))
			{
				return true;
			}
			return false;
		}

		public Boolean validarAsist()
		{
			if (usuario() == null || !usuario().rol.Equals("asistente") || usuario().rol.Equals(""))
			{
				return true;
			}
			return false;
		}
	}
}