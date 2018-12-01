using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class Manejador_Noticia
    {
        DAONoticia daoNoticia = new DAONoticia();
        public Boolean CrearCliente(DateTime Fecha, string encabezado, string texto, string imangen)
        {
            TONoticia notic = new TONoticia(Fecha, encabezado, texto, imangen);
            return daoNoticia.CrearNoticia(notic);
        }

        public List<Noticia> TraerLista()
        {
            List<Noticia> ListaNotic = new List<Noticia>();
            List<TONoticia> lista = daoNoticia.CargarNoticias();
            if (lista != null)
            {
                foreach (TONoticia noti in lista)
                {
                    ListaNotic.Add(new Noticia(noti.Clave, noti.Fecha, noti.Encabezado, noti.Texto, noti.Imagen));
                }
                return ListaNotic;
            }
            else
            {
                return null;
            }
        }
    }
}
