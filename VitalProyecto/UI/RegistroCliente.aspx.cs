using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Login = BL.Ingreso;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace UI
{
    public partial class RegistroCliente : System.Web.UI.Page
    {

        private String[] meses;
        private static Cliente cliente;
        String correo = "";
        Boolean cliente_creado;
        public byte[] IV = Encoding.ASCII.GetBytes("clave");
        public byte[] Clave = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (new ControlSeguridad().validarAdmin() == true)
            //{
            //    Response.Redirect("~/IniciarSesion.aspx");
            //}

            string accion = Convert.ToString(Request.QueryString["accion"]);

            if (accion != null && accion.Equals("mod")) {
                cargarEdicionUsuario();
                ingresoDIV.Visible = false;
            } else {
                ingresoDIV.Visible = false;
                divExtra.Visible = false;
                meses = new string[] { "MES","Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio",
            "Agosto","Septiembre", "Octubre", "Noviembre", "Diciembre"};

                if (!Page.IsPostBack)
                {
                    cargarFechas();
                    cliente = new Cliente();
            }
                else {
                    cliente = Session["cliente"] as Cliente;
                }
        }
        }

        private void cargarEdicionUsuario() {

            string idEn = Convert.ToString(Request.QueryString["key"]);
            
            string idDes = decrypt(idEn).Substring(4);

            tituloH1.Text = "ACTUALIZACION DATOS CLIENTE:";
            btnCredenciales.Enabled = false;
            btnCredenciales.Visible = false;
            btnCrearCuenta.Enabled = false;
            btnCrearCuenta.Visible = false;
            btnBusqueda.Enabled = false;
            btnBusqueda.Visible = false;
            btnModificar.Text = "Actualizar";
            cargarInfoUsuario(idDes);

        }

        private string decrypt(string str)
        {
            string _result = string.Empty;
            char[] temp = str.ToCharArray();
            foreach (var _singleChar in temp)
            {
                var i = (int)_singleChar;
                i = i + 2;
                _result += (char)i;
            }
            return _result;
        }

        private void cargarFechas() {

            int anio = 1900;
            int maxAnio = 2100;

            ListItem anioItem = new ListItem("AÑO", "", true);
            DLAnno.Items.Add(anioItem);

            ListItem diaItem0 = new ListItem("DIA", "", true);
            DlDia.Items.Add(diaItem0);

            while (anio <= maxAnio) {
                DLAnno.Items.Add(anio.ToString());
                anio++;
            }

            for (int i = 0; i < meses.Length; i++) {
                ListItem mesItem = new ListItem(meses[i], (i + 1) + "", true);
                DlMes.Items.Add(mesItem);
            }

            for (int i = 0; i < 31; i++) {
                ListItem diaItem = new ListItem((i + 1) + "", (i + 1) + "", true);
                DlDia.Items.Add(diaItem);
            }

            DlMes.DataBind();
            DlDia.DataBind();

        }

        protected void DlMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mesSeleccionado = int.Parse(DlMes.SelectedItem.Value);

            if (mesSeleccionado == 2) {


                DlDia.Items[31].Enabled = false;
                DlDia.Items[30].Enabled = false;
                DlDia.Items[29].Enabled = false;

            } else if (mesSeleccionado == 4 || mesSeleccionado == 6 || mesSeleccionado == 9 || mesSeleccionado == 11) {

                DlDia.Items[31].Enabled = false;

            }
            DlDia.DataBind();
        }

        protected void btnRegistrarConCuenta_Click(object sender, EventArgs e)
        {
            if (pass1.Text.Equals(pass2.Text))
            {
                String pass = pass1.Text;
                //registrar login
                Ingreso log = new Ingreso(correo, pass, "cliente");
                new ManejadorIngreso().registrarLogin(log);

                cliente_creado = new ManejadorCliente().registrarClienteBL(cliente);
                if (cliente_creado)
            {
                    Response.Write("<script>alert('Cliente registrado correctamente CON CUENTA')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Error en registro de cliente')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Contraseñas invalidas CON CUENTA')</script>");
            }
            //ingresoDIV.Visible = false;
            //habilitarCampos();
            limpiarCampos();
        }

            protected void btnRegistrar_Click(object sender, EventArgs e){

                DateTime fecha_nac;
                String correo = txbcorreo.Text;
                String obs = txbobs.Text;
                //String pass = pass1.Text;

              
            if (!btnModificar.Text.Equals("Actualizar"))
            {
                if (camposVacios())
                {

                    fecha_nac = new DateTime(int.Parse(DLAnno.SelectedValue), int.Parse(DlMes.SelectedValue), int.Parse(DlDia.SelectedItem.Text));
                    crearRegistroCliente();

                    cliente_creado = new ManejadorCliente().registrarClienteBL(cliente);
                        if (cliente_creado){
                        Response.Write("<script>alert('Cliente registrado correctamente SIN CUENTA')</script>");
                        }else{
                        Response.Write("<script>alert('Error en registro de cliente')</script>");
                        }

                }
                else
                {
                    Response.Write("<script>alert('Error: Campos incompletos')</script>");
                }
            }
            else
            {
                if (!txbobs.Equals("") && !txbtelefono.Equals(""))
                {
                    cliente.Observacion = txbobs.Text;
                    cliente.Telefono = int.Parse(txbtelefono.Text);
                    Boolean modificado = new ManejadorCliente().modificarCliente(cliente, textBoxClave.Text);
                    if (modificado)
                    {
                        Response.Write("<script>alert('Cliente modificado correctamente.')</script>");
                        Response.Redirect("ListaClientesAdmin.aspx");
                    }
                       

                    else {
                        Response.Write("<script>alert('Error 404.')</script>");
                    }
                }
                else {
                    Response.Write("<script>alert('Error: Datos incorrectos a modificar. (Telefono, Observaciones)')</script>");
                }
                
            }
                
            
            //ingresoDIV.Visible = false;
            //habilitarCampos();
            limpiarCampos();
        }
        

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            //REGISTRO
            if (tituloH1.Text.Equals("Registro de cliente"))
            {
                if (!txbced.Text.Equals(""))
                {
                    if (cliente == null)
                        cliente = new Cliente();

                    cliente.Cedula = txbced.Text;
                    cliente = new ManejadorCliente().verificarClienteBL(cliente);
                    if (cliente.Cedula.Equals("!"))
                    {
                        txbnombre.Text = "";
                        txbape1.Text = "";
                        txbape2.Text = "";

                        Response.Write("<script>alert('Este cliente ya se encuentra registrado')</script>");
                    }
                   else if (cliente.Cedula.Equals("")) {
                        Response.Write("<script>alert('Cédula no registrada ')</script>");
                    }
                    else
                    {
                        txbnombre.Text = cliente.Nombre;
                        txbape1.Text = cliente.Apellido1;
                        txbape2.Text = cliente.Apellido2;
                    }
                }
                else
                {
                    Response.Write("<script>alert('Debe ingresar una cedula')</script>");
                }
            }
            else {
                //busqueda para la modificacion
                cliente.Cedula = txbced.Text;
                Session["cliente"] = cliente;
                cliente = new ManejadorCliente().verificarClienteBL(cliente);
                if (!cliente.Cedula.Equals(""))
                {
                    txbnombre.Text = cliente.Nombre;
                    txbape1.Text = cliente.Apellido1;
                    txbape2.Text = cliente.Apellido2;
                    
                }
            }
        }

        private void limpiarCampos() {
            txbced.Text = "";
            txbnombre.Text = "";
            txbape1.Text = "";
            txbape2.Text = "";
            txbtelefono.Text = "";
            txbcorreo.Text = "";
            txbobs.Text = "";
            DlDia.SelectedIndex = 0;
            DlMes.SelectedIndex = 0;
            DLAnno.SelectedIndex = 0;


        }

        private void limpiarIngreso() {
            pass1.Text = "";
            pass2.Text = "";
        }

        public Boolean camposVacios() {
            Boolean cond = true;
            if (
                txbced.Text.Equals("") || txbnombre.Text.Equals("")||
                txbape1.Text.Equals("") || txbape2.Text.Equals("") ||
                txbtelefono.Text.Equals("") || txbcorreo.Text.Equals("")||
                //pass1.Text.Equals("") || pass2.Text.Equals("") ||
                DlDia.SelectedIndex == 0 || DlMes.SelectedIndex == 0 ||
                DLAnno.SelectedIndex == 0 || txbobs.Text.Equals("")
                ) {
                cond = false;
            }
            return cond;
        }


        private void crearRegistroCliente() {
            String ced = txbced.Text;
            String nombre = txbnombre.Text;
            String ape1 = txbape1.Text;
            String ape2 = txbape2.Text;
            int tel = int.Parse(txbtelefono.Text);
            DateTime fecha_nac = new DateTime(int.Parse(DLAnno.SelectedValue), int.Parse(DlMes.SelectedValue), int.Parse(DlDia.SelectedItem.Text));
            String correo = txbcorreo.Text;
            String obs = txbobs.Text;
            cliente = new Cliente(ced, nombre, ape1, ape2, fecha_nac, tel, correo, obs);
            Session["cliente"] = cliente;

        }

        protected void habilitarCredenciales_Click(object sender, EventArgs e) {

            if (camposVacios())
            {
                crearRegistroCliente();
                TextBoxCorreo2.Text = txbcorreo.Text;
                desabilitarCampos();
                TextBoxCorreo2.DataBind();

                ingresoDIV.Visible = true;
            }
            else
            {
                Response.Write("<script>alert('Campos incompletos CON CUENTA')</script>");
            }            
        }

        private void desabilitarCampos() {


            lblCed.Visible = false;
            Label1.Visible = false;
            Label10.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;

            txbced.Visible = false;
            txbnombre.Visible = false;
            txbape1.Visible = false;
            txbape2.Visible = false;
            txbtelefono.Visible = false;
            txbcorreo.Visible = false;
            //pass1.Visible = false;
            //pass2.Visible = false;
            txbobs.Visible = false;
            DlDia.Visible = false;
            DlMes.Visible = false;
            DLAnno.Visible = false;

            btnBusqueda.Visible = false;
            //btnModificar.Visible = false;
        }

        private void habilitarCampos()
        {
            lblCed.Visible = true;
            Label1.Visible = true;
            Label10.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            Label7.Visible = true;

            txbced.Visible = true;
            txbnombre.Visible = true;
            txbape1.Visible = true;
            txbape2.Visible = true;
            txbtelefono.Visible = true;
            txbcorreo.Visible = true;
            //pass1.Visible = true;
            //pass2.Visible = true;
            txbobs.Visible = true;
            DlDia.Visible = true;
            DlMes.Visible = true;
            DLAnno.Visible = true;

            btnBusqueda.Visible = true;
            //btnModificar.Visible = true;
        }

        private void cargarInfoUsuario(String id) {

            cliente = new ManejadorCliente().buscarCliente(id);
            txbced.Text = cliente.Cedula;
            txbced.Enabled = false;
            txbnombre.Text = cliente.Nombre;
            txbnombre.Enabled = false;
            txbape1.Text = cliente.Apellido1;
            txbape1.Enabled = false;
            txbape2.Text = cliente.Apellido2;
            txbape2.Enabled = false;
            txbtelefono.Text = cliente.Telefono.ToString();
            txbcorreo.Text = cliente.Correo;
            txbcorreo.Enabled = false;
            txbobs.Text = cliente.Observacion;
            textBoxClave.Text = "xxxxxxxxxx"; //10

            ListItem diaItem0 = new ListItem(cliente.Fecha_Nacimiento.Day.ToString(), "", true);
            ListItem mesItem0 = new ListItem(cliente.Fecha_Nacimiento.Month.ToString(), "", true);
            ListItem anioItem = new ListItem(cliente.Fecha_Nacimiento.Year.ToString(), "", true);
            
            DlDia.Items.Add(diaItem0);
            DlMes.Items.Add(diaItem0);
            DLAnno.Items.Add(anioItem);

            DlDia.Enabled = false;
            DlMes.Enabled = false;
            DLAnno.Enabled = false;
            DlDia.Visible = true;
            DlMes.Visible = true;
            DLAnno.Visible = true;
        }

    }
}