using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace UI
{
    public partial class ListaClientesAdmin : System.Web.UI.Page
    {
        
        private static List<string> cedulasAgregadas = new List<string>();
        public byte[] Clave = Encoding.ASCII.GetBytes("clave");
        public byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");


        protected void Page_Load(object sender, EventArgs e)
        {
			if (new ControlSeguridad().validarAdmin() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}

			//if (!IsPostBack)
			//    Session["lista"] = cedulasAgregadas;

			cargarListaClientes();

            ClientScript.GetPostBackEventReference(this, string.Empty);

            string accion = Convert.ToString(Request.QueryString["con"]);

            if(!IsPostBack)
            if ( accion != null) {
                    if (accion.Equals("true"))
						ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);

					//mostrarAlerta("Cliente modificado correctamente.", true);
                   
                }
                  

            //if (IsPostBack)
            //{
            //    if (Page.Request.Params["__EVENTTARGET"] == "id")
            //    {
            //        string dato = Page.Request.Params["__EVENTARGUMENT"].ToString();
            //        Session["id"] = dato;
            //        Response.Redirect("~/RegistroCliente.aspx?accion=mod");
            //    }
            //}


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
            
            encabezado.CssClass = "encabezado";

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
                btnMod.Text = "Modificar";
                btnMod.CssClass = "small" ;
                btnMod.ID = "mod."+ c.Cedula;
                //btnMod.BackColor = System.Drawing.Color.LightYellow;
                //btnMod.Width;
                //btnMod.Attributes.Add("onClick", "salvarID("+ c.Cedula +")");
                btnMod.Click += delegate { modCliente(btnMod.ID); }; //linea sayayin
               
                fila.Cells.Add(controlMOd);

                controlEli = new TableCell();
                controlEli.CssClass = "cell";
                Button btnEli = new Button();
                btnEli.Text = "Eliminar";
                btnEli.CssClass = "small";
                btnEli.ID = c.Cedula+";"+c.Correo;
                btnEli.BackColor = System.Drawing.Color.LightPink;

                btnEli.Click += delegate { eliminar(btnEli.ID); }; //linea sayayin
                //btnEli.Attributes.Add("onClick", "salvarID(" + c.Cedula + ")");
                controlMOd.Controls.Add(btnMod);
                controlMOd.Controls.Add(btnEli);//cambiar si falla
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
            //ListaTotal.Text = text;
        }

        private void salvarID(String id) {
            //String[] array = id.Split(';');
            //String text = new Encripcion().EncodePassword(id);
            //new ManejadorCliente().eliminarCliente(array[0], array[1]);
            Response.Redirect("~/ListaClientesAdmin.aspx?con=" + id);
        }


        private void modCliente(String id) {
            String llave = id;
            String llave2 = encrypt(llave);
            Response.Redirect("~/RegistroCliente.aspx?accion=mod&key=" + llave2);
        }

        private void eliminar(String id) {
            String[] array = id.Split(';');
            String text = new Encripcion().EncodePassword(id);
            new ManejadorCliente().eliminarCliente(array[0],array[1]);
            tablaClientes.Rows.Clear();
            cargarListaClientes();
			ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "eliminado();", true);

		}

		private void agregarElemento(String id) {
            cedulasAgregadas.Add(id);
        }
        
        private string encrypt(string str)
        {
            string _result = string.Empty;
            char[] temp = str.ToCharArray();
            foreach (var _singleChar in temp)
            {
                var i = (int)_singleChar;
                i = i - 2;
                _result += (char)i;
            }
            return _result;
        }

        private void mostrarAlerta(String m, Boolean estado)
        {
            labelAlerta.Text = m;
            if (estado)
                labelAlerta.ForeColor = System.Drawing.Color.Green;
            labelAlerta.Visible = true;
        }
    }

}