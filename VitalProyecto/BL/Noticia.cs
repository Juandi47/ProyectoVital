using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Noticia
    {
        public int Clave { set; get; }
        public DateTime Fecha { set; get; }
        public string Encabezado { set; get; }
        public string Texto { set; get; }
        public string Imagen { set; get; }
        public int TipoNoticia { set; get; }

        public Noticia(int clave, DateTime fecha, string encabezado, string texto, string imagen, int tipoNoticia)
        {
            Clave = clave;
            Fecha = fecha;
            Encabezado = encabezado;
            Texto = texto;
            Imagen = imagen;
            TipoNoticia = tipoNoticia;
        }

        public Noticia(DateTime fecha, string encabezado, string texto, string imagen, int tipoNoticia)
        {
            Fecha = fecha;
            Encabezado = encabezado;
            Texto = texto;
            Imagen = imagen;
            TipoNoticia = tipoNoticia;
        }
    }
}
