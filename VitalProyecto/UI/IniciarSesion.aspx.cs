using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
	public partial class IniciarSesion : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnIngresar_Click(object sender, EventArgs e)
		{
			String correo = txtCorreo.Text;
			String contra = txtContra.Text;

			BL.Ingreso usua = new ManejadorIngreso().buscarUsuario(correo, contra);

			if (usua != null)
			{
				Session["usuario"] = usua;
				if (usua.rol.Equals("cliente")) 
				{
					Usuario usuarioSesion = new ManejadorUsuario().buscarUsuario(correo);
					Session["usuarioSesion"] = usuarioSesion;
					Response.Redirect("~/ClientePrincipal.aspx");
				}
				else if (usua.rol.Equals("admin"))
				{
					Response.Redirect("~/AdminPrincipal.aspx");
				}
				else if (usua.rol.Equals("asistente"))
				{
					Response.Redirect("Asistencia.aspx");
				}

			}
			else
			{
				lblIncorrecto.Text = "Correo o contraseña incorrecto";
			}
		}
	}
}