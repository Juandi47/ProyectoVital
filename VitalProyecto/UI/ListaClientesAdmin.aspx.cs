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

            TableCell controlMOd = new TableCell();
            controlMOd.Text = "";
            controlMOd.CssClass = "cell";
            encabezado.Cells.Add(controlMOd);
            TableCell controlEli = new TableCell();
            controlEli.Text = "";
            controlEli.CssClass = "cell";
            encabezado.Cells.Add(controlEli);

            tablaClientes.Rows.Add(encabezado);
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
                controlMOd = new TableCell();
                controlMOd.CssClass = "cell";
                //Button btn = new Button();
                //btn.Text = "Agregar";
                //btn.CssClass = "radio small";
                //btn.ID = c.Cedula;
                //btn.Click+= delegate { agregarElemento(btn.ID); }; //linea sayayin
                //control.Controls.Add(btn);

                Button btnMod = new Button();
                btnMod.Text = "Agregar";
                btnMod.CssClass = "radio small";
                btnMod.ID = c.Cedula;
                btnMod.Click += delegate { agregarElemento(btnMod.ID); }; //linea sayayin
                controlMOd.Controls.Add(btnMod);
                fila.Cells.Add(controlMOd);

                controlEli = new TableCell();
                controlEli.CssClass = "cell";
                Button btnEli = new Button();
                btnMod.Text = "Agregar";
                btnMod.CssClass = "radio small";
                btnMod.ID = c.Cedula;
                btnMod.Click += delegate { agregarElemento(btnMod.ID); }; //linea sayayin
                controlEli.Controls.Add(btnMod);
                fila.Cells.Add(controlEli);

                tablaClientes.Rows.Add(fila);

            }
            tablaClientes.DataBind();
        }

        protected void addBTN_Click(object sender, EventArgs e)
        {

            String text = "";

            foreach (String ced in cedulasAgregadas)
            {
                text += ced + " / ";
                
            }
            ListaTotal.Text = text;
        }

        private void agregarElemento(String id) {
            cedulasAgregadas.Add(id);
        }



    }

}