﻿using System;
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
			if (new ControlSeguridad().validarAdmin() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}
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
                manejador.agregarEjercicio(Controlador.RemoveAccentsWithRegEx(txtNuevoEjercicio.Text));
                grdEjercicios.DataSource = null;
                llenarGrid();
            }
            txtNuevoEjercicio.Text = "";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            manejador.eliminarEjercicio((sender as LinkButton).CommandArgument);
            llenarGrid();
        }
    }
}