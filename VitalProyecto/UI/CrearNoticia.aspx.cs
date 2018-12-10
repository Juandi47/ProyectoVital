﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class CrearNoticia : System.Web.UI.Page
    {
        private static Manejador_Noticia manejador = new Manejador_Noticia();
        private static List<Noticia> ListaNoticia = new List<Noticia>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarLista();
                TablaEliminar.Text = "<tr><th>Encabezado</th><th>Texto</th><th>Fecha</th><th>Eliminar</th></tr>";
                LlenarTabla();
            }
        }

        private void CargarLista()
        {
            ListaNoticia = manejador.TraerLista();
        }

       // 1. noticia Principal
       // 2. noticias Importante
       // 3. noticias Info reciente
       // 4. notas
        protected void BtnReciente_Click(object sender, EventArgs e)
        {
            if (EncabReciente.Text.Equals("") || TextoReciente.Text.Equals(""))
            {
                ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "errorVacio();", true);
            }
            else
            {
                if (manejador.CrearNoti(DateTime.Now, EncabReciente.Text, TextoReciente.Text, "/images/vital.jpg", 3))
                {
                    ListaNoticia.Add(new Noticia(ListaNoticia.Count + 1, DateTime.Now, EncabReciente.Text, TextoReciente.Text, "/images/vital.jpg", 3));
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "error();", true);
                }
            }
            EncabReciente.Text = string.Empty; TextoReciente.Text = string.Empty;
        }

        protected void BtnImportante_Click(object sender, EventArgs e)
        {
            if (EncabImportante.Text.Equals("") || TextoImportante.Text.Equals(""))
            {
                ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "errorVacio();", true);
            }
            else
            {
                if(manejador.CrearNoti(DateTime.Now, EncabImportante.Text, TextoImportante.Text, "/images/importante.jpg", 2))
                {
                    ListaNoticia.Add(new Noticia(ListaNoticia.Count + 1, DateTime.Now, EncabImportante.Text, TextoImportante.Text, "/images/vital.jpg", 2));
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "error();", true);
                }
            }
            EncabImportante.Text = string.Empty; TextoImportante.Text = string.Empty;
        }

        protected void BtnPrincipal_Click(object sender, EventArgs e)
        {
            if (EncabPrincipal.Text.Equals("") || TextoPrincipal.Text.Equals(""))
            {
                ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "errorVacio();", true);
            }
            else
            {
                if (manejador.CrearNoti(DateTime.Now, EncabPrincipal.Text, TextoPrincipal.Text, "/images/plan.jpg", 1))
                {
                    ListaNoticia.Add(new Noticia(ListaNoticia.Count + 1, DateTime.Now, EncabPrincipal.Text, TextoPrincipal.Text, "/images/vital.jpg", 1));
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "error();", true);
                }
            }
            EncabPrincipal.Text = string.Empty; TextoPrincipal.Text = string.Empty;
        }

        protected void BtnNotas_Click(object sender, EventArgs e)
        {
            if (EncabNotas.Text.Equals("") || TextoNotas.Text.Equals(""))
            {
                ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "errorVacio();", true);
            }
            else
            {
                if (manejador.CrearNoti(DateTime.Now, EncabNotas.Text, TextoNotas.Text, "", 4))
                {
                    ListaNoticia.Add(new Noticia(ListaNoticia.Count + 1,DateTime.Now, EncabNotas.Text, TextoNotas.Text, "/images/vital.jpg", 4));
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "error();", true);
                }
            }
            EncabNotas.Text = string.Empty; TextoNotas.Text = string.Empty;
        }
        //

        protected void LlenarTabla()
        {
            foreach(Noticia noti in ListaNoticia)
            {
                TablaEliminar.Text += "<tr><td>" + noti.Encabezado + "</td><td>" + noti.Texto + "</td><td>" + noti.Fecha + "</td><td>"+
                   "<Button id=\"BtnEliminar\" class=\"glyphicon glyphicon-trash\" onclick=\"Eliminar_Click(" + noti.Clave+")\" style= \"color:#990000\"></Button></td></tr>";
            }
        }

        [System.Web.Services.WebMethod]
        protected static void EliminarNoticia(string clave)
        {
            int cont = 0;
            manejador.EliminarNoticia(Convert.ToInt32(clave));
            foreach (Noticia noti in ListaNoticia)
            {
                if(noti.Clave == Convert.ToInt32(clave))
                {
                    ListaNoticia.RemoveAt(cont);
                }
                else
                {
                    cont = cont + 1;
                }
            }
        }
        
    }
}