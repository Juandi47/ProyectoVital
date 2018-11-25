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
                    tTelefono.Text = clien.Telefono.ToString();
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
            //valida espacios vacio
            if (tel != "" || contr != "" || contra2 != "") {

                //valida que las contraseñas coincidan
                if (contr.Equals(contra2)) {
                    
                } else {
                    Response.Write("<script>alert('Las contraseñas deben coincidir')</script>");
                }
            } else {
                Response.Write("<script>alert('Se debe completar los espacios')</script>");
            }
        }


    }
}