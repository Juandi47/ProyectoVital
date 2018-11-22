using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class ListaClientesAdmin : System.Web.UI.Page
    {
        
        private static List<string> cedulasAgregadas = new List<string>();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (!IsPostBack)
            //    Session["lista"] = cedulasAgregadas;

            cargarListaClientes();


            //if (Session["lista"] != null)
            //    productos = (List<String>)Session["lista"];
            //else
            //    Session["lista"] = new List<String>();
            //if (IsPostBack) {
            //    String text = Session["lista"] as String;
            //    Label1.InnerText=text;
            //}
        }


        private void cargarListaClientes()
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
            control.CssClass = "cell";
            encabezado.Cells.Add(control);
            tablaClientes.Rows.Add(encabezado);


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
                control.CssClass = "cell";
                Button btn = new Button();
                btn.Text = "Agregar";
                btn.CssClass = "radio small";
                btn.ID = c.Cedula;
                btn.Click+= delegate { agregarElemento(btn.ID); };
                //btn.Attributes.Add("onClick", "agregarElemento(" + btn.ID + ")");
                control.Controls.Add(btn);
                fila.Cells.Add(control);

                tablaClientes.Rows.Add(fila);

            }
            tablaClientes.DataBind();
        }

        protected void addBTN_Click(object sender, EventArgs e)
        {
            //String text = "";

            //    cedulasAgregadas = "";

            //cedulasAgregadas = Session["lista"] as String;

            //String[] listaT = cedulasAgregadas.Split(',');

            //List<String> productos = new List<String>();

            String text = "";
            //if (Session["lista"] != null)
            //    productos = (List<String>)Session["lista"];

            foreach (String ced in cedulasAgregadas)
            {
                text += ced + " / ";
                
            }
            ListaTotal.Text = text;
            //li
            //Label1.InnerText = text;
            //Label1.DataBind();

           
        }

        private void agregarElemento(String id) {

            cedulasAgregadas.Add(id);
            //ListaTotal.Text= "QWEQ" + id;
            //Label1.InnerText = "2q321dasd" + id;
            //List<String> productos = new List<String>();
            //if (Session["lista"] != null)
            //    productos = (List<String>)Session["lista"];
            //productos.Add(nombre);
            //Session["lista"] = productos;
        }



    }

}