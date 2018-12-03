using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class ActualizacionCliente : System.Web.UI.Page
    {
        ManejadorMedida manejador = new ManejadorMedida();
		ManejadorCliente manCliente = new ManejadorCliente();
        protected void Page_Load(object sender, EventArgs e)
        {
			if (new ControlSeguridad().validarAdmin() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}

		}

        protected void btnAñadirExpediente_Click(object sender, EventArgs e)
        {
			if (!manCliente.verificarCliente(txtCed.Text))
			{
				lbCedMala.Text = "Cliente no encontrado";
			} else { 

            string Cedula = txtCed.Text;
            string Frec_Cardiaca = tfrecCard.Text;
            decimal Peso = Convert.ToDecimal(tPeso.Text);
            decimal Porcent_Grasa = Convert.ToDecimal(tpercentGrasa.Text);
            decimal IMC = Convert.ToDecimal(tImc.Text);
            decimal Abdomen = Convert.ToDecimal(tabdomen.Text);
            decimal Cadera = Convert.ToDecimal(tCadera.Text);
            decimal Muslo = Convert.ToDecimal(tMuslo.Text);
            decimal Estatura = Convert.ToDecimal(tEstatura.Text);
            decimal Cintura = Convert.ToDecimal(tcintura.Text);


            Boolean t = manejador.AgregarMedida(Frec_Cardiaca, Peso, Porcent_Grasa, IMC, Cintura, Abdomen, Cadera, Muslo, Estatura, Cedula, DateTime.Now.Date);
            if (t == false)
            {
				
				ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "error();", true);
                limpiarControles();
            }
            else
            {
				ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);
				limpiarControles();
            }
			}
        }


        private void limpiarControles()
        {

            txtCed.Text = string.Empty;
            tfrecCard.Text = string.Empty;
            tPeso.Text = string.Empty;
            tpercentGrasa.Text = string.Empty;
            tImc.Text = string.Empty;
            tabdomen.Text = string.Empty;
            tCadera.Text = string.Empty;
            tMuslo.Text = string.Empty;
            tEstatura.Text = string.Empty;
            tcintura.Text = string.Empty;
            
        }
        
    }
}