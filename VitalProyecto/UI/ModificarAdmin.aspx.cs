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
            //if (!IsPostBack)
            //{
                string valor = Request.QueryString["Valor"];
                Administrador admin = manejadorAdmin.consultaAdministrador(valor);
                tced.Text = admin.Cedula;
                tname.Text = admin.Nombre;
                tlname1.Text = admin.Apellido1;
                tlname2.Text = admin.Apellido2;
                tclave.Text = admin.Clave;
            //}
            
            
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {

            string mensaje = "";
            string cedula = tced.Text;
            string nombre = tname.Text;
            string clave = tclave.Text;
            string apellido1 = tlname1.Text;
            string apellido2 = tlname2.Text;
            

            if (nombre.Equals("") || clave.Equals("") || apellido1.Equals("") || apellido1.Equals(""))
            {
                Response.Write("<script> alert('Debe completar los datos')</script>");
            }
            else {
                mensaje = manejadorAdmin.modificarAdmin(cedula, nombre, clave, apellido1, apellido2);

                Response.Write("<script>alert(" + mensaje + ")</script>");
            }

            Response.Redirect("ModificarAdmin.aspx");

        }


    }

}