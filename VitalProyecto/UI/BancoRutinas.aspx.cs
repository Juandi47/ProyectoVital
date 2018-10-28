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

        ManejadorRutina manejo = new ManejadorRutina();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Rutina> lista = new List<Rutina>();
            lista = manejo.CargarRutinas();
            TableRow fila;
            TableCell celda;
            foreach (Rutina x in lista)
            {
                fila = new TableRow();
                celda = new TableCell();
                celda.Text = x.Nombre;
                fila.Cells.Add(celda);
                Rutinas.Rows.Add(fila);
            }

        }
    }


}
