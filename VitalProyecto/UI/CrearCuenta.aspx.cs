using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
	public partial class CrearCuenta : System.Web.UI.Page
	{

        ManejadorAdministrador manejadorAdmin = new ManejadorAdministrador();
        ManejadorUsuario manejador = new ManejadorUsuario();
        ManejadorCliente manejaCliente = new ManejadorCliente();
        ManejadorIngreso manejaIngreso = new ManejadorIngreso();

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnCrearCuenta_Click(object sender, EventArgs e)
		{
            string correo = txtCorreo.Text.Trim();
            string contra1 = txtContra.Text.Trim();
            string contra2 = txtRepetir.Text.Trim();

            //verifica espacios vacio
            if (correo != null && !correo.Equals("") && contra1 != null && !contra1.Equals("") && contra2 != null && !contra2.Equals(""))
            {
                //se verifica que las contraseñas coincidan
                if (contra1.Equals(contra2))
                {
                    //se verifica que el correo no se encuentre ya logueado
                    if (!manejadorAdmin.existeCorreo(correo))
                    {
                        // se verifica que el usuario efectivamente este registrado en el sistema
                        if (manejaCliente.existeCliente(correo))
                        {
                            manejaIngreso.registrarLogin(new Ingreso(correo, contra1, "cliente"));
                            Response.Write("<script>alert('Se ha registrado su cuenta satisfactoriamente')</script>");//necesito mostrar este mensaje
                            Response.Redirect("IniciarSesion.aspx");
                        }
                        else {

                        }
                    }
                    else {
                        Response.Write("<script>alert('Este correo es invalido, por favor ingrese un nuevo correo')</script>");
                    }
                }
                else {
                    Response.Write("<script>alert('Las contraseñas deben coincidir')</script>");
                }
            }
            else {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
		}
	}
}