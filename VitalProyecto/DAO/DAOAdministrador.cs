﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAOAdministrador
    {

        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

        public List<TOAdministrador> ListaAdministrador()
        {
            List<TOAdministrador> listAdministrador = new List<TOAdministrador>();
            string qry = "select Usuario.*, Login.Clave from Usuario, Login where Login.Rol = 'admin' and Usuario.Correo = Login.Nombre_usuario;";
            SqlCommand sent = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

            lector = sent.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    listAdministrador.Add(new TOAdministrador(lector["Cedula"].ToString(), lector["Nombre"].ToString(),
                        lector["Clave"].ToString(), lector["Apellido1"].ToString(), lector["Apellido2"].ToString(),
                        lector["Correo"].ToString()));

                }
                conexion.Close();
            }
            else
            {
                conexion.Close();
            }

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
            return listAdministrador;
        }



        public string agregarAdmin(TOAdministrador administrador)
        {
            try
            {
                string mensaje = "";
                string qry = "insert into Usuario values (@ced, @cor, @nom, @ape1, @ape2)";
                string qry2 = "insert into Login values( @cor, @cla, 'admin')";

                SqlCommand sent = new SqlCommand(qry, conexion);
                SqlCommand sent2 = new SqlCommand(qry2, conexion);
                sent.Parameters.AddWithValue("@ced", administrador.Cedula);
                sent.Parameters.AddWithValue("@cor", administrador.Correo);
                sent.Parameters.AddWithValue("@nom", administrador.Nombre);
                sent.Parameters.AddWithValue("@cla", administrador.Clave);
                sent.Parameters.AddWithValue("@ape1", administrador.Apellido1);
                sent.Parameters.AddWithValue("@ape2", administrador.Apellido2);
                sent2.Parameters.AddWithValue("@cor", administrador.Correo);
                sent2.Parameters.AddWithValue("@cla", administrador.Clave);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                int numero = sent.ExecuteNonQuery();
                int numero2 = (int)sent2.ExecuteNonQuery();

                if (numero == 1 && numero2 == 1)
                {
                    mensaje = "ADMINISTRADOR REGISTRADO";
                }
                else {
                    mensaje = "LA CEDULA YA SE ENCONTRABA REGISTRADA";
                }
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "LA CEDULA YA SE ENCONTRABA REGISTRADA";
            }

        }


        public int eliminarAdmin(string cedula, string correo)
        {
            int eliminado = -1;
            try
            {
                int con = ListaAdministrador().Count();
                if (ListaAdministrador().Count() > 1)
                {
                    string qry = "delete from Usuario where Cedula = @ced";
                    string qry2 = "delete from Login where Nombre_usuario = @cor;";

                    SqlCommand sent = new SqlCommand(qry, conexion);
                    SqlCommand sent2 = new SqlCommand(qry2, conexion);
                    sent.Parameters.AddWithValue("@ced", cedula);
                    sent2.Parameters.AddWithValue("@cor", correo);
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }
                    sent.ExecuteNonQuery();
                    sent2.ExecuteNonQuery();
                    eliminado = 2;
                }
                else {
                    //NonSerializedAttribute deberia quedar sin al menos un administrador
                    eliminado = 1;
                }

            }
            catch (Exception e)
            {

            }
            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            return eliminado;

        }



        public string modificarAdmin(TOAdministrador administrador)
        {
            string mensaje = "";
            try
            {

                string qry = "UPDATE Administrador SET Nombre = @nom, Clave = @cla, Apellido1 = @ape1, Apellido2 = @ape2, Correo = @cor  where Cedula = @ced;";

                SqlCommand sent = new SqlCommand(qry, conexion);
                sent.Parameters.AddWithValue("@ced", administrador.Cedula);
                sent.Parameters.AddWithValue("@cla", administrador.Clave);
                sent.Parameters.AddWithValue("@nom", administrador.Nombre);
                sent.Parameters.AddWithValue("@ape1", administrador.Apellido1);
                sent.Parameters.AddWithValue("@ape2", administrador.Apellido2);
                sent.Parameters.AddWithValue("@cor", administrador.Correo);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                int modificadas = sent.ExecuteNonQuery();
                if (modificadas == 1)
                {
                    mensaje = "Se ha modificado los datos del administrador";
                }
            }
            catch (Exception e)
            {

            }
            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
            return mensaje;
        }

        public TOAdministrador consultaAdmin(string cedula)
        {

            TOAdministrador administrador = new TOAdministrador();

            try
            {

                string qry = "select Usuario.*, Login.Clave from Usuario, Login where Login.Rol = 'admin' and Usuario.Correo = Login.Nombre_usuario and Usuario.Cedula = @ced;";
                SqlCommand sent = new SqlCommand(qry, conexion);
                SqlDataReader lector;
                sent.Parameters.AddWithValue("@ced", cedula);
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                lector = sent.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        administrador = new TOAdministrador(lector["Cedula"].ToString(), lector["Nombre"].ToString(),
                            lector["Clave"].ToString(), lector["Apellido1"].ToString(), lector["Apellido2"].ToString(),
                            lector["Correo"].ToString());
                    }

                    conexion.Close();
                }
                else
                {
                    conexion.Close();
                }

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }

            }
            catch (Exception e)
            {

            }
            return administrador;
        }


        public Boolean existeAdmin(string cedula)
        {
            Boolean mensaje = false;
            int admin = 0;

            string qry = "SELECT COUNT (*) as numero FROM Usuario WHERE cedula = @ced;";
            SqlCommand sent = new SqlCommand(qry, conexion);
            sent.Parameters.AddWithValue("@ced", cedula);

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
                admin = sent.ExecuteNonQuery();

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            if (admin > 0)
            {
                mensaje = true;
            }
            else {
                mensaje = false;
            }
            return mensaje;
        }
        

    }

}