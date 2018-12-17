using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
namespace UI.Nutricion
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {

        ManejadorUsuario maneja = new ManejadorUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (new ControlSeguridad().validarClieNutri() == true)
            {
                Response.Redirect("~/IniciarSesion.aspx");
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string contra = tclave.Text;
            String contra2 = tclave2.Text;

            //valida espacios vacio
            if (contra != "" || contra2 != "")
            {

                //valida que las contraseñas coincidan
                if (contra.Equals(contra2))
                {
                    maneja.modificarUsuario(contra);
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);
                }
                else {
                    ValidadorClaves.Visible = true;
                }
            }
            else {
                ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "error();", true);
            }

        }
    }
}