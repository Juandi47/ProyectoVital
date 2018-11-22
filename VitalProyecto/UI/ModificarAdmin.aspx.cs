using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class ModificarAdmin : System.Web.UI.Page
    {
        ManejadorAdministrador manejadorAdmin = new ManejadorAdministrador();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
                string valor = Request.QueryString["Valor"];
             
                Administrador admin = manejadorAdmin.consultaAdministrador(valor);

            if (!IsPostBack) {
                tced.Text = admin.Cedula;
                tname.Text = admin.Nombre;
                tlname1.Text = admin.Apellido1;
                tlname2.Text = admin.Apellido2;
                temail.Text = admin.Correo;
            }
               

        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {

            string mensaje = "";
            string cedula = tced.Text;
            string nombre = tname.Text;
            string clave = tclave.Text;
            string clave2 = tclave2.Text;
            string apellido1 = tlname1.Text;
            string apellido2 = tlname2.Text;
            string correo = temail.Text;
            

            if (nombre.Equals("") || clave.Equals("") || clave2.Equals("") || apellido1.Equals("") || apellido2.Equals("") || correo.Equals(""))
            {
                Response.Write("<script>alert('Debe completar los datos')</script>");
            }
            else {
                if (clave.Equals(clave2))
                {
                    mensaje = manejadorAdmin.modificarAdmin(cedula, nombre, clave, apellido1, apellido2, correo);

                    Response.Write("<script>alert('" + mensaje + "')</script>");
                }
                else {
                    Response.Write("<script>alert('Las contraseñas deben coincidir')</script>");
                }
                
            }

        }


    }

}