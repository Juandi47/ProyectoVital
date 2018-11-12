﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace UI
{
    public partial class RegistroCliente : System.Web.UI.Page
    {

        private String[] meses;
        private Cliente cliente;


        protected void Page_Load(object sender, EventArgs e)
        {
            meses = new string[] { "MES","Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio",
            "Agosto","Septiembre", "Octubre", "Noviembre", "Diciembre"};
            cargarFechas();
            cliente = new Cliente();

        }

        private void cargarFechas() {

            int anio = 1900;
            int maxAnio =2100;

            ListItem anioItem = new ListItem("AÑO", "" , true);
            DLAnno.Items.Add(anioItem);

            ListItem diaItem0 = new ListItem("DIA", "", true);
            DlDia.Items.Add(diaItem0);

            while (anio <= maxAnio) {
                DLAnno.Items.Add(anio.ToString());
                anio++;
             }

            for (int i = 0; i < 31; i++) {

                if (i < 12)
                {
                    ListItem mesItem = new ListItem(meses[i], (i+1) + "", true);
                    DlMes.Items.Add(mesItem);

                }
                ListItem diaItem = new ListItem((i+1) +"", (i + 1) + "", true);
                DlDia.Items.Add(diaItem);
            }

            DlMes.DataBind();
            DlDia.DataBind();
           
        }

        protected void DlMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mesSeleccionado = int.Parse(DlMes.SelectedItem.Value);

            if (mesSeleccionado == 2) {


                DlDia.Items[31].Enabled = false;
                DlDia.Items[30].Enabled = false;
                DlDia.Items[29].Enabled = false;

            } else if (mesSeleccionado == 4 || mesSeleccionado == 6 || mesSeleccionado == 9 || mesSeleccionado == 11) {

                DlDia.Items[31].Enabled = false;
              
            }
            DlDia.DataBind();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            String ced = txbced.Text;
            String nombre = txbnombre.Text;
            String ape1 = txbape1.Text;
            String ape2 = txbape2.Text;
            int tel = int.Parse(txbtelefono.Text);

            DateTime fecha_nac = new DateTime(int.Parse(DLAnno.SelectedValue), int.Parse(DlMes.SelectedValue), int.Parse(DlDia.SelectedItem.Text));
            String correo = txbcorreo.Text;
            String obs = txbobs.Text;

            cliente = new Cliente(ced,nombre,ape1,ape2,fecha_nac,tel,correo,obs);
            Boolean cliente_creado = new ManejadorCliente().registrarClienteBL(cliente);

            if(cliente_creado)
                Response.Write("<script>alert('Cliente creado correctamente')</script>");
            else
                Response.Write("<script>alert('Error en registro de cliente')</script>");
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            if (!txbced.Text.Equals(""))
            {
                cliente.Cedula = txbced.Text;
                cliente = new ManejadorCliente().verificarClienteBL(cliente);
                if (cliente.Cedula.Equals("!"))
                {
                    txbnombre.Text = "";
                    txbape1.Text = "";
                    txbape2.Text = "";

                    Response.Write("<script>alert('Este cliente ya se encuentra registrado')</script>");
                }
                else
                {
                    txbnombre.Text = cliente.Nombre;
                    txbape1.Text = cliente.Apellido1;
                    txbape2.Text = cliente.Apellido2;
                }
            }
            else
            {
                Response.Write("<script>alert('Debe ingresar una cedula')</script>");
            }
        }
    }
}