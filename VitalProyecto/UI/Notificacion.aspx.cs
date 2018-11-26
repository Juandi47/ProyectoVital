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
            CrearTablaDatos();
            Fecha.Text = "Fecha del Servidor: " + DateTime.Now;
        }

        private void CrearTablaDatos()
        {
            String msj = "Gimnasio%20Vital%20le%20recuerda%20que%20su%20mensualidad%20ha%20vencido.%20Gracias.";
            List<Cliente> listaCliente = manejCliente.listaClientes();
            if(listaCliente != null) { 
            DateTime hoy = DateTime.Now.Date;
            Notif.Text = "<thead> <tr class=\"w3-light-grey\">" +
                          "<th>Cliente</th><th>FechaPago</th><th>Eviar Mensaje</th> </tr> </thead>";
            foreach (Cliente cliente in listaCliente){
                DateTime mensual = cliente.Fecha_Mensualidad.Date;
                if (mensual >= hoy){

                    Notif.Text += "<tr><td>" + cliente.Nombre + cliente.Apellido1 + "</td>" +
                        "<td>" + cliente.Fecha_Mensualidad + "</td>" +
                        "<td>" + "<a href=\"https://wa.me/506" + cliente.Telefono + "?text=" + msj + "\">Enviar Mensaje</a> </td></tr>";
                }
            }
            }
        }


        protected void RecargarNotif_Click(object sender, EventArgs e)
        {
            CrearTablaDatos();
        }
    }
}