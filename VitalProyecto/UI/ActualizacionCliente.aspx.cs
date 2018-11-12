using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ActualizacionCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAñadirExpediente_Click(object sender, EventArgs e)
        {
			string Cedula = txtCed.Text;
			string Frec_Cardiaca = tfrec.Text;
			decimal Peso = Convert.ToDecimal(tweigth.Text);
			decimal Porcent_Grasa = Convert.ToDecimal(tpercentWeigth.Text);
			decimal IMC = Convert.ToDecimal(timc.Text);
			decimal Abdomen = Convert.ToDecimal(tabdomen.Text);
			decimal Cadera = Convert.ToDecimal(thip.Text);
			decimal Muslo = Convert.ToDecimal(tthigth.Text);
			decimal Estatura = Convert.ToDecimal(theigth.Text);

	}


	}
}