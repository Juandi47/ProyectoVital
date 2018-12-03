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
            if(ListaNoticias != null)
            {
                if (ListaNoticias.Count >= 2)
                {
                    int cont = 0;
                    foreach(Noticia noti in ListaNoticias)
                    {
                        if(cont < 2)
                        {
                            Blogs.Text += "<div class=\"w3-card-4 w3-margin w3-white\"><img src = \"" + noti.Imagen + "\" alt=\"Nature\" style=\"width: 100%\"/>" +
                                "<div class=\"w3-container\"><h3><b>" + noti.Encabezado + "</b></h3>" +
                                "<h5>Fecha: <span class=\"w3-opacity\">" + noti.Fecha + "</span></h5></div>" +
                                "<div class=\"w3-container\"><p>" + noti.Texto + "</p>" +
                                "<div class=\"w3-row\"><div class=\"w3-col m8 s12\"><p>" +
                                "<button class=\"w3-button w3-padding-large w3-white w3-border\"><b>Leer más »</b></button></p>" +
                                "</div></div></div></div><hr />";
                            cont = cont +1;
                        }
                        else
                        {
                            MiniNoticia.Text +="<div class=\"w3-card w3-margin w3-margin-top\">" +
                                "<img src = \"" + noti.Imagen +"\" style=\"width: 100%\" /><div class=\"w3-container w3-white\">" +
                                "<h4><b>" + noti.Encabezado + "</b></h4><p>" + noti.Texto + "</p></div></div><hr />";
                        }
                    }
                }
                else
                {
                    Blogs.Text = "<div class=\"w3-card-4 w3-margin w3-white\"><img src = \"" + ListaNoticias[0].Imagen + "\" alt=\"Nature\" style=\"width: 100%\"/>" +
                        "<div class=\"w3-container\"><h3><b>" + ListaNoticias[0].Encabezado + "</b></h3>" +
                        "<h5>Fecha: <span class=\"w3-opacity\">" + ListaNoticias[0].Fecha + "</span></h5></div>" +
                        "<div class=\"w3-container\"><p>" + ListaNoticias[0].Texto + "</p>" +
                        "<div class=\"w3-row\"><div class=\"w3-col m8 s12\"><p>" +
                        "<button class=\"w3-button w3-padding-large w3-white w3-border\"><b>Leer más »</b></button></p>" +
                        "</div></div></div></div><hr />";
                }
            }
            


        }
	}
}