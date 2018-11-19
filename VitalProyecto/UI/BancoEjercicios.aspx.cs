using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class BancoEjercicios : System.Web.UI.Page
    {
        private ManejadorEjercicio manejador = new ManejadorEjercicio();
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            List<HojaEjercicio> ejercicios = manejador.mostrarEjercicios();
            grdEjercicios.DataSource = ejercicios;
            grdEjercicios.DataBind();
        }

        protected void btnAgregarEjercicio_Click(object sender, EventArgs e)
        {
            if (!txtNuevoEjercicio.Text.Equals("") && txtNuevoEjercicio != null)  {
                manejador.agregarEjercicio(txtNuevoEjercicio.Text);
                grdEjercicios.DataSource = null;
                llenarGrid();
            }
            txtNuevoEjercicio.Text = "";
        }

        protected void grdEjercicios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //List<String> a =  e.Values.Values;
        }
    }
}