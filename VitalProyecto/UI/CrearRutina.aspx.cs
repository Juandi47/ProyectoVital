using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class CrearRutina : System.Web.UI.Page
    {
        private String nombreRutina;
        private static List<HojaRutina> lista = new List<HojaRutina>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (new ControlSeguridad().validarAdmin() == true)
            {
                Response.Redirect("~/IniciarSesion.aspx");
            }

            nombreRutina = Session["Rutina"] as String;
            if (!IsPostBack)
                llenarGrid();
        }
        private void llenarGrid()
        {
            ManejadorEjercicio manejador = new ManejadorEjercicio();
            List<HojaEjercicio> ejercicios = manejador.mostrarEjercicios();

            grdEjercicios.DataSource = ejercicios;
            grdEjercicios.DataBind();
            if (nombreRutina != null)
            {
                llenarCampos();
            }
        }

        protected void btnCrearRutina_Click(object sender, EventArgs e)
        {

            ManejadorRutina manejador = new ManejadorRutina();

            String nombreRutina = Controlador.RemoveAccentsWithRegEx(txtNuevaRutina.Text);

            if (this.nombreRutina != null)
            {
                DateTime Hoy = DateTime.Today;
                string fecha_actual = Hoy.ToString("yyyy-MM-dd");
                List<Ejercicio> ejercicios = manejador.pasarAEjercicios(lista);
                Rutina rutina = new Rutina(0, fecha_actual, nombreRutina, ejercicios);
                manejador.eliminarRutina(rutina.Nombre);
                manejador.agregarRutina(rutina);
                Response.Redirect("BancoRutinas.aspx");
            }
            else {
                if (!manejador.existenciaRutina(nombreRutina))
                {

                    DateTime Hoy = DateTime.Today;
                    string fecha_actual = Hoy.ToString("yyyy-MM-dd");
                    List<Ejercicio> ejercicios = manejador.pasarAEjercicios(lista);
                    Rutina rutina = new Rutina(0, fecha_actual, nombreRutina, ejercicios);
                    manejador.agregarRutina(rutina);
                    Response.Redirect("BancoRutinas.aspx");
                }
                else {
                    VerificadorExistencia.Visible = true;
                }
            }







        }

        protected void GuardarLinea_Click(object sender, EventArgs e)
        {
            int rowIndex = Convert.ToInt32((sender as Button).CommandArgument);
            String ejercicio = grdEjercicios.Rows[rowIndex].Cells[1].Text;
            TextBox txtRepeticiones = (TextBox)grdEjercicios.Rows[rowIndex].FindControl("txtRepeticiones");
            String repeticiones = txtRepeticiones.Text;
            TextBox txtSeries = (TextBox)grdEjercicios.Rows[rowIndex].FindControl("txtSeries");
            String serie = txtSeries.Text;

            if (repeticiones.Equals("") || serie.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else
            {
                lista.Add(new HojaRutina(ejercicio, int.Parse(repeticiones), int.Parse(serie)));
                grdEjercicios.Rows[rowIndex].FindControl("GuardarLinea").Visible = false;
                grdEjercicios.Rows[rowIndex].FindControl("DescartarLinea").Visible = true;
            }




        }

        protected void DescartarLinea_Click(object sender, EventArgs e)
        {
            int rowIndex = Convert.ToInt32((sender as Button).CommandArgument);
            String ejercicio = grdEjercicios.Rows[rowIndex].Cells[1].Text;
            foreach (HojaRutina x in lista)
            {
                if (x.Ejercicio.Equals(ejercicio))
                {
                    lista.Remove(x);
                    grdEjercicios.Rows[rowIndex].FindControl("GuardarLinea").Visible = true;
                    grdEjercicios.Rows[rowIndex].FindControl("DescartarLinea").Visible = false;
                    TextBox txtRepeticiones = (TextBox)grdEjercicios.Rows[rowIndex].FindControl("txtRepeticiones");
                    TextBox txtSeries = (TextBox)grdEjercicios.Rows[rowIndex].FindControl("txtSeries");
                    CheckBox chkSeleccion = (CheckBox)grdEjercicios.Rows[rowIndex].FindControl("chkSeleccion");
                    txtRepeticiones.Text = "";
                    txtSeries.Text = "";
                    chkSeleccion.Checked = false;
                    break;
                }
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ManejadorEjercicio manejador = new ManejadorEjercicio();

            grdEjercicios.DataSource = manejador.buscarEjercicio(txtBuscarEjercicio.Text); ;
            grdEjercicios.DataBind();
        }

        public void llenarCampos()
        {
            txtNuevaRutina.Text = nombreRutina;
            int check = 0;
            ManejadorRutina manejador = new ManejadorRutina();
            List<HojaRutina> ejercicios = manejador.MostrarRutina(nombreRutina);
            for (int i = 0; i < grdEjercicios.Rows.Count; i++)
            {

                for (int x = 0; x < ejercicios.Count; x++)
                {
                    if (grdEjercicios.Rows[i].Cells[1].Text.Equals(ejercicios[x].Ejercicio))
                    {
                        CheckBox chk = (CheckBox)grdEjercicios.Rows[i].FindControl("chkSeleccion");
                        chk.Checked = true;
                        TextBox repeticiones = (TextBox)grdEjercicios.Rows[i].FindControl("txtRepeticiones");
                        repeticiones.Text = ejercicios[x].Repeticiones + "";
                        TextBox series = (TextBox)grdEjercicios.Rows[i].FindControl("txtSeries");
                        series.Text = ejercicios[x].Series + "";
                        Button guardarLinea = (Button)grdEjercicios.Rows[i].FindControl("GuardarLinea");
                        guardarLinea.Visible = false;
                        Button descartarLinea = (Button)grdEjercicios.Rows[i].FindControl("descartarLinea");
                        descartarLinea.Visible = true;
                        check++;
                    }
                    if (check == ejercicios.Count)
                    {
                        i = grdEjercicios.Rows.Count;
                        x = ejercicios.Count;
                    }
                }


            }
            agregarMarcadosLista();
        }

        public void agregarMarcadosLista()
        {
            for (int i = 0; i < grdEjercicios.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)grdEjercicios.Rows[i].FindControl("chkSeleccion");
                if (chk.Checked)
                {
                    String ejercicio = grdEjercicios.Rows[i].Cells[1].Text;
                    TextBox txtRepeticiones = (TextBox)grdEjercicios.Rows[i].FindControl("txtRepeticiones");
                    String repeticiones = txtRepeticiones.Text;
                    TextBox txtSeries = (TextBox)grdEjercicios.Rows[i].FindControl("txtSeries");
                    String serie = txtSeries.Text;
                    lista.Clear();
                    lista.Add(new HojaRutina(ejercicio, int.Parse(repeticiones), int.Parse(serie)));
                }

            }
        }
    }
}