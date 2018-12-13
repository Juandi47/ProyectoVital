using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DAO
{
    public class DAOClienteNutricion
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

        public bool CrearUsuario(TOClienteNutricion tOCliente)
        {
            String query1 = "Insert into Usuario values(@ced,@cor,@nomb,@ape1,@ape2,@rol);";
            String query2 = "Insert into Cliente_Nutricion values(@fechNac,@sexo,@estCiv,@tel,@resid,@ocup,@ced,@ingres);";

            SqlCommand cmd = new SqlCommand(query1, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);

            try
            {
                //Cliente padre
                //ced, fecha, tel, obs, mens

                cmd.Parameters.AddWithValue("@ced", tOCliente.Cedula);
                cmd.Parameters.AddWithValue("@cor", "Sin Correo");
                cmd.Parameters.AddWithValue("@nomb", tOCliente.Nombre);
                cmd.Parameters.AddWithValue("@ape1", tOCliente.Apellido1);
                cmd.Parameters.AddWithValue("@ape2", tOCliente.Apellido2);
                cmd.Parameters.AddWithValue("@rol", "clienteNutri");


                cmd2.Parameters.AddWithValue("@fechNac", tOCliente.Fecha_Nacimiento);
                cmd2.Parameters.AddWithValue("@sexo", tOCliente.Sexo);
                cmd2.Parameters.AddWithValue("@estCiv", tOCliente.Estado_Civil);
                cmd2.Parameters.AddWithValue("@tel", tOCliente.Telefono);
                cmd2.Parameters.AddWithValue("@resid", tOCliente.Residencia);
                cmd2.Parameters.AddWithValue("@ocup", tOCliente.Ocupacion);
                cmd2.Parameters.AddWithValue("@ced", tOCliente.Cedula);
                cmd2.Parameters.AddWithValue("@ingres", DateTime.Now);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                //inserta padre
                cmd.ExecuteNonQuery();
                //inserta hijo
                cmd2.ExecuteNonQuery();

                conexion.Close();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public List<TOClienteNutricion> ListarCliente()
        {
            List<TOClienteNutricion> ListaMedidas = new List<TOClienteNutricion>();
            string qry = "Select * from Cliente_Nutricion c,Usuario u where c.Cedula = u.Cedula order by Apellido1";
            SqlCommand buscar = new SqlCommand(qry, conexion);
            SqlDataReader lector;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            lector = buscar.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ListaMedidas.Add(new TOClienteNutricion(lector["Cedula"].ToString(), lector["Nombre"].ToString(), lector["Apellido1"].ToString(),
                        lector["Apellido2"].ToString(), DateTime.Parse(lector["Fecha_Nacimiento"].ToString()), lector["Sexo"].ToString(),
                        lector["Estado_Civil"].ToString(), Int32.Parse(lector["Telefono"].ToString()), lector["Residencia"].ToString(), lector["Ocupacion"].ToString(), DateTime.Parse(lector["FechaIngreso"].ToString())));

                }
                conexion.Close();
                return ListaMedidas;
            }
            else
            {
                conexion.Close();
                return null;
            }
        }
        public bool GuardarHabitos(TOHabitoAlimentario HabitosAlimentario, List<TORecordatorio24H> listaR)
        {
            String query1 = "Insert into HabitosAlimentario values(@ced,@comDi,@ComHD,@express,@comFue,@azuc,@comElab,@agua,@ader,@frut,@verd,@lech,@huev,@yogurt,@carn,@ques,@aguacat,@semil);";
            String query2 = "Insert into Recordat24H values(@ced,@tiempC,@comid,@cant,@descrip);";
            SqlCommand cmd = new SqlCommand(query1, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);
            try
            {
                cmd.Parameters.AddWithValue("@ced", HabitosAlimentario.Cedula);
                cmd.Parameters.AddWithValue("@comDi", HabitosAlimentario.ComidaDiaria);
                cmd.Parameters.AddWithValue("@ComHD", HabitosAlimentario.ComidaHorasDia);
                cmd.Parameters.AddWithValue("@express", HabitosAlimentario.AfueraExpress);
                cmd.Parameters.AddWithValue("@comFue", HabitosAlimentario.ComidaFuera);
                cmd.Parameters.AddWithValue("@azuc", HabitosAlimentario.AzucarBebida);
                cmd.Parameters.AddWithValue("@comElab", HabitosAlimentario.ComidaElaboradCon);
                cmd.Parameters.AddWithValue("@agua", HabitosAlimentario.AguaDiaria);
                cmd.Parameters.AddWithValue("@ader", HabitosAlimentario.Aderezos);
                cmd.Parameters.AddWithValue("@frut", HabitosAlimentario.Fruta);
                cmd.Parameters.AddWithValue("@verd", HabitosAlimentario.Verdura);
                cmd.Parameters.AddWithValue("@lech", HabitosAlimentario.Leche);
                cmd.Parameters.AddWithValue("@yogurt", HabitosAlimentario.Yogurt);
                cmd.Parameters.AddWithValue("@carn", HabitosAlimentario.Carne);
                cmd.Parameters.AddWithValue("@ques", HabitosAlimentario.Queso);
                cmd.Parameters.AddWithValue("@aguacat", HabitosAlimentario.Aguacate);
                cmd.Parameters.AddWithValue("@semil", HabitosAlimentario.Semillas);


                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                //inserta 
                cmd.ExecuteNonQuery();
                if (listaR != null)
                {
                    foreach (TORecordatorio24H recordatorio in listaR)
                    {
                        cmd2.Parameters.AddWithValue("@ced", recordatorio.Cedula);
                        cmd2.Parameters.AddWithValue("@tiempC", recordatorio.TiempoComida);
                        cmd2.Parameters.AddWithValue("@comid", recordatorio.Comida);
                        cmd2.Parameters.AddWithValue("@cant", recordatorio.Cantidad);
                        cmd2.Parameters.AddWithValue("@descrip", recordatorio.Descripcion);

                        cmd2.ExecuteNonQuery();
                    }
                }

                conexion.Close();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool GuardarAntropometria(TOAntropometria antropom, TOPorciones porcion, TODistribucionPorciones distrib)
        {
            String query1 = "Insert into Antropometria values(" + antropom.Cedula + "," + antropom.Talla + "," +
                antropom.PesoIdeal + "," + antropom.Edad + "," + antropom.PMB + "," + antropom.Peso + "," + antropom.PesoMaxTeoria + ", " +
                antropom.IMC + "," + antropom.PorcGrasaAnalizador + "," + antropom.PorcGr_Bascula + "," + antropom.GB_BI + ","
                + antropom.GB_BD + "," + antropom.GB_PI + "," + antropom.GB_PD + "," + antropom.GB_Tronco + "," + antropom.AguaCorporal + "," +
                antropom.MasaOsea + "," + antropom.Complexión + "," + antropom.EdadMetabolica + "," + antropom.Cintura + "," + antropom.Abdomen + "," +
                 antropom.Cadera + "," + antropom.Muslo + "," + antropom.CBM + "," + antropom.CircunfMunneca + "," + antropom.PorcentMusculo + "," +
                 antropom.PM_BI + "," + antropom.PM_PD + "," + antropom.PM_BD + "," + antropom.PM_PI + "," + antropom.PM_Tronco + "," + antropom.Observaciones + "," +
                  antropom.GEB + "," + antropom.GET + "," + antropom.CHOPorc + "," + antropom.CHOGram + "," + antropom.CHO_kcal + "," + antropom.ProteinaPorc + "," +
                  antropom.ProteinaGram + "," + antropom.Proteinakcal + "," + antropom.GrasaPorc + "," + antropom.GrasaGram + "," + antropom.Grasakcal + "); ";

            String query2 = "Insert into Porciones values(" + porcion.Cedula + "," + porcion.Leche + "," + porcion.Carne + "," + porcion.Vegetales + "," + porcion.Grasa + "," +
               porcion.Fruta + "," + porcion.Azucar + "," + porcion.Harina + "," + porcion.Suplemento + ");";
            String query3 = "Insert into DistribucionPorcion values(" + distrib.Cedula + "," + distrib.Ayunas + "," + distrib.Desayuno + "," +
                distrib.MediaMañana + "," + distrib.Almuerzo + "," + distrib.MediaTarde + "," + distrib.Cena + "," + distrib.ColacionNocturna + ");";
            SqlCommand cmd = new SqlCommand(query1, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);
            SqlCommand cmd3 = new SqlCommand(query3, conexion);
            try
            {

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                //insertar
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                conexion.Close();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool AgregarSeguimiento(TOSeguimientoSemanal tOSeguimientoSemanal)
        {
            String query = "Insert into SeguimientoSemanal values(@sesion,@fech,@peso,@orej,@ejercic,@ced);";
            SqlCommand cmd = new SqlCommand(query, conexion);
            String query2 = "Select max(Sesion) as 'Sesion' from SeguimientoSemanal where Cedula = " + tOSeguimientoSemanal.Cedula;
            SqlCommand cmd2 = new SqlCommand(query2, conexion);
            SqlDataReader lector;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                int ses = 0;
                lector = cmd2.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    string t = lector["Sesion"].ToString();
                    if (lector["Sesion"].ToString().Equals(""))
                    {
                        ses = 1;
                        conexion.Close();
                    }
                    else
                    {
                        ses = Int32.Parse(lector["Sesion"].ToString()) + 1;
                        conexion.Close();
                    }
                }
                else
                {
                    conexion.Close();
                }

                //Asignacion de parametros.
                cmd.Parameters.AddWithValue("@sesion", ses);
                cmd.Parameters.AddWithValue("@fech", tOSeguimientoSemanal.Fecha);
                cmd.Parameters.AddWithValue("@peso", tOSeguimientoSemanal.Peso);
                cmd.Parameters.AddWithValue("@orej", tOSeguimientoSemanal.Oreja);
                cmd.Parameters.AddWithValue("@ejercic", tOSeguimientoSemanal.Ejercicio);
                cmd.Parameters.AddWithValue("@ced", tOSeguimientoSemanal.Cedula);
                //Validacion del estado de la conexion.
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;

            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool GuardarSeguimiento(TOSeguimientoNutri seg, List<TOSeguimientoRecord24> lisSeg, TOSegAntropometria segAnt)
        {
            int idSeg = 0;
            String query1 = "Insert into SeguimNutricion values(@ced, @diaEj , @comE, @niv);";
            String query2 = "Insert into SeguimRecordat24H values(@tiemp,@desc,@idS);";

            String query4 = "Select max(Id_seguim) as 'IdSeg' from SeguimNutricion";
            SqlCommand cmd = new SqlCommand(query1, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);

            SqlCommand cmd4 = new SqlCommand(query4, conexion);
            SqlDataReader lector;
            try
            {

                cmd.Parameters.AddWithValue("@ced", seg.Cedula);
                cmd.Parameters.AddWithValue("@diaEj", seg.DiasEjercicio);
                cmd.Parameters.AddWithValue("@comE", seg.ComidaExtra);
                cmd.Parameters.AddWithValue("@niv", seg.NivelAnsiedad);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                cmd.ExecuteNonQuery();

                lector = cmd4.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    idSeg = Int32.Parse(lector["IdSeg"].ToString());
                    conexion.Close();
                }
                else
                {
                    conexion.Close();
                    return false;
                }
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                if (lisSeg != null)
                {
                    foreach (TOSeguimientoRecord24 seg24 in lisSeg)
                    {
                        cmd2.Parameters.AddWithValue("@tiemp", seg24.TiempoComida);
                        cmd2.Parameters.AddWithValue("@desc", seg24.Descripcion);
                        cmd2.Parameters.AddWithValue("@idS", idSeg);

                        cmd2.ExecuteNonQuery();
                    }
                }
                String query3 = "Insert into SeguimAntropom values(" + idSeg + "," + segAnt.Talla + "," +
             segAnt.PesoIdeal + "," + segAnt.Edad + "," + segAnt.PMB + "," + segAnt.Fecha_SA.Date + "," + segAnt.Peso + "," + segAnt.IMC + ", " +
             segAnt.PorcGrasaAnalizador + "," + segAnt.PorcGr_Bascula + "," + segAnt.GB_BI + "," +
                segAnt.GB_BD + "," + segAnt.GB_PI + "," + segAnt.GB_PD + "," + segAnt.GB_Tronco + "," + segAnt.AguaCorporal + "," +
             segAnt.MasaOsea + "," + segAnt.Complexión + "," + segAnt.EdadMetabolica + "," + segAnt.Cintura + "," + segAnt.Abdomen + "," +
              segAnt.Cadera + "," + segAnt.Muslo + "," + segAnt.Brazo + "," + segAnt.PorcentGViceral + "," + segAnt.PorcentMusculo + "," +
              segAnt.PM_BI + "," + segAnt.PM_PD + "," + segAnt.PM_BD + "," + segAnt.PM_PI + "," + segAnt.PM_Tronco + "," + segAnt.Observaciones + ")";
                SqlCommand cmd3 = new SqlCommand(query3, conexion);
                cmd3.ExecuteNonQuery();

                conexion.Close();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }



        public bool GuardarHistorial(TOHistorialMedico historial, List<TOMedicamento> listaMedicamento)
        {
            String query1 = "Insert into Historial_Medico values(@antec,@patol,@consLic,@fum,@fechEx,@ced,@frecFum,@frecTom,@actvFis);";
            String query2 = "Insert into Medic_Suplem values(@ced,@nomb,@mot,@frec,@dosis);";

            SqlCommand cmd = new SqlCommand(query1, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);

            try
            {
                //Historial Medico.
                //Asignacion de parametros.
                cmd.Parameters.AddWithValue("@antec", historial.Antecedentes);
                cmd.Parameters.AddWithValue("@patol", historial.Patologias);
                cmd.Parameters.AddWithValue("@consLic", historial.ConsumeLicor);
                cmd.Parameters.AddWithValue("@fum", historial.Fuma);
                cmd.Parameters.AddWithValue("@fechEx", historial.UltimoExamen);
                cmd.Parameters.AddWithValue("@ced", historial.Cedula);
                cmd.Parameters.AddWithValue("@frecFum", historial.FrecFuma);
                cmd.Parameters.AddWithValue("@frecTom", historial.FrecLicor);
                cmd.Parameters.AddWithValue("@actvFis", historial.ActividadFisica);
                //Validacion del estado de la conexion.
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                //Insercion del historial medico.
                cmd.ExecuteNonQuery();
                //Insercion de los medicamentos o suplementos del cliente.
                if (listaMedicamento != null)
                {
                    foreach (TOMedicamento medicamento in listaMedicamento)
                    {
                        cmd2.Parameters.AddWithValue("@ced", medicamento.Cedula);
                        cmd2.Parameters.AddWithValue("@nomb", medicamento.Nombre);
                        cmd2.Parameters.AddWithValue("@mot", medicamento.Motivo);
                        cmd2.Parameters.AddWithValue("@frec", medicamento.Frecuencia);
                        cmd2.Parameters.AddWithValue("@dosis", medicamento.Dosis);

                        cmd2.ExecuteNonQuery();
                    }
                }


                conexion.Close();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }

        }

        public List<TOSeguimientoSemanal> ListarSeguimSemanal(string cedula)
        {
            List<TOSeguimientoSemanal> ListaMedidas = new List<TOSeguimientoSemanal>();
            string qry = "Select * from SeguimientoSemanal where Cedula = " + cedula;
            SqlCommand buscar = new SqlCommand(qry, conexion);
            SqlDataReader lector;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            lector = buscar.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ListaMedidas.Add(new TOSeguimientoSemanal(Int32.Parse(lector["Sesion"].ToString()), DateTime.Parse(lector["FechaSesion"].ToString()),
                    decimal.Parse(lector["Peso"].ToString()), lector["Oreja"].ToString(), lector["Ejercicio"].ToString(), lector["Cedula"].ToString()));

                }
                conexion.Close();
                return ListaMedidas;
            }
            else
            {
                conexion.Close();
                return null;
            }


        }

        public void EliminarExpediente(string cedula)
        {
            string query1 = "Delete from Usuario where Cedula = " + cedula;
            string query2 = "Delete from Cliente_Nutricion where Cedula = " + cedula;
            string query3 = "Delete from Antropometria where CedulaCliente = " + cedula;
            string query4 = "Delete from DistribucionPorcion where Cedula = " + cedula;
            string query5 = "Delete from HabitosAlimentario where Cedula = " + cedula;
            string query6 = "Delete from Historial_Medico where Cedula = " + cedula;
            string query7 = "Delete from Medic_Suplem where Cedula = " + cedula;
            string query8 = "Delete from PesoSemanal where Cedula = " + cedula;
            string query9 = "Delete from Porciones where Cedula = " + cedula;
            string query10 = "Delete from Recordat24H where Cedula_Cliente = " + cedula;

            SqlCommand cmd = new SqlCommand(query1, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);
            SqlCommand cmd3 = new SqlCommand(query3, conexion);
            SqlCommand cmd4 = new SqlCommand(query4, conexion);
            SqlCommand cmd5 = new SqlCommand(query5, conexion);
            SqlCommand cmd6 = new SqlCommand(query6, conexion);
            SqlCommand cmd7 = new SqlCommand(query7, conexion);
            SqlCommand cmd8 = new SqlCommand(query8, conexion);
            SqlCommand cmd9 = new SqlCommand(query9, conexion);
            SqlCommand cmd10 = new SqlCommand(query10, conexion);
            SqlDataReader lector;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                string seg = "Select ID_Seguim from SeguimNutricion where Cedula = " + cedula;
                SqlCommand segm = new SqlCommand(seg, conexion);
                lector = segm.ExecuteReader();
                if (lector.HasRows)
                {
                    string query11 = "Delete from SeguimNutricion where Cedula = " + cedula;
                    string query12 = "Delete from SeguimRecordat24H where ID_Seguimiento = " + Int32.Parse(lector["ID_Seguim"].ToString());
                    string query13 = "Delete from SeguimAntropom where ID_Seguimiento = " + Int32.Parse(lector["ID_Seguim"].ToString());
                    string query14 = "Delete from SeguimientoSemanal where Cedula = " + cedula;
                    SqlCommand cmd11 = new SqlCommand(query11, conexion);
                    SqlCommand cmd12 = new SqlCommand(query12, conexion);
                    SqlCommand cmd13 = new SqlCommand(query13, conexion);
                    SqlCommand cmd14 = new SqlCommand(query14, conexion);
                    cmd14.ExecuteNonQuery();
                    cmd13.ExecuteNonQuery();
                    cmd12.ExecuteNonQuery();
                    cmd11.ExecuteNonQuery();
                }
                else
                {
                    conexion.Close();
                }
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                cmd10.ExecuteNonQuery();
                cmd9.ExecuteNonQuery();
                cmd8.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();

                conexion.Close();


            }
            catch (SqlException)
            { }
        }


    }
}
