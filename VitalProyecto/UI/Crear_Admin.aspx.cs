using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class Crear_Admin : System.Web.UI.Page
    {
        ManejadorAdministrador manejadorAdmin = new ManejadorAdministrador();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {

            string mensaje = "";
            string cedula = tced.Text;
            string nombre = tname.Text;
            string clave = tclave.Text;
            string clave2 = tclave2.Text;
            string apellido1 = tlname1.Text;
            string apellido2 = tlname2.Text;

            //try
            //{
                if (cedula.Equals("") || nombre.Equals("") || clave.Equals("") || apellido1.Equals("") || apellido1.Equals(""))
                {
                Response.Write( "<script> alert('Debe completar los datos')</script>");
            }
                else {

                if (clave2.Equals(clave))
                {
                    mensaje = manejadorAdmin.agregarAdministrador(cedula, nombre, clave, apellido1, apellido2);
                    
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", mensaje, true);
                }
                else {
                    Response.Write("<script>alert(Las contraseñas deben coincidir)</script>");
                }
                    
            }
            //}
            //catch {
            //    Response.Write("<script>alert(hola)</script>");
            //}
          
            tced.Text = string.Empty;
            tname.Text = string.Empty;
            tclave.Text = string.Empty;
            tclave2.Text = string.Empty;
            tlname1.Text = string.Empty;
            tlname2.Text = string.Empty;
            temail.Text = string.Empty;
            
        }
    }
}