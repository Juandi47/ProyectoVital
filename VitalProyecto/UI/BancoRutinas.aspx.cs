using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class BancoRutinas : System.Web.UI.Page
    {

        private ManejadorRutina manejo = new ManejadorRutina();
        protected void Page_Load(object sender, EventArgs e)
        {
			if (new ControlSeguridad().validarAdmin() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}

			ClientScript.GetPostBackEventReference(this, string.Empty);

            if (IsPostBack)
            {
                if (Page.Request.Params["__EVENTTARGET"] == "NombreYBoton")
                {
                    string datos = Page.Request.Params["__EVENTARGUMENT"].ToString();
                    string[] args = Request.Params["__EVENTARGUMENT"].Split(';');

                    Session["Rutina"] = args[0];

                    if (args[1].Equals("celda"))
                    {
                        Response.Redirect("~/MostrarRutina.aspx");
                    }
                    else
                        Response.Redirect("~/CrearRutina.aspx");


                }
            }
            else {
                Session.Remove("Rutina");
            }
            llenarTablaRutinas();

        }

        private void llenarTablaRutinas()
        {
            List<Rutina> lista = new List<Rutina>();
            lista = manejo.CargarRutinas();

            Rutinas.Rows.Clear();
            Rutinas.BackColor = System.Drawing.Color.Silver;
            int idBotones = 0;
            foreach (Rutina x in lista)
            {
                crearFila(x.Nombre, idBotones);
                idBotones++;
            }
        }

        private void crearFila(String nombre, int idBotones)
        {
            TableRow fila = new TableRow(); ;            

            TableCell celdaNombre = new TableCell();

            celdaNombre.Attributes.Add("HorizontalAlign", "Center");
            celdaNombre.Attributes.Add("Wrap", "false");
            celdaNombre.Attributes.Add("Width", "95px");
            celdaNombre.Attributes.Add("VerticalAlign", "Middle");

            celdaNombre.CssClass = "celda";
            celdaNombre.Text = nombre;
            celdaNombre.Font.Size = FontUnit.Medium;
            celdaNombre.Font.Bold = true;
            celdaNombre.BackColor = System.Drawing.Color.Gray;
            celdaNombre.Attributes.Add("onClick", "guardarNombre('" + nombre + "','" + "celda" + "')");
            fila.Cells.Add(celdaNombre);

            TableCell botonCell = new TableCell();

            
            botonCell.Attributes.Add("HorizontalAlign", "Center");
            botonCell.Attributes.Add("Wrap", "false");
            botonCell.Attributes.Add("Width", "55px");
            botonCell.Attributes.Add("VerticalAlign", "Middle");

            Button btnModificar = new Button();
            Button btnEliminar = new Button();

            btnModificar.Attributes.Add("HorizontalAlign", "Center");
            btnModificar.Attributes.Add("HorizontalAlign", "Center");
            btnModificar.Attributes.Add("Wrap", "false");
            btnModificar.Attributes.Add("VerticalAlign", "Middle");

            btnModificar.Width = 125;
            btnEliminar.Width = 120;

            btnModificar.Height = 35;
            btnEliminar.Height = 35;

            btnModificar.Font.Size = FontUnit.Small;
            btnEliminar.Font.Size = FontUnit.Small;

            btnModificar.ID = "btnModificar" + idBotones;
            btnEliminar.ID = "btnEliminar" + idBotones;
            btnModificar.Text = " Modificar ";
            btnModificar.ForeColor = System.Drawing.Color.Black;
            btnModificar.BackColor = System.Drawing.Color.LightYellow;
            btnEliminar.Text = " Eliminar ";
            btnEliminar.ForeColor = System.Drawing.Color.Black;
            btnEliminar.BackColor = System.Drawing.Color.LightPink;
            btnModificar.Attributes.Add("onClick", "guardarNombre('" + nombre + "','" + "botonModificar" + "')");
            btnModificar.Click += delegate {
                
            };

            btnEliminar.Click += delegate
            {

                manejo.eliminarRutina(nombre);
                llenarTablaRutinas();

            };

			botonCell.Controls.Add(btnModificar);
			botonCell.Controls.Add(btnEliminar);
           
            fila.Cells.Add(botonCell);

            Rutinas.Rows.Add(fila);


        }

        protected void BtnCrearRutina_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearRutina.aspx");
        }

        protected void btnRutinaAleatoria_Click(object sender, EventArgs e)
        {
            Session["Rutina"] = manejo.rutinaAleatoria();

            Response.Redirect("~/MostrarRutina.aspx");
        }
    }


}
