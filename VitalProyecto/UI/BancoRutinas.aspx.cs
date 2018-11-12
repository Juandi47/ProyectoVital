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
            ClientScript.GetPostBackEventReference(this, string.Empty);
            
            if (IsPostBack)
            {
                if (Page.Request.Params["__EVENTTARGET"] == "Nombre")
                {
                    string dato = Page.Request.Params["__EVENTARGUMENT"].ToString();
                    Session["Rutina"] = dato;
                    Response.Redirect("~/MostrarRutina.aspx");
                }                
            }

            llenarTablaRutinas();

        }

        private void llenarTablaRutinas() {
            List<Rutina> lista = new List<Rutina>();
            lista = manejo.CargarRutinas();

            Rutinas.Rows.Clear();
            Rutinas.BackColor = System.Drawing.Color.LightGray;
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
            celdaNombre.Text = nombre;
            celdaNombre.Font.Size = 20;
            celdaNombre.Font.Bold = true;
            celdaNombre.BackColor = System.Drawing.Color.Gray;
            celdaNombre.Attributes.Add("onClick", "guardarNombre('" + nombre + "')");
            fila.Cells.Add(celdaNombre);

            TableCell botonCell = new TableCell();
            Button btnModificar = new Button();
            Button btnEliminar = new Button();

            btnModificar.ID = "btnModificar" + idBotones;
            btnEliminar.ID = "btnEliminar" + idBotones;
            btnModificar.Text = " Modificar ";
            btnModificar.ForeColor = System.Drawing.Color.Black;
            btnModificar.BackColor = System.Drawing.Color.LightYellow;
            btnEliminar.Text = " Eliminar ";
            btnEliminar.ForeColor = System.Drawing.Color.Black;
            btnEliminar.BackColor = System.Drawing.Color.LightPink;

            btnModificar.Click += delegate {  };

            btnEliminar.Click += delegate {

                manejo.eliminarRutina(nombre);
                llenarTablaRutinas();

            };

            botonCell.Controls.Add(btnEliminar);
            botonCell.Controls.Add(btnModificar);            
            fila.Cells.Add(botonCell);

            Rutinas.Rows.Add(fila);


        }
    }


}
