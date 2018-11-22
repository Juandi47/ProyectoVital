using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI.Nutricion
{
    public partial class IngresoNutricion : System.Web.UI.Page
    {
        ManejadorNutrición manejadorNutri = new ManejadorNutrición();
        List<Medicamento> ListaMedicamSuplem; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListaMedicamSuplem = new List<Medicamento>();
                Fecha.Text = "Fecha: " + DateTime.Now;
                LlenarListas();
                tSuplementoMedico.Text = "<tr><th>Nombre</th><th>Motivo</th><th>Frecuencia</th><th>Dosis</th></tr>";
                r24Tabla.Text = "<tr><th>Tiempo de Comida</th><th>Alimento</th><th>Cantidad</th><th>Descripción</th></tr>";
            }
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
            //Acostumbra a comer a las horas del dia
            CostHorDia.Items.Add("Sí");
            CostHorDia.Items.Add("No");
            //Lista Aderezos
            Aderezos.Items.Add("Sí");
            Aderezos.Items.Add("No");
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

        protected void BtnAgreg_Click(object sender, EventArgs e)
        {
            Medicamento medicamSupl = new Medicamento();
            string tabla = tSuplementoMedico.Text;
            tabla += "<tr><td>" + tNomMed.Text + "</td><td>" + tMotvMed.Text +"</td><td>"+ tFrecMed.Text +"</td><td>"+ tDosisMed.Text +"</td></tr>";
            tSuplementoMedico.Text = tabla;
            medicamSupl.Cedula = tCedula.Text;
            medicamSupl.Nombre = tNomMed.Text;
            medicamSupl.Motivo = tMotvMed.Text;
            medicamSupl.Frecuencia = tFrecMed.Text;
            medicamSupl.Dosis = tDosisMed.Text;
            ListaMedicamSuplem.Add(medicamSupl);

            tNomMed.Text = "";
            tMotvMed.Text = "";
            tFrecMed.Text = "";
            tDosisMed.Text = "";
        }

        protected void R24Agrega_Click(object sender, EventArgs e)
        {
            string tabla = r24Tabla.Text;
            tabla += "<tr><td>" + r24TiempoComida.Text + "</td><td>" + r24Alimento.Text + "</td><td>" + r24Cantidad.Text + "</td><td>" + r24Descripcion.Text + "</td></tr>";
            tSuplementoMedico.Text = tabla;
            tNomMed.Text = "";
            tMotvMed.Text = "";
            tFrecMed.Text = "";
            tDosisMed.Text = "";
        }

        protected void GEBMujer_Click(object sender, EventArgs e)
        {
            decimal PI = Convert.ToDecimal(GEBPI.Text);
            decimal Tcm = Convert.ToDecimal(GEBTcm.Text);
            //decimal edad = Convert.ToDecimal(tEdadNut.Text);
            decimal edad = Convert.ToDecimal(GEBEdad.Text);
            decimal calc = Convert.ToDecimal(655 + ( Convert.ToDecimal(9.6) * PI) + (Convert.ToDecimal(1.8) * Tcm) - (Convert.ToDecimal(4.7) * edad));
            GEBLblMujer.Text = "Mujer: " + calc;
        }

        protected void GEBHombre_Click(object sender, EventArgs e)
        {
            decimal PI = Convert.ToDecimal(GEBHomPI.Text);
            decimal Tcm = Convert.ToDecimal(GEBHomTcm.Text);
            //decimal edad = Convert.ToDecimal(tEdadNut.Text);
            decimal edad = Convert.ToDecimal(GEBHomEdad.Text);
            decimal calc = Convert.ToDecimal(Convert.ToDecimal(65.5) + (Convert.ToDecimal(13.7) * PI) + (5 * Tcm) - (Convert.ToDecimal(6.8) * edad));
            GEBlblHomb.Text = "Hombre: " + calc;
        }

        protected void GEBMenores_Click(object sender, EventArgs e)
        {
            decimal PI = Convert.ToDecimal(GEBMenorPI.Text);
            decimal Tcm = Convert.ToDecimal(GEBMenorTcm.Text);
            decimal calc = Convert.ToDecimal(Convert.ToDecimal(22.1) + (Convert.ToDecimal(31.05) * PI) +  (Convert.ToDecimal(1.16) * Tcm));
            GEBlblMenores.Text = "Menores de 10 años: " + calc;
        }

        protected void GETBoton_Click(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}