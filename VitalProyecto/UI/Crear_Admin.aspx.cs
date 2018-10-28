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

            string cedula = tced.Text; 
            string nombre = tname.Text;
            string clave = tclave.Text;
            string apellido1 = tlname1.Text;
            string apellido2 = tlname2.Text;

            if (cedula == null || nombre == null || clave == null || apellido1 == null || apellido2 == null)
            {
                //aqui va mensaje de error
            }
            else {
                manejadorAdmin.agregarAdministrador(cedula, nombre, clave, apellido1, apellido2);
            }

        }
    }
}