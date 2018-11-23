using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class CrearRutina : System.Web.UI.Page
    {
        private static List<HojaEjercicio> lista = new List<HojaEjercicio>();
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
        private void llenarGrid()
        {
            ManejadorEjercicio manejador = new ManejadorEjercicio();
            List<HojaEjercicio> ejercicios = manejador.mostrarEjercicios();

            grdEjercicios.DataSource = ejercicios;
            grdEjercicios.DataBind();
        }

        protected void btnCrearRutina_Click(object sender, EventArgs e)
        {

            

            
            //foreach (GridViewRow row in grdEjercicios.Rows)
            //{

            //    CheckBox check1 = row.FindControl("chkSeleccion") as CheckBox;

            //    if (check1.Checked)
            //    {

            //        int x = 0;
            //    }

            //}
        }

        protected void GuardarLinea_Click(object sender, EventArgs e)
        {
            //String ejercicio = (sender as Button).CommandArgument;
            //int index = Convert.ToInt32(e.);
            //Label xyz = (Label)grdEjercicios.Rows[i].Cells[j].FindControl("Label" + j);
            //TextBox txtRepeticion = grdEjercicios.FindControl("txtRepeticiones") as TextBox;
            //String repeticion = txtRepeticion.Text;
            //TextBox txtSeries = grdEjercicios.FindControl("txtSeries") as TextBox;
            //String serie = txtSeries.Text;
        }
    }
}