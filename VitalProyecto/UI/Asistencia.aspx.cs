using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Asistencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if (new ControlSeguridad().validarAsist() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}
			cargarClientes();
        }


        private void cargarClientes()
        {
            List<Cliente> lista = new ManejadorCliente().listaClientes();

            TableRow encabezado = new TableRow();
            encabezado.CssClass = "encabezadoTablaAsistencia";
            TableCell cedula = new TableCell();
            cedula.Text = "CEDULA";
            cedula.CssClass = "cell";
            encabezado.Cells.Add(cedula);
            TableCell nombre = new TableCell();
            nombre.Text = "NOMBRE";
            nombre.CssClass = "cell";
            encabezado.Cells.Add(nombre);
            TableCell apellidoS = new TableCell();
            apellidoS.Text = "APELLIDOS";
            apellidoS.CssClass = "cell";
            encabezado.Cells.Add(apellidoS);
            TableCell control = new TableCell();
            control.Text = "ASISTENCIA";
            control.CssClass = "cell2";
            encabezado.Cells.Add(control);
            TablaClientes.Rows.Add(encabezado);


            foreach (Cliente c in lista)
            {
                TableRow fila = new TableRow();
                fila.CssClass = "filaTablaAsistencia";
                cedula = new TableCell();
                cedula.CssClass = "cell";
                cedula.Text = c.Cedula;
                fila.Cells.Add(cedula);
                nombre = new TableCell();
                nombre.CssClass = "cell";
                nombre.Text = c.Nombre;
                fila.Cells.Add(nombre);
                apellidoS = new TableCell();
                apellidoS.CssClass = "cell";
                apellidoS.Text = c.Apellido1 + " " + c.Apellido2;
                fila.Cells.Add(apellidoS);
                control = new TableCell();
                control.CssClass = "cell2";
                Button radio = new Button();
                radio.Text = "Marcar";
                radio.ID = "rad." + c.Cedula;
                
                radio.Click += delegate { marcarAsistencia(c.Cedula); };
                radio.CssClass = "btn-primary small ";
                control.Controls.Add(radio);
                fila.Cells.Add(control);
               
                TablaClientes.Rows.Add(fila);

            }
            TablaClientes.DataBind();
        }


        private void marcarAsistencia(String id) {
            new ManejadorCliente().marcarAsistencia(id);
            TablaClientes.Rows.Clear();
            cargarClientes();
        }

       


    }
}