using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class PagInicio : System.Web.UI.Page
    {
        private static List<Noticia> ListaNoticias = new List<Noticia>();
        private static Manejador_Noticia manejador = new Manejador_Noticia();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarBlog();
            }
        }

        private void CargarBlog()
        {
            ListaNoticias = manejador.TraerLista();
            if (ListaNoticias != null)
            {
                foreach (Noticia noti in ListaNoticias)
                {
                    if (noti.TipoNoticia == 1) // Noticias Principal
                    {
                        Blogs.Text += "<div class=\"w3-card-4 w3-margin w3-white\"><img src = \"" + noti.Imagen + "\" alt=\"Nature\" style=\"width: 100%\"/>" +
                            "<div class=\"w3-container\"><h3><b>" + noti.Encabezado + "</b></h3>" +
                            "<h5>Fecha: <span class=\"w3-opacity\">" + noti.Fecha + "</span></h5></div>" +
                            "<div class=\"w3-container\"><p>" + noti.Texto + "</p>" +
                            "</div></div><hr />";
                    }
                    else
                    {
                        if (noti.TipoNoticia == 2) //Noticias Importantes
                        {
                            MiniNoticia.Text += "<div class=\"w3-card w3-margin w3-margin-top\">" +
                                "<img src = \"" + noti.Imagen + "\" style=\"width: 100%\" /><div class=\"w3-container w3-white\">" +
                                "<h4><b>" + noti.Encabezado + "</b></h4><p>" + noti.Texto + "</p></div></div><hr />";

                        }
                        else
                        {
                            if(noti.TipoNoticia == 3)//Noticias informacion Reciente
                            {
                                NotReciente.Text +=  "<li class=\"w3-padding-16\"><img src = \"" + noti.Imagen + "\" alt=\"Foto\" class=\"w3-left w3-margin-right\" style=\"width: 50px\" />" +
                                    "<span class=\"w3-large\">" + noti.Encabezado + "</span><br /><span>" + noti.Texto + "</span></li>";
                            }
                            else
                            {
                                //Notas.
                                Notas.Text +=  "<div class=\"w3-container w3-padding\"><h4>" + noti.Encabezado + "</h4></div>" +
                                                 "<div class=\"w3-container w3-white\"><p>" + noti.Texto + "</p></div>";
                   
                            }
                        }
                    }
                }

            }

        }
    }
}