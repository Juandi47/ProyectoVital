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
        private String NombreRutina;

        ManejadorRutina manejo = new ManejadorRutina();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Rutina> lista = new List<Rutina>();
            lista = manejo.CargarRutinas();

            Rutinas.BackColor = System.Drawing.Color.LightGray;

            foreach (Rutina x in lista)
            {
                crearFila(x.Nombre);
            }


        }

        private void crearFila(String nombre)
        {
            TableRow fila = new TableRow(); ;

            TableCell celdaNombre = new TableCell();
            celdaNombre.Text = nombre;
            celdaNombre.Font.Size = 20;
            celdaNombre.Font.Bold = true;
            celdaNombre.BackColor = System.Drawing.Color.Gray;
            celdaNombre.Attributes.Add("onClick", "location.href='MostrarRutina.aspx/?Nombre=" + nombre + "'");
            //celdaNombre.Attributes.Add("onmouseover", "style+='background - color:blue;'");
            fila.Cells.Add(celdaNombre);

            TableCell botonCell = new TableCell();
            Button btnModificar = new Button();
            Button btnEliminar = new Button();

            btnModificar.ID = "btnModificar";
            btnEliminar.ID = "btnEliminar";
            btnModificar.Text = " Modificar ";
            btnModificar.ForeColor = System.Drawing.Color.Black;
            btnModificar.BackColor = System.Drawing.Color.LightYellow;
            btnEliminar.Text = " Eliminar ";
            btnEliminar.ForeColor = System.Drawing.Color.Black;
            btnEliminar.BackColor = System.Drawing.Color.LightPink;
            btnModificar.Click += delegate {  };
            btnEliminar.Click += delegate { };

            botonCell.Controls.Add(btnEliminar);
            botonCell.Controls.Add(btnModificar);            
            fila.Cells.Add(botonCell);

            Rutinas.Rows.Add(fila);


        }
    }


}
