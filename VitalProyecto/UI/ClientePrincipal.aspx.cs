using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
	public partial class ClientePrincipal : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (new ControlSeguridad().validarCliente() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}

			llenarCampos();
			informacionCliente();
		}

		public void llenarCampos()
		{
            BL.Usuario usuarioSesion = Session["usuarioSesion"] as Usuario;
			lbNombre.Text = usuarioSesion.nombre;
			lbApe1.Text = usuarioSesion.apellido1;
			lbApe2.Text = usuarioSesion.apellido2;
			lbCedula.Text = usuarioSesion.cedula;
			lbCorreo.Text = usuarioSesion.correo;
		}

		public void informacionCliente()
		{
			Usuario usuarioSesion = Session["usuarioSesion"] as Usuario;
			Cliente clien = new ManejadorCliente().buscarCliente(usuarioSesion.cedula);
			Medida medida = new ManejadorMedida().buscarMedidaCliente(usuarioSesion.cedula);

			if (clien != null && medida != null)
			{
				lbFecNac.Text = clien.Fecha_Nacimiento.ToString();
				lbTelefono.Text = clien.Telefono.ToString();
				lbObserva.Text = clien.Observacion;
				lbFecMens.Text = clien.Fecha_Mensualidad.ToString();
				lbFrec.Text = medida.Frec_Cardiaca.ToString();
				lbPeso.Text = medida.Peso.ToString();
				lbGrasa.Text = medida.Porcent_Grasa.ToString();
				lbIMC.Text = medida.IMC.ToString();
				lbCintura.Text = medida.Cintura.ToString();
				lbAbdomen.Text = medida.Abdomen.ToString();
				lbCadera.Text = medida.Cadera.ToString();
				lbMuslo.Text = medida.Muslo.ToString();
				lbEstatura.Text = medida.Estatura.ToString();
			}

		
		}


	}
}