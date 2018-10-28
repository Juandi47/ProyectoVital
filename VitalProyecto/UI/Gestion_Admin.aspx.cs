using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class Gestion_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

       ManejadorAdministrador manenadorAdmin = new ManejadorAdministrador();

            List<Administrador> listaAdmin = new List<Administrador>();
            listaAdmin = manenadorAdmin.listaAdministrador();
            TableRow fila;
            TableCell celda;
            foreach (Administrador x in listaAdmin)
            {
                fila = new TableRow();
                celda = new TableCell();
                celda.Text = x.Nombre;
                fila.Cells.Add(celda);
                Administradores.Rows.Add(fila);
            }

        }

    }
}