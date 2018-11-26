using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class ModificarCuentaUsuario : System.Web.UI.Page
    {

        ManejadorCliente maneja = new ManejadorCliente();

        protected void Page_Load(object sender, EventArgs e)
        {

			if (new ControlSeguridad().validarCliente() == true)
			{
				Response.Redirect("~/IniciarSesion.aspx");
			}
            BL.Usuario usuarioSesion = Session["usuarioSesion"] as Usuario;

            tcedula.Text = usuarioSesion.cedula;
            tnombre.Text = usuarioSesion.nombre;
            tcorreo.Text = usuarioSesion.correo;
            informacionCliente();

        }


        public void informacionCliente()
        {
            Usuario usuarioSesion = Session["usuarioSesion"] as Usuario;
            Cliente clien = new ManejadorCliente().buscarCliente(usuarioSesion.cedula);

            try
            {

                if (clien != null)
                {
                    tfehcaN.Text = clien.Fecha_Nacimiento.ToString();
                }
                else
                {

                }
            }
            catch (Exception)
            {

            }


        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string tel = tTelefono.Text;
            string contr = tclave.Text;
            string contra2 = tclave2.Text;
            string cedula = tcedula.Text;
            string correo = tcorreo.Text;
            Usuario usuarioSesion = Session["usuarioSesion"] as Usuario;
            Cliente clien = new ManejadorCliente().buscarCliente(usuarioSesion.cedula);
            string observaciones = clien.Observacion;
            string telefono = tTelefono.Text;

            //valida espacios vacio
            if (tel != "" || contr != "" || contra2 != "") {

                //valida que las contraseñas coincidan
                if (contr.Equals(contra2)) {
                    maneja.modificarCliente(cedula, correo, observaciones, Int32.Parse(telefono), contr);
                    Response.Write("<script>alert('Su perfil ha sido modificado')</script>");
                } else {
                    ValidadorClaves.Visible = true;
                    //Response.Write("<script>alert('Las contraseñas deben coincidir')</script>");
                }
            } else {
                Response.Write("<script>alert('Se debe completar los espacios')</script>");
            }
        }

        private void limpiarControles()
        {
            tcedula.Text = string.Empty;
            tnombre.Text = string.Empty;
            tTelefono.Text = string.Empty;
            tcorreo.Text = string.Empty;
            tfehcaN.Text = string.Empty;
            tclave.Text = string.Empty;
            tclave2.Text = string.Empty;
        }




    }
}