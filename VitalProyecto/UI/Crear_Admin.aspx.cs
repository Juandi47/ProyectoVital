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
        }


        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {

            string mensaje = "";
            string cedula = tced.Text;
            string nombre = tname.Text;
            string clave = tclave.Text;
            string clave2 = tclave2.Text;
            string apellido1 = tlname1.Text;
            string apellido2 = tlname2.Text;
            string correo = temail.Text;

            //se debe verificar que no hayan espacios incompleto 
            if (cedula.Equals("") || nombre.Equals("") || clave.Equals("") || apellido1.Equals("") || apellido1.Equals(""))
            {
                Response.Write("<script>alert('No deben haber espacios en blanco')</script>");
            }
            else {
                //Se debe asegurar que las claves coincidan.
                if (clave2.Equals(clave))
                {
                    if (cedula.Contains("-"))
                    {
                        Response.Write("<script>alert('Formato de cedula inválida')</script>");
                    }
                    else {
                        //se debe verificar que la contraseña no haya sido ingresada anteriormente
                        if (manejadorAdmin.existeAdmin(cedula) == false)
                        {
                            if (manejadorAdmin.existeCorreo(correo))
                            {
                                Response.Write("<script>alert('El correo electrónico ha sido registrado')</script>");
                            }
                            else {
                                mensaje = manejadorAdmin.agregarAdministrador(cedula, nombre, clave, apellido1, apellido2, correo);
                                Response.Write("<script>alert('Usuario registrado correctamente')</script>");
                            }
                        }
                        else {
                            Response.Write("<script>alert('Ya existe la cedula registrada en el sistema')</script>");
                        }
                    }
                }
                else {
                    Response.Write("<script>alert('Las claves deben coincidir')</script>");
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