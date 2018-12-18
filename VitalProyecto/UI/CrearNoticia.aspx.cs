using System;
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
            //if (new ControlSeguridad().validarAdmin() == true)
            //{
            //	Response.Redirect("~/IniciarSesion.aspx");
            //}

            if (!IsPostBack)
            {
                CargarLista();
                TablaEliminar.Text = "<tr><th>Encabezado</th><th>Texto</th><th>Fecha</th><th>Eliminar</th></tr>";
            }
            LlenarTabla();
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
                if (manejador.CrearNoti(DateTime.Now, EncabReciente.Text, TextoReciente.Text, cargarImagen(), 3))
                {
                    ListaNoticia.Add(new Noticia(ListaNoticia.Count + 1, DateTime.Now, EncabReciente.Text, TextoReciente.Text, cargarImagen(), 3));
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
                if(manejador.CrearNoti(DateTime.Now, EncabImportante.Text, TextoImportante.Text, cargarImagen(), 2))
                {
                    ListaNoticia.Add(new Noticia(ListaNoticia.Count + 1, DateTime.Now, EncabImportante.Text, TextoImportante.Text, cargarImagen(), 2));
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
                if (manejador.CrearNoti(DateTime.Now, EncabPrincipal.Text, TextoPrincipal.Text, cargarImagen(), 1))
                {
                    ListaNoticia.Add(new Noticia(ListaNoticia.Count + 1, DateTime.Now, EncabPrincipal.Text, TextoPrincipal.Text, cargarImagen(), 1));
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
                if (manejador.CrearNoti(DateTime.Now, EncabNotas.Text, TextoNotas.Text, cargarImagen(), 4))
                {
                    ListaNoticia.Add(new Noticia(ListaNoticia.Count + 1,DateTime.Now, EncabNotas.Text, TextoNotas.Text, cargarImagen(), 4));
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "mensaje();", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "invocarfuncion", "error();", true);
                }
            }
            EncabNotas.Text = string.Empty; TextoNotas.Text = string.Empty;
        }
        

        protected void LlenarTabla()
        {
            foreach(Noticia noti in ListaNoticia)
            {
                TablaEliminar.Text += "<tr><td>" + noti.Encabezado + "</td><td>" + noti.Texto + "</td><td>" + noti.Fecha + "</td><td>"+
                   "<a \"href=\"#\" onclick=\"Eliminar_Click(" + noti.Clave + ")\" id=\"btnEliminar\">Eliminar</a></td></tr>";
            }
        }

        [System.Web.Services.WebMethod]
        public static void EliminarNoticia(string clave)
        {
            manejador.EliminarNoticia(Convert.ToInt32(clave));
            for(int i =0; i<ListaNoticia.Count-1; i++)
            {
                if(ListaNoticia[i].Clave== Convert.ToInt32(clave))
                {
                    ListaNoticia.RemoveAt(i);
                    break;
                }

            }
            
        }

		private string cargarImagen()
		{
			Boolean correcto = false;
			String ruta = Server.MapPath("~/images/");
			string stringRuta = "";

			if (imagen.HasFile)
			{
				String extension = System.IO.Path.GetExtension(imagen.FileName).ToLower();
				String[] allowedExtensions = { ".png", ".jpeg", ".jpg" };
				for (int i = 0; i < allowedExtensions.Length; i++)
				{
					if (extension == allowedExtensions[i])
					{
						correcto = true;
					}
				}
			}

			if (correcto)
			{
				try
				{
					imagen.PostedFile.SaveAs(ruta + imagen.FileName);
					stringRuta = "/images/" + imagen.FileName;

					//stringRuta = ruta + imagen.FileName;
					//Response.Write("<script>alert('Imagen cargada.')</script>");
					return stringRuta;
				}
				catch
				{
					//Response.Write("<script>alert('No se pudo cargar la imagen.')</script>");
				}
			}
			else
			{
				//Response.Write("<script>alert('Archivo no aceptado.')</script>");
				return null;
			}
			return null;
		}

	}
}