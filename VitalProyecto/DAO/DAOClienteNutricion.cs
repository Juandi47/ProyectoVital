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
                cmd.Parameters.AddWithValue("@rol", "ClienteNutricion");


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
                  antropom.ProteinaGram + ","+ antropom.Proteinakcal +","+ antropom.GrasaPorc +"," + antropom.GrasaGram +","+ antropom.Grasakcal + "); ";

            String query2 = "Insert into Porciones values("+ porcion.Cedula+","+ porcion.Leche+","+ porcion.Carne+","+ porcion.Vegetales+","+ porcion.Grasa+","+
               porcion.Fruta+","+ porcion.Azucar+","+ porcion.Harina+","+ porcion.Suplemento + ");";
            String query3 = "Insert into DistribucionPorcion values(" + distrib.Cedula+","+ distrib.Ayunas+","+ distrib.Desayuno+","+
                distrib.MediaMañana+","+ distrib.Almuerzo+","+ distrib.MediaTarde+","+ distrib.Cena+","+ distrib.ColacionNocturna + ");";
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
            String query = "Insert into SeguimientoSemanal values(@fech,@peso,@orej,@ejercic,@ced);";
            SqlCommand cmd = new SqlCommand(query, conexion);
            
            try
            {
                //Asignacion de parametros.
                cmd.Parameters.AddWithValue("@fech", tOSeguimientoSemanal.Fecha);
                cmd.Parameters.AddWithValue("@peso", tOSeguimientoSemanal.Peso);
                cmd.Parameters.AddWithValue("@orej", tOSeguimientoSemanal.Oreja);
                cmd.Parameters.AddWithValue("@ejercic", tOSeguimientoSemanal.Ejercicio);
                cmd.Parameters.AddWithValue("@ced", tOSeguimientoSemanal. Cedula);
                //Validacion del estado de la conexion.
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                
                cmd.ExecuteNonQuery();

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
                if(listaMedicamento != null)
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




    }
}
