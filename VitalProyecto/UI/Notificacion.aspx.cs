using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class Notificacion : System.Web.UI.Page
    {
        private ManejadorCliente manejCliente = new ManejadorCliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void EnviarMSJ()
        {
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            int tel = 89655730;
            string msj = "esto%20es%20una%20prueba%20para%20la%20api%20de%20whatsapp";
            string link = "https://wa.me/506" + tel + "&text=" + msj;
        }
    }
}