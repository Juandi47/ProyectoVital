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
		private static List<Medida> lista = new List<Medida>();


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
			lbNomCompleto.Text = usuarioSesion.nombre + " " + usuarioSesion.apellido1 +
				" " + usuarioSesion.apellido2;
			lbCedula.Text = usuarioSesion.cedula;
			lbCorreo.Text = usuarioSesion.correo;
			
		}

		public void informacionCliente()
		{
			Usuario usuarioSesion = Session["usuarioSesion"] as Usuario;
			Cliente clien = new ManejadorCliente().buscarCliente(usuarioSesion.cedula);
			Medida medida = new ManejadorMedida().buscarMedidaCliente(usuarioSesion.cedula);
			lista = new ManejadorMedida().listaMedidas(usuarioSesion.cedula);

			try
			{

				if (clien != null)
				{
					lbNacim.Text = clien.Fecha_Nacimiento.ToString();
					lbTel.Text = clien.Telefono.ToString();
					lbObs.Text = clien.Observacion;
					lbMens.Text = clien.Fecha_Mensualidad.ToString();
				}
				else
				{

				}

				tablaExped.Text = "<tr><th>Frecuencia cardiaca</th><th>Peso</th><th>Porcentaje de grasa</th><th>IMC</th><th>Cintura</th><th>Abdomen</th><th>Cadera</th><th>Muslo</th><th>Estatura</th><th>Fecha</th><th>Mensualidad</th></tr>";
				foreach (Medida med in lista)
				{
					string tabla = tablaExped.Text;
					tabla += "<tr><td>" + med.Frec_Cardiaca + "</td><td>" + med.Peso + "</td><td>" + med.Porcent_Grasa + "</td><td>" + med.IMC + "</td><td>" + med.Cintura + "</td><td>" + med.Abdomen + "</td><td>" + med.Cadera + "</td><td>" + med.Muslo + "</td><td>" + med.Estatura + "</td><td>" + med.Fecha_Medida + "</td><td>" + mostrarMes(med.Fecha_Medida.Month) + "</td></tr>";
					tablaExped.Text = tabla;
				}

				
			}
			catch (Exception)
			{

			}


		}

		public string mostrarMes(int mes)
		{
			if (mes == 01)
			{
				return "Enero";
			} else if (mes == 02) {
				return "Febrero";
			}
			else if (mes == 03)
			{
				return "Marzo";
			}
			else if (mes == 04)
			{
				return "Abril";
			}
			else if (mes == 05)
			{
				return "Mayo";
			}
			else if (mes == 06)
			{
				return "Junio";
			}
			else if (mes == 07)
			{
				return "Julio";
			}
			else if (mes == 08)
			{
				return "Agosto";
			}
			else if (mes == 09)
			{
				return "Setiembre";
			}
			else if (mes == 10)
			{
				return "Octubre";
			}
			else if (mes == 11)
			{
				return "Noviembre";
			}
			else if (mes == 12)
			{
				return "Diciembre";
			}
			else
			{
				return null;
			}
		}

}
}