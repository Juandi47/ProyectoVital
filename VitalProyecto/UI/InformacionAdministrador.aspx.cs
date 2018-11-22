using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class InformacionAdministrador : System.Web.UI.Page
    {
        private string cedulaAdmin;
        private ManejadorAdministrador manejador = new ManejadorAdministrador();

        protected void Page_Load(object sender, EventArgs e)
        {
            cedulaAdmin = Session["Administrador"] as String;
            Session.Remove("Administrador");
            
        }
        
        private void llenarGrid()
        {
            Administrador admin = manejador.consultaAdministrador(cedulaAdmin);
            
        }
    }
}