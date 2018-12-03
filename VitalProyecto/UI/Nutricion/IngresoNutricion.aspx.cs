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
        private static List<Medicamento> ListaMedicamSuplem = new List<Medicamento>();
        private static List<Recordatorio24H> ListaRecord24H = new List<Recordatorio24H>();
        private static decimal GETStat = 0;
        private static decimal GEBMStat = 0;
        private static decimal GEBHStat = 0;
        private static decimal GEBMenStat = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (new ControlSeguridad().validarClieNutri() == true)
            {
                Response.Redirect("~/IniciarSesion.aspx");
            }

            if (!IsPostBack)
            {
                //ListaMedicamSuplem = Session["ListaSup"] as List<Medicamento>;
                Fecha.Text = "Fecha: " + DateTime.Now;
                LlenarListas();
                tSuplementoMedico.Text = "<tr><th>Nombre</th><th>Motivo</th><th>Frecuencia</th><th>Dosis</th></tr>";
                r24Tabla.Text = "<tr><th>Tiempo de Comida</th><th>Alimento</th><th>Cantidad</th><th>Descripción</th></tr>";
            }
            //else
            //{
            //    //ListaMedicamSuplem = Session["ListaSup"] as List<Medicamento>;
            //}
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
            if (tNomMed.Text.Equals("") || tMotvMed.Text.Equals("") || tFrecMed.Text.Equals("") || tDosisMed.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                Medicamento medicamSupl = new Medicamento();
                string tabla = tSuplementoMedico.Text;
                tabla += "<tr><td>" + tNomMed.Text + "</td><td>" + tMotvMed.Text + "</td><td>" + tFrecMed.Text + "</td><td>" + tDosisMed.Text + "</td></tr>";
                tSuplementoMedico.Text = tabla;
                medicamSupl.Cedula = tCedula.Text;
                medicamSupl.Nombre = tNomMed.Text;
                medicamSupl.Motivo = tMotvMed.Text;
                medicamSupl.Frecuencia = tFrecMed.Text;
                medicamSupl.Dosis = tDosisMed.Text;
                ListaMedicamSuplem.Add(medicamSupl);
                //Session["ListaSup"] = ListaMedicamSuplem;

                tNomMed.Text = "";
                tMotvMed.Text = "";
                tFrecMed.Text = "";
                tDosisMed.Text = "";
            }
        }

        protected void R24Agrega_Click(object sender, EventArgs e)
        {
            if (r24TiempoComida.Text.Equals("") || r24Alimento.Text.Equals("") || r24Cantidad.Text.Equals("") || r24Descripcion.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                Recordatorio24H record = new Recordatorio24H();
                string tabla = r24Tabla.Text;
                tabla += "<tr><td>" + r24TiempoComida.Text + "</td><td>" + r24Alimento.Text + "</td><td>" + r24Cantidad.Text + "</td><td>" + r24Descripcion.Text + "</td></tr>";
                r24Tabla.Text = tabla;
                record.Cedula = tCedula.Text;
                record.TiempoComida = r24TiempoComida.Text;
                record.Comida = r24Alimento.Text;
                record.Cantidad = r24Cantidad.Text;
                record.Descripcion = r24Descripcion.Text;
                ListaRecord24H.Add(record);
                r24TiempoComida.Text = "";
                r24Alimento.Text = "";
                r24Cantidad.Text = "";
                r24Descripcion.Text = "";
            }
        }

        protected void GEBMujer_Click(object sender, EventArgs e)
        {
            if (GEBPI.Text.Equals("") || GEBTcm.Text.Equals("") || GEBEdad.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                decimal PI = Convert.ToDecimal(GEBPI.Text);
                decimal Tcm = Convert.ToDecimal(GEBTcm.Text);
                //decimal edad = Convert.ToDecimal(tEdadNut.Text);
                decimal edad = Convert.ToDecimal(GEBEdad.Text);
                decimal calc = Convert.ToDecimal(655 + (Convert.ToDecimal(9.6) * PI) + (Convert.ToDecimal(1.8) * Tcm) - (Convert.ToDecimal(4.7) * edad));
                GEBMStat = calc;
                GEBLblMujer.Text = "Mujer: " + calc;
            }
        }

        protected void GEBHombre_Click(object sender, EventArgs e)
        {
            if (GEBPI.Text.Equals("") || GEBTcm.Text.Equals("") || GEBEdad.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                decimal PI = Convert.ToDecimal(GEBHomPI.Text);
                decimal Tcm = Convert.ToDecimal(GEBHomTcm.Text);
                //decimal edad = Convert.ToDecimal(tEdadNut.Text);
                decimal edad = Convert.ToDecimal(GEBHomEdad.Text);
                decimal calc = Convert.ToDecimal(Convert.ToDecimal(65.5) + (Convert.ToDecimal(13.7) * PI) + (5 * Tcm) - (Convert.ToDecimal(6.8) * edad));
                GEBHStat = calc;
                GEBlblHomb.Text = "Hombre: " + calc;
            }
        }

        protected void GEBMenores_Click(object sender, EventArgs e)
        {
            if (GEBMenorPI.Text.Equals("") || GEBMenorTcm.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                decimal PI = Convert.ToDecimal(GEBMenorPI.Text);
                decimal Tcm = Convert.ToDecimal(GEBMenorTcm.Text);
                decimal calc = Convert.ToDecimal(Convert.ToDecimal(22.1) + (Convert.ToDecimal(31.05) * PI) + (Convert.ToDecimal(1.16) * Tcm));
                GEBMenStat = calc;
                GEBlblMenores.Text = "Menores de 10 años: " + calc;
            }
        }

        protected void GETBoton_Click(object sender, EventArgs e)
        {

            if (GETkcal.Text.Equals("") || GETFA.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                GETStat = Convert.ToDecimal(Convert.ToDecimal(GETkcal.Text) * Convert.ToDecimal(1.1) * Convert.ToDecimal(GETFA.Text));
            }
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            if (tCedula.Text.Equals("") || tnombre.Text.Equals("") || tApellid1.Text.Equals("") || tApellid2.Text.Equals("") || tFechNac.Text.Equals("") || tSex.Text.Equals("") || tEstCivil.Text.Equals("") || tTelef.Text.Equals("") || tResid.Text.Equals("") || tOcupacion.Text.Equals("") ||
                tCedula.Text.Equals("") || tAnteced.Text.Equals("") || tPatolog.Text.Equals("") || tFechRevis.Text.Equals("") || ActFisica.Text.Equals("") || VecesComid.Text.Equals("") || cuanExpress.Text.Equals("")|| aguAlDia.Text.Equals("")||
                tTalla.Text.Equals("")|| tPesoMeta.Text.Equals("") ||tEdadNut.Text.Equals("")|| tPMB.Text.Equals("")|| tPesoActual.Text.Equals("")|| tPesoMaxTeoria.Text.Equals("")|| tIMC.Text.Equals("")||
                tPorcGAnalizador.Text.Equals("")|| tPorcGBascula.Text.Equals("") || tGBascBI.Text.Equals("")|| tGBascBD.Text.Equals("")|| tGBascPI.Text.Equals("")|| tGBascPD.Text.Equals("")|| tGBascTronco.Text.Equals("")||
                tAguaNut.Text.Equals("") || tMasaOsea.Text.Equals("")||tComplexión.Text.Equals("")|| tEdadMetabolica.Text.Equals("")|| tCintura.Text.Equals("")|| tAbdomen.Text.Equals("")|| tCadera.Text.Equals("")||
                tMuslo.Text.Equals("")|| tCBM.Text.Equals("") || tCircunfMun.Text.Equals("")|| tPorcGVisceral.Text.Equals("") || tPorcGMusculo.Text.Equals("")|| tMuscBI.Text.Equals("")||tMuscPD.Text.Equals("")|| 
                tMuscBD.Text.Equals("") || tMuscPI.Text.Equals("") || tMuscTronco.Text.Equals("")|| PorcCHO.Text.Equals("")|| GramCHO.Text.Equals("")|| kcalCHO.Text.Equals("")|| PorcProteinas.Text.Equals("")||
                GramProteinas.Text.Equals("") || kcalProteinas.Text.Equals("") || PorcGrasas.Text.Equals("")|| GramGrasas.Text.Equals("")|| kcalGrasas.Text.Equals("") || pLeche.Text.Equals("") || pCarnes.Text.Equals("") || pVegetales.Text.Equals("") || pGrasas.Text.Equals("") || pFrutas.Text.Equals("") ||
                pAzúcares.Text.Equals("") || pHarinas.Text.Equals("") || pSuplemento.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                string sexo = "";
                if (tSex.Text.Equals("Femenino")) { sexo = "F"; } else if (tSex.Text.Equals("Masculino")) { sexo = "M"; } else { sexo = "O"; };
                Boolean creado = manejadorNutri.CrearCliente(tCedula.Text, tnombre.Text, tApellid1.Text, tApellid2.Text,
                    Convert.ToDateTime(tFechNac.Text), sexo, tEstCivil.Text, Convert.ToInt32(tTelef.Text), tResid.Text, tOcupacion.Text, DateTime.Now);
                if (creado)
                {
                    int lico = 0;
                    int fuma = 0;
                    if (tConsLicr.Text.Equals("Si")) { lico = 1; }
                    if (tConsFum.Text.Equals("Si")) { lico = 1; }
                    Boolean histAlmacn = manejadorNutri.AgregarHistorialMedico(new HistorialMedico(tCedula.Text, tAnteced.Text, tPatolog.Text, lico, fuma, tFrecFuma.Text, tFrecLicor.Text, Convert.ToDateTime(tFechRevis.Text), ActFisica.Text), ListaMedicamSuplem);
                    if (histAlmacn == true)
                    {
                        int comHorD = 0;
                        int ader = 0;
                        if (CostHorDia.Text.Equals("Si")) { comHorD = 1; }
                        if (Aderezos.Text.Equals("Si")) { ader = 1; }
                        HabitoAlimentario habito = new HabitoAlimentario(tCedula.Text, Convert.ToInt32(VecesComid.Text),
                       comHorD, Convert.ToInt32(cuanExpress.Text), queComeAfuera.Text, CuantAzucar.Text,
                       cocinaElabora.Text, Convert.ToDecimal(aguAlDia.Text), ader,
                        0, 0, 0, 0, 0, 0, 0, 0, 0);
                        if (checkListGustos.Items.FindByText("Vegetales").Selected) { habito.Verdura = 1; }
                        if (checkListGustos.Items.FindByText("Frutas").Selected) { habito.Fruta = 1; }
                        if (checkListGustos.Items.FindByText("Leche").Selected) { habito.Leche = 1; }
                        if (checkListGustos.Items.FindByText("Huevo").Selected) { habito.Huevo = 1; }
                        if (checkListGustos.Items.FindByText("Yogurt").Selected) { habito.Yogurt = 1; }
                        if (checkListGustos.Items.FindByText("Carnes").Selected) { habito.Carne = 1; }
                        if (checkListGustos.Items.FindByText("Queso").Selected) { habito.Queso = 1; }
                        if (checkListGustos.Items.FindByText("Aguacate").Selected) { habito.Aguacate = 1; }
                        if (checkListGustos.Items.FindByText("Semillas").Selected) { habito.Semillas = 1; }
                        bool habAgreg = manejadorNutri.AgregarHabitosAlimentarios(habito, ListaRecord24H);
                        if (habAgreg == true)
                        {
                            decimal Geb = 0;
                            if (GEBMStat != 0) { Geb = GEBMStat; } else if (GEBHStat != 0) { Geb = GEBHStat; } else { Geb = GEBMenStat; };
                                Antropometria antropom = new Antropometria(tCedula.Text, Convert.ToDecimal(tTalla.Text), Convert.ToDecimal(tPesoMeta.Text),
                                Convert.ToDecimal(tEdadNut.Text), Convert.ToDecimal(tPMB.Text), Convert.ToDecimal(tPesoActual.Text), Convert.ToDecimal(tPesoMaxTeoria.Text), Convert.ToDecimal(tIMC.Text),
                                Convert.ToDecimal(tPorcGAnalizador.Text), Convert.ToDecimal(tPorcGBascula.Text), Convert.ToDecimal(tGBascBI.Text), Convert.ToDecimal(tGBascBD.Text),
                                Convert.ToDecimal(tGBascPI.Text), Convert.ToDecimal(tGBascPD.Text), Convert.ToDecimal(tGBascTronco.Text), Convert.ToDecimal(tAguaNut.Text), Convert.ToDecimal(tMasaOsea.Text),
                                Convert.ToDecimal(tComplexión.Text), Convert.ToDecimal(tEdadMetabolica.Text), Convert.ToDecimal(tCintura.Text), Convert.ToDecimal(tAbdomen.Text), Convert.ToDecimal(tCadera.Text),
                                tMuslo.Text, Convert.ToDecimal(tCBM.Text), Convert.ToDecimal(tCircunfMun.Text), Convert.ToDecimal(tPorcGVisceral.Text), Convert.ToDecimal(tPorcGMusculo.Text), Convert.ToDecimal(tMuscBI.Text),
                                Convert.ToDecimal(tMuscPD.Text), Convert.ToDecimal(tMuscBD.Text), Convert.ToDecimal(tMuscPI.Text), Convert.ToDecimal(tMuscTronco.Text), tObservacion.Text,
                                Geb, GETStat, Convert.ToDecimal(PorcCHO.Text), Convert.ToDecimal(GramCHO.Text), Convert.ToDecimal(kcalCHO.Text), Convert.ToDecimal(PorcProteinas.Text),
                                Convert.ToDecimal(GramProteinas.Text), Convert.ToDecimal(kcalProteinas.Text), Convert.ToDecimal(PorcGrasas.Text), Convert.ToDecimal(GramGrasas.Text), Convert.ToDecimal(kcalGrasas.Text));

                            Porciones porc = new Porciones(tCedula.Text, Convert.ToDecimal(pLeche.Text), Convert.ToDecimal(pCarnes.Text),
                                Convert.ToDecimal(pVegetales.Text), Convert.ToDecimal(pGrasas.Text), Convert.ToDecimal(pFrutas.Text),
                                Convert.ToDecimal(pAzúcares.Text), Convert.ToDecimal(pHarinas.Text), Convert.ToDecimal(pSuplemento.Text));

                            DistribucionPorciones distrib = new DistribucionPorciones(tCedula.Text, TCAyunas.Text, TCDesayuno.Text, TCMediaMa.Text,
                                TCAlmuerzo.Text, TCMediaTard.Text, TCCena.Text, TCColacNocturna.Text);

                            bool agreTot = manejadorNutri.AgregarAntropometria(antropom, porc, distrib);
                            if (agreTot == true)
                            { Response.Write("Cliente Registrado!"); }
                            else { Response.Write("Cliente No Registrado"); }

                        }
                    }
                    else { Response.Write("<script>alertify.notify('Registro no se realizó correctamente', 'error', 5, null); </script>"); }

                }
                else { Response.Write("<script language=\"JavaScript\" type=\"text / JavaScript\">alertify.notify('Registro no se realizó correctamente', 'error', 5, null); </script>"); }
            }
            limpiarControles();

        }

        private void limpiarControles() {
            tCedula.Text = string.Empty; tnombre.Text = string.Empty; tApellid1.Text = string.Empty; tApellid2.Text = string.Empty;
            tFechNac.Text = string.Empty; tSex.Text = string.Empty; tEstCivil.Text = string.Empty; tTelef.Text = string.Empty;
            tResid.Text = string.Empty; tOcupacion.Text = string.Empty; tAnteced.Text = string.Empty; tPatolog.Text = string.Empty;
            tFechRevis.Text = string.Empty; ActFisica.Text = string.Empty; VecesComid.Text = string.Empty; cuanExpress.Text = string.Empty;
            aguAlDia.Text = string.Empty; tTalla.Text = string.Empty; tPesoMeta.Text = string.Empty; tEdadNut.Text = string.Empty;
            tPMB.Text = string.Empty; tPesoActual.Text = string.Empty; tPesoMaxTeoria.Text = string.Empty; tIMC.Text = string.Empty;
            tPorcGAnalizador.Text = string.Empty; tPorcGBascula.Text = string.Empty; tGBascBI.Text = string.Empty;
            tGBascBD.Text = string.Empty; tGBascPI.Text = string.Empty; tGBascPD.Text = string.Empty; tGBascTronco.Text = string.Empty;
            tAguaNut.Text = string.Empty; tMasaOsea.Text = string.Empty; tComplexión.Text = string.Empty; tEdadMetabolica.Text = string.Empty;
            tCintura.Text = string.Empty; tAbdomen.Text = string.Empty; tCadera.Text = string.Empty; tMuslo.Text = string.Empty; tCBM.Text = string.Empty;
            tCircunfMun.Text = string.Empty; tPorcGVisceral.Text = string.Empty; tPorcGMusculo.Text = string.Empty; tMuscBI.Text = string.Empty;
            tMuscPD.Text = string.Empty; tMuscBD.Text = string.Empty; tMuscPI.Text = string.Empty;
            tMuscTronco.Text = string.Empty; PorcCHO.Text = string.Empty; GramCHO.Text = string.Empty; kcalCHO.Text = string.Empty; PorcProteinas.Text = string.Empty;
            GramProteinas.Text = string.Empty; kcalProteinas.Text = string.Empty; PorcGrasas.Text = string.Empty; GramGrasas.Text = string.Empty;
            kcalGrasas.Text = string.Empty; pLeche.Text = string.Empty; pCarnes.Text = string.Empty; pVegetales.Text = string.Empty; pGrasas.Text = string.Empty;
            pFrutas.Text = string.Empty; pAzúcares.Text = string.Empty; pHarinas.Text = string.Empty; pSuplemento.Text = string.Empty;
        }
        protected void tFechNac_TextChanged(object sender, EventArgs e)
        {
            if (tFechNac.Text.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                DateTime nacimiento = Convert.ToDateTime(tFechNac.Text);
                int años = DateTime.Now.Year - nacimiento.Year;
                if (nacimiento.Month > DateTime.Now.Month)
                {
                    tEdad.Text = "" + (años - 1);
                }
                else
                {
                    if (nacimiento.Month == DateTime.Now.Month)
                    {
                        if (nacimiento.Day < DateTime.Now.Day)
                        {
                            tEdad.Text = "" + (años - 1);
                        }
                        else
                        {
                            tEdad.Text = "" + años;
                        }
                    }
                    else
                    {
                        tEdad.Text = "" + años;
                    }
                }
            }
        }

        protected void timerTest_Tick(object sender, EventArgs e)
        {
            DateTime timeUtc = DateTime.UtcNow;
            try
            {
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
                DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cstZone);
                cstTime = cstTime.AddHours(-1);
                Fecha.Text = "Fecha: " + cstTime;
            }
            catch (TimeZoneNotFoundException)
            {
                Response.Write("<script>alert('El registro no define la zona CST.')</script>");
            }
            catch (InvalidTimeZoneException)
            {
                Response.Write("<script>alert('El registro de datos en la zona CST ha sido corrupta .')</script>");
            }
            
        }
    }
}