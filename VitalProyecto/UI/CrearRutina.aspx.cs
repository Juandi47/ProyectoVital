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
        private static List<HojaRutina> lista = new List<HojaRutina>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
            String nombreRutina = txtNuevaRutina.Text;

            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("yyyy-MM-dd");
            ManejadorRutina manejador = new ManejadorRutina();
            List<Ejercicio> ejercicios = manejador.pasarAEjercicios(lista);
            Rutina rutina = new Rutina(0, fecha_actual,nombreRutina,ejercicios);
            manejador.agregarRutina(rutina);
            
        }

        protected void GuardarLinea_Click(object sender, EventArgs e)
        {
            int rowIndex = Convert.ToInt32((sender as Button).CommandArgument);
            String ejercicio = grdEjercicios.Rows[rowIndex].Cells[1].Text;
            TextBox txtRepeticiones = (TextBox)grdEjercicios.Rows[rowIndex].FindControl("txtRepeticiones");
            String repeticiones = txtRepeticiones.Text;            
            TextBox txtSeries = (TextBox)grdEjercicios.Rows[rowIndex].FindControl("txtSeries");
            String serie = txtSeries.Text;

            lista.Add(new HojaRutina(ejercicio, int.Parse(repeticiones), int.Parse(serie)));
        }
    }
}