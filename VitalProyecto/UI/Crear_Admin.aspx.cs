using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class Crear_Admin : System.Web.UI.Page
    {
        ManejadorAdministrador manejadorAdmin = new ManejadorAdministrador();

        protected void Page_Load(object sender, EventArgs e)
        {
			//if (new ControlSeguridad().validarAdmin() == true)
			//{
			//	Response.Redirect("~/IniciarSesion.aspx");
			//}
		}


        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {

            string mensaje = "";
            string cedula = tced.Text.Trim();
            string nombre = tname.Text.Trim();
            string clave = tclave.Text.Trim();
            string clave2 = tclave2.Text.Trim();
            string apellido1 = tlname1.Text.Trim();
            string apellido2 = tlname2.Text.Trim();
            string correo = temail.Text.Trim();

            //se debe verificar que no hayan espacios incompleto 
            if (cedula.Equals("") || nombre.Equals("") || clave.Equals("") || apellido1.Equals("") || apellido1.Equals(""))
            {
				ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "error();", true);

				//Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else {
                //Se debe asegurar que las claves coincidan.
                if (clave2.Equals(clave))
                {
                    //Se debe validar que los numeros nosean negativos
                    if (cedula.Contains("-"))
                    {
                        ValidadorCedulaFormato.Visible = true;
                        //Response.Write("<script>alert('Formato de cedula inválida')</script>");
                    }
                    else {
                        //se debe verificar que la cedula  no haya sido ingresada anteriormente
                        if (manejadorAdmin.existeAdmin(cedula) == false)
                        {
                            //se debe verificar que la correo  no haya sido ingresada anteriormente
                            if (manejadorAdmin.existeCorreo(correo))
                            {
                                ValidadorExistenciaCorreo.Visible = true;
                                //Response.Write("<script>alert('El correo electrónico ya ha sido registrado anteriormente')</script>");
                            }
                            else {
                                mensaje = manejadorAdmin.agregarAdministrador(cedula, nombre, clave, apellido1, apellido2, correo);
								ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);

								//Response.Write("<script>alert('Usuario registrado correctamente')</script>");
                            }
                        }
                        else {
                            ValidadorCedulaExistente.Visible = true;
                            //Response.Write("<script>alert('Ya existe la cedula registrada en el sistema')</script>");
                        }
                    }
                }
                else {
                    ValidadorClaves.Visible = true;
                    //Response.Write("<script>alert('Las claves deben coincidir')</script>");
                }

            }
            limpiarControles();
        }

        private void limpiarControles() {
            tced.Text = string.Empty;
            tname.Text = string.Empty;
            tclave.Text = string.Empty;
            tclave2.Text = string.Empty;
            tlname1.Text = string.Empty;
            tlname2.Text = string.Empty;
            temail.Text = string.Empty;
        }
        
    }
}