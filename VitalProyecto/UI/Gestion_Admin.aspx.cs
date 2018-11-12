﻿using System;
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


        ManejadorAdministrador manejo = new ManejadorAdministrador();
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {


            List<Administrador> lista = new List<Administrador>();
            lista = manejo.listaAdministrador();

            Administrador.BackColor = System.Drawing.Color.LightGray;

            foreach (Administrador x in lista)
            {
                crearFila(x.Cedula, x.Nombre, x.Clave, x.Apellido1, x.Apellido2);
            }
            }


        private void crearFila(string cedula, string nombre, string clave, string apellido1, string apellido2)
        {
            TableRow fila = new TableRow(); ;

            TableCell celdaNombre = new TableCell();
            celdaNombre.Text = nombre;
            celdaNombre.Font.Size = 20;
            celdaNombre.Font.Bold = true;
            celdaNombre.BackColor = System.Drawing.Color.Gray;
            celdaNombre.Attributes.Add("onClick", "location.href='InformacionAdministrador.aspx/?Nombre=" + nombre + "'");
            //celdaNombre.Attributes.Add("onmouseover", "style+='background - color:blue;'");
            fila.Cells.Add(celdaNombre);

            TableCell botonCell = new TableCell();
            Button btnModificar = new Button();
            Button btnEliminar = new Button();

            count = count + 1;
            btnModificar.ID = "btnModificar" + count;
            count = count + 1;
            btnEliminar.ID = "btnEliminar" + count;
            btnModificar.Text = " Modificar ";
            btnModificar.ForeColor = System.Drawing.Color.Black;
            btnModificar.BackColor = System.Drawing.Color.LightYellow;
            btnEliminar.Text = " Eliminar ";
            btnEliminar.ForeColor = System.Drawing.Color.Black;
            btnEliminar.BackColor = System.Drawing.Color.LightPink;
            btnModificar.Click += delegate { manejo.modificarAdmin(cedula, nombre, clave, apellido1, apellido2); };
            btnEliminar.Click += delegate { manejo.eliminarAdministrador(cedula); };

            botonCell.Controls.Add(btnEliminar);
            botonCell.Controls.Add(btnModificar);
            fila.Cells.Add(botonCell);

            Administrador.Rows.Add(fila);


        }


    }

    }