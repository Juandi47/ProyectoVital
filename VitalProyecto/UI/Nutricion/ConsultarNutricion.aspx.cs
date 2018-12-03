﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI.Nutricion
{
    public partial class ConsultarNutricion : System.Web.UI.Page
    {
        private static ManejadorNutrición manejador = new ManejadorNutrición();
        private static List<ClienteNutricion> lista = new List<ClienteNutricion>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarLista();
            }
            

        }

        private void CargarLista()
        {
            lista = manejador.ListaClientes();
            if (lista != null)
            {
                foreach (ClienteNutricion c in lista)
                {
                    LitConsultar.Text += "<tr><td>" + c.Nombre + " " + c.Apellido1 + " " + c.Apellido2 + "</td>" +
                        "<td><a \"href=\"#\" onclick=\"Ver_Click(" + c.Cedula + ")\" id=\"btnVer\">Ver</a></td>"+
                         "<td><a \"href=\"#\" onclick=\"Eliminar_Click(" + c.Cedula + ")\" id=\"btnVer\">Eliminar</a></td></tr>";
                }

            }

        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteNutricion cl = lista.Find(x => x.Cedula.Equals(sCedula.Text));
            if(cl != null)
            {
                LitConsultar.Text = "<tr><td>" + cl.Nombre + " " + cl.Apellido1 + " " + cl.Apellido2 + "</td>" +
                        "<td><a \"href=\"#\" onclick=\"Ver_Click(" + cl.Cedula + ")\" id=\"btnVer\">Ver</a></td>" +
                         "<td><a \"href=\"#\" onclick=\"Eliminar_Click(" + cl.Cedula + ")\" id=\"btnVer\">Eliminar</a></td></tr>";
            }
        }

        [System.Web.Services.WebMethod]
        public static string VerDetalleCliente(string ced)
        {
            ClienteNutricion cl = lista.Find(x => x.Cedula.Equals(ced));
            return "Cedula: " + cl.Cedula + "Nombre: " + cl.Nombre + " " + cl.Apellido1 + " " + cl.Apellido2 + ".<br/>" +
                "Fecha de Nacimiento: " + cl.Fecha_Nacimiento + "<br/>Edad: " + CalcularCumple(cl.Fecha_Nacimiento) +
                "<br />Telefono: " + cl.Telefono + "<br />Sexo: " + cl.Sexo + "<br/>Estado Civil: " + cl.Estado_Civil +
                "<br />Residencia: " + cl.Residencia + "<br/>Ocupacion: " + cl.Ocupacion + "<br/>Fecha de Ingreso: " + cl.FechaIngreso;
        }
        
       
        protected static int CalcularCumple(DateTime fechaNac)
        {
            if (fechaNac.Equals(""))
            {
                return 0;
            }
            else
            {
               
                int años = DateTime.Now.Year - fechaNac.Year;
                if (fechaNac.Month > DateTime.Now.Month)
                {
                    return años - 1;
                }
                else
                {
                    if (fechaNac.Month == DateTime.Now.Month)
                    {
                        if (fechaNac.Day < DateTime.Now.Day)
                        {
                            return años - 1;
                        }
                        else
                        {
                            return años;
                        }
                    }
                    else
                    {
                       return años;
                    }
                }
            }
        }

        [System.Web.Services.WebMethod]
        public static void EliminarCliente(string ced)
        {
            manejador.EliminarExpediente(ced);
        }
        
    }
}