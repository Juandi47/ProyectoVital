using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Nutricion
{
    public partial class PrimerIngreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Fecha.Text = "Fecha: " + DateTime.Now.Date;
            LlenarListas();
        }

        private void LlenarListas()
        {
            //Lista Sexo
            tSex.Items.Add("Masculino");
            tSex.Items.Add("Femenino");
            tSex.Items.Add("Otro");
            //Lista consumo Licor
            tConsLicr.Items.Add("Sí");
            tConsLicr.Items.Add("No");
            //Lista si Fuma o no
            tConsFum.Items.Add("Sí");
            tConsFum.Items.Add("No");
            //Lista Estado Civil
            tEstCivil.Items.Add("Soltero");
            tEstCivil.Items.Add("Casado");
            tEstCivil.Items.Add("Unión Libre");
            tEstCivil.Items.Add("Viudo");
            tEstCivil.Items.Add("Otro");
            //Lista de Elaboracion de la comida
            cocinaElabora.Items.Add("Con Aceite");
            cocinaElabora.Items.Add("Horneadas");
            cocinaElabora.Items.Add("Hervidos");
            cocinaElabora.Items.Add("Microondas");
            //Lista de Gustos
            checkListGustos.Items.Add("Vegetales");
            checkListGustos.Items.Add("Frutas");
            checkListGustos.Items.Add("Leche");
            checkListGustos.Items.Add("Huevo");
            checkListGustos.Items.Add("Yogurt");
            checkListGustos.Items.Add("Carnes");
            checkListGustos.Items.Add("Queso");
            checkListGustos.Items.Add("Aguacate");
            checkListGustos.Items.Add("Semillas");
        }

        protected void btnAgreg_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Seleccionado: "+ checkListGustos.SelectedValue+"')</script>");
            
        }
    }
}