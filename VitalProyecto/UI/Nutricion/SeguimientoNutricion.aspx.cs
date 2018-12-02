using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI.Nutricion
{
    public partial class SeguimientoNutricion : System.Web.UI.Page
    {
        private static List<SeguimientoRecord24> listaRecord = new List<SeguimientoRecord24>();
        ManejadorNutrición manejador = new ManejadorNutrición();
        protected void Page_Load(object sender, EventArgs e)
        {
			if (new ControlSeguridad().validarClieNutri() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}
			if (!IsPostBack)
            {
                Fecha.Text = "Fecha: " + DateTime.Now;
                r24Tabla.Text = "<tr><th>Tiempo de Comida</th><th>Descripción</th></tr>";
            }
        }

        protected void r24Agrega_Click(object sender, EventArgs e)
        {
            if (r24TiempoComida.Text.Equals("") || r24Descripcion.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                SeguimientoRecord24 record = new SeguimientoRecord24();
                string tabla = r24Tabla.Text;
                tabla += "<tr><td>" + r24TiempoComida.Text + "</td><td>" + r24Descripcion.Text + "</td></tr>";
                r24Tabla.Text = tabla;
                record.TiempoComida = r24TiempoComida.Text;
                record.Descripcion = r24Descripcion.Text;
                listaRecord.Add(record);
                r24TiempoComida.Text = "";
                r24Descripcion.Text = "";
            }
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            if (tCedula.Text.Equals("") || tDiasEjer.Text.Equals("") || tComExtras.Text.Equals("") || tNivelAnsiedad.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                SegAntropometria segAntrop = new SegAntropometria(
                Convert.ToDecimal(tTalla.Text),
                Convert.ToDecimal(tPesoIdeal.Text),
                Convert.ToDecimal(tEdadNut.Text),
                Convert.ToDecimal(tPMB.Text),
                DateTime.Now,
                Convert.ToDecimal(tPeso.Text),
                Convert.ToDecimal(tIMC.Text),
                Convert.ToDecimal(tPorcGAnalizador.Text),
                Convert.ToDecimal(tPorcGBascula.Text),
                Convert.ToDecimal(tGBascBI.Text),
                Convert.ToDecimal(tGBascBD.Text),
                Convert.ToDecimal(tGBascPI.Text),
                Convert.ToDecimal(tGBascPD.Text),
                Convert.ToDecimal(tGBascTronco.Text),
                Convert.ToDecimal(tPorcGVisceral.Text),
                Convert.ToDecimal(tPorcGMusculo.Text),
                Convert.ToDecimal(tMuscBI.Text),
                 Convert.ToDecimal(tMuscPD.Text),
                 Convert.ToDecimal(tMuscBD.Text),
                 Convert.ToDecimal(tMuscPI.Text),
                 Convert.ToDecimal(tMuscTronco.Text),
                Convert.ToDecimal(tAguaNut.Text),
                Convert.ToDecimal(tMasaOsea.Text),
                Convert.ToDecimal(tComplexión.Text),
                Convert.ToDecimal(tEdadMetabolica.Text),
                Convert.ToDecimal(tCintura.Text),
                Convert.ToDecimal(tAbdomen.Text),
                Convert.ToDecimal(tCadera.Text),
                tMuslo.Text,
                Convert.ToDecimal(tBrazo.Text),
                tObservacion.Text);
                if(listaRecord.Count == 0)
                {
                    listaRecord = null;
                }
                bool alm = manejador.AgregaSegNutri(new SeguimientoNutri(tCedula.Text, Convert.ToInt32(tDiasEjer.Text), tComExtras.Text, tNivelAnsiedad.Text), listaRecord, segAntrop);
                if (alm)
                {
                    Response.Write("<script>alert('Seguimiento Almacenado Exitosamente')</script>");
                    LimpiarControles();
                }
                else
                {
                    Response.Write("<script>alert('Seguimiento No fue Almacenado')</script>");
                    LimpiarControles();
                }
            }
        }
        public void LimpiarControles()
        {
            tCedula.Text = string.Empty; tDiasEjer.Text = string.Empty; tComExtras.Text = string.Empty;
            tNivelAnsiedad.Text = string.Empty; r24TiempoComida.Text = string.Empty; r24Descripcion.Text = string.Empty;
            tTalla.Text = string.Empty; tPesoIdeal.Text = string.Empty; tEdadNut.Text = string.Empty; tPMB.Text = string.Empty;
            tPeso.Text = string.Empty; tIMC.Text = string.Empty; tPorcGAnalizador.Text = string.Empty; tPorcGBascula.Text = string.Empty;
            tGBascBI.Text = string.Empty; tGBascBD.Text = string.Empty; tGBascPI.Text = string.Empty; tGBascPD.Text = string.Empty;
            tGBascTronco.Text = string.Empty; tPorcGVisceral.Text = string.Empty; tPorcGMusculo.Text = string.Empty;
            tMuscBI.Text = string.Empty; tMuscPD.Text = string.Empty;tMuscBD.Text = string.Empty;tMuscPI.Text = string.Empty;
            tMuscTronco.Text = string.Empty; tAguaNut.Text = string.Empty;tMasaOsea.Text = string.Empty; tComplexión.Text = string.Empty;
            tEdadMetabolica.Text = string.Empty; tCintura.Text = string.Empty;tAbdomen.Text = string.Empty; tCadera.Text = string.Empty;
            tMuslo.Text = string.Empty;tBrazo.Text = string.Empty;tObservacion.Text = string.Empty;
        }
    }

}





    