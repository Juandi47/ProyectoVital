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
            string nombre = Request.Form["tname"];
            string clave = Request.Form["tclave"];
            string apellido1 = Request.Form["tlname1"];
            string apellido2 = Request.Form["tlname2"];
            
            manejadorAdmin.agregarAdministrador(cedula, nombre, clave, apellido1, apellido2);

        }
    }
}