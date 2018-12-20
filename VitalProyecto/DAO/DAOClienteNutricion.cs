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
            SqlCommand cmd = new SqlCommand(query1, conexion);
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
                cmd.Parameters.AddWithValue("@huev", HabitosAlimentario.Leche);
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
                conexion.Close();
                if (listaR != null)
                {
                    foreach (TORecordatorio24H recordatorio in listaR)
                    {
                        String query2 = "Insert into Recordat24H values(@ced,@tiempC,@comid,@cant,@descrip);";
                        SqlCommand cmd2 = new SqlCommand(query2, conexion);
                        cmd2.Parameters.AddWithValue("@ced", recordatorio.Cedula);
                        cmd2.Parameters.AddWithValue("@tiempC", recordatorio.TiempoComida);
                        cmd2.Parameters.AddWithValue("@comid", recordatorio.Comida);
                        cmd2.Parameters.AddWithValue("@cant", recordatorio.Cantidad);
                        cmd2.Parameters.AddWithValue("@descrip", recordatorio.Descripcion);
                        conexion.Open();
                        cmd2.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
                
                return true;
            }
            catch (SqlException)
            {
                conexion.Close();
                return false;
            }
        }

        public bool GuardarAntropometria(TOAntropometria antropom, TOPorciones porcion, TODistribucionPorciones distrib)
        {
            String query1 = "Insert into Antropometria values(@ced, @talla, @pesIdeal, @edad,@pmb, @peso,@pesmax,@imc, @gAnaliz, @grbascu, @gbbi,@gbbd, @gbpi, @gbpd," +
                "@gbtronc, @aguacorp, @masaOsea, @complex,@edadMetab,@cint,@abdomn,@cader,@muslo,@cbm,@circunf,@grviser,@pormuscul,@pmbi,@pmpd,@pmbd," +
                 "@pmpi,@pmtronco,@observ,@geb,@get,@chopor,@chogram,@chokcal,@protpor,@protgram,@protkcal,@grporc,@grgram,@grkcal)";

            String query2 = "Insert into Porciones values( @pced,@pleche,@pcarne,@pveget,@pgrasa,@pfruta,@pazuc,@pharina, @psuplem)";
            String query3 = "Insert into DistribucionPorcion values(@diCed, @diAyun, @diDesay, @diMedMan,@diAlmuer, @dimedTard,@diCena,@dicolNoc)";
            SqlCommand cmd = new SqlCommand(query1, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);
            SqlCommand cmd3 = new SqlCommand(query3, conexion);
            try
            {

                cmd.Parameters.AddWithValue("@ced", antropom.Cedula); cmd.Parameters.AddWithValue("@talla", antropom.Talla);
                cmd.Parameters.AddWithValue("@pesIdeal", antropom.PesoIdeal); cmd.Parameters.AddWithValue("@edad", antropom.Edad);
                cmd.Parameters.AddWithValue("@pmb", antropom.PMB); cmd.Parameters.AddWithValue("@peso", antropom.Peso);
                cmd.Parameters.AddWithValue("@pesmax", antropom.PesoMaxTeoria); cmd.Parameters.AddWithValue("@imc", antropom.IMC);
                cmd.Parameters.AddWithValue("@gAnaliz", antropom.PorcGrasaAnalizador); cmd.Parameters.AddWithValue("@grbascu", antropom.PorcGr_Bascula);
                cmd.Parameters.AddWithValue("@gbbi", antropom.GB_BI); cmd.Parameters.AddWithValue("@gbbd", antropom.GB_BD);
                cmd.Parameters.AddWithValue("@gbpi", antropom.GB_PI); cmd.Parameters.AddWithValue("@gbpd", antropom.GB_PD);
                cmd.Parameters.AddWithValue("@gbtronc", antropom.GB_Tronco); cmd.Parameters.AddWithValue("@aguacorp", antropom.AguaCorporal);
                cmd.Parameters.AddWithValue("@masaOsea", antropom.MasaOsea); cmd.Parameters.AddWithValue("@complex", antropom.Complexión);
                cmd.Parameters.AddWithValue("@edadMetab", antropom.EdadMetabolica); cmd.Parameters.AddWithValue("@cint", antropom.Cintura);
                cmd.Parameters.AddWithValue("@abdomn", antropom.Abdomen); cmd.Parameters.AddWithValue("@cader", antropom.Cadera);
                cmd.Parameters.AddWithValue("@muslo", antropom.Muslo); cmd.Parameters.AddWithValue("@cbm", antropom.CBM);
                cmd.Parameters.AddWithValue("@circunf", antropom.CircunfMunneca); cmd.Parameters.AddWithValue("@grviser", antropom.PorcentGViceral);
                cmd.Parameters.AddWithValue("@pormuscul", antropom.PorcentMusculo); cmd.Parameters.AddWithValue("@pmbi", antropom.PM_BI);
                cmd.Parameters.AddWithValue("@pmpd", antropom.PM_PD); cmd.Parameters.AddWithValue("@pmbd", antropom.PM_BD);
                cmd.Parameters.AddWithValue("@pmpi", antropom.PM_PI); cmd.Parameters.AddWithValue("@pmtronco", antropom.PM_Tronco);
                cmd.Parameters.AddWithValue("@observ", antropom.Observaciones); cmd.Parameters.AddWithValue("@geb", antropom.GEB);
                cmd.Parameters.AddWithValue("@get", antropom.GET); cmd.Parameters.AddWithValue("@chopor", antropom.CHOPorc);
                cmd.Parameters.AddWithValue("@chogram", antropom.CHOGram); cmd.Parameters.AddWithValue("@chokcal", antropom.CHO_kcal);
                cmd.Parameters.AddWithValue("@protpor", antropom.ProteinaPorc); cmd.Parameters.AddWithValue("@protgram", antropom.ProteinaGram);
                cmd.Parameters.AddWithValue("@protkcal", antropom.Proteinakcal); cmd.Parameters.AddWithValue("@grporc", antropom.GrasaPorc);
                cmd.Parameters.AddWithValue("@grgram", antropom.GrasaGram); cmd.Parameters.AddWithValue("@grkcal", antropom.Grasakcal);
                cmd2.Parameters.AddWithValue("@pced", porcion.Cedula); cmd2.Parameters.AddWithValue("@pleche", porcion.Leche);
                cmd2.Parameters.AddWithValue("@pcarne", porcion.Carne); cmd2.Parameters.AddWithValue("@pveget", porcion.Vegetales);
                cmd2.Parameters.AddWithValue("@pgrasa", porcion.Grasa); cmd2.Parameters.AddWithValue("@pfruta", porcion.Fruta);
                cmd2.Parameters.AddWithValue("@pazuc", porcion.Azucar); cmd2.Parameters.AddWithValue("@pharina", porcion.Harina);
                cmd2.Parameters.AddWithValue("@psuplem", porcion.Suplemento);
                cmd3.Parameters.AddWithValue("@diCed", distrib.Cedula); cmd3.Parameters.AddWithValue("@diAyun", distrib.Ayunas);
                cmd3.Parameters.AddWithValue("@diDesay", distrib.Desayuno); cmd3.Parameters.AddWithValue("@diMedMan", distrib.MediaMañana);
                cmd3.Parameters.AddWithValue("@diAlmuer", distrib.Almuerzo); cmd3.Parameters.AddWithValue("@dimedTard", distrib.MediaTarde);
                cmd3.Parameters.AddWithValue("@diCena", distrib.Cena); cmd3.Parameters.AddWithValue("@dicolNoc", distrib.ColacionNocturna);



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

        public TOAntropometria TraerAntropometria(string ced)
        {
            string qry = "select * from Antropometria where CedulaCliente = " + ced;
            SqlCommand cmd = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    TOAntropometria antrop = new TOAntropometria(lector["CedulaCliente"].ToString(), Decimal.Parse(lector["Talla"].ToString()),
                        Decimal.Parse(lector["PesoIdeal"].ToString()), Decimal.Parse(lector["Edad"].ToString()), Decimal.Parse(lector["PMB"].ToString()), Decimal.Parse(lector["Peso"].ToString()),
                        Decimal.Parse(lector["PesoMaxTeoria"].ToString()), Decimal.Parse(lector["IMC"].ToString()), Decimal.Parse(lector["PorcGrasaAnalizador"].ToString()), Decimal.Parse(lector["PorcGr_Bascula"].ToString()),
                        Decimal.Parse(lector["GB_BI"].ToString()), Decimal.Parse(lector["GB_BD"].ToString()), Decimal.Parse(lector["GB_PI"].ToString()), Decimal.Parse(lector["GB_PD"].ToString()), Decimal.Parse(lector["GB_Tronco"].ToString()),
                        Decimal.Parse(lector["AguaCorporal"].ToString()), Decimal.Parse(lector["MasaOsea"].ToString()), Decimal.Parse(lector["Complexion"].ToString()), Decimal.Parse(lector["Edad_Metabolica"].ToString()), Decimal.Parse(lector["Cintura"].ToString()),
                        Decimal.Parse(lector["Abdomen"].ToString()), Decimal.Parse(lector["Cadera"].ToString()), lector["Muslo"].ToString(), lector["CBM"].ToString(), Decimal.Parse(lector["CircunfMunneca"].ToString()), Decimal.Parse(lector["PorcentGViceral"].ToString()),
                        Decimal.Parse(lector["PorcentMusculo"].ToString()), Decimal.Parse(lector["PM_BI"].ToString()), Decimal.Parse(lector["PM_PD"].ToString()), Decimal.Parse(lector["PM_BD"].ToString()),
                        Decimal.Parse(lector["PM_PI"].ToString()), Decimal.Parse(lector["PM_Troco"].ToString()), lector["Observaciones"].ToString(), Decimal.Parse(lector["GEB"].ToString()),
                        Decimal.Parse(lector["GET"].ToString()), Decimal.Parse(lector["CHOPorc"].ToString()), Decimal.Parse(lector["CHOGram"].ToString()), Decimal.Parse(lector["CHOkcal"].ToString()),
                        Decimal.Parse(lector["ProteinaPorc"].ToString()), Decimal.Parse(lector["ProteinaGram"].ToString()), Decimal.Parse(lector["Proteinakcal"].ToString()), Decimal.Parse(lector["GrasaPorc"].ToString()),
                        Decimal.Parse(lector["GrasaPorc"].ToString()), Decimal.Parse(lector["Grasakcal"].ToString()));
                    conexion.Close();
                    return antrop;
                }
                else
                {
                    conexion.Close();
                    return null;
                }
            }
            catch (SqlException)
            {
                conexion.Close();
                return null;
            }
        }

        public bool GuardarSeguimiento(TOSeguimientoNutri seg, List<TOSeguimientoRecord24> lisSeg, TOSegAntropometria segAnt)
        {
            int idSeg = 0;
            String query1 = "Insert into SeguimNutricion values(@ced, @diaEj , @comE, @niv);";
            String query4 = "Select max(Id_seguim) as 'IdSeg' from SeguimNutricion";
            SqlCommand cmd = new SqlCommand(query1, conexion);
            
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

            if (lisSeg != null)
            {
                
                foreach (TOSeguimientoRecord24 seg24 in lisSeg)
                {
                    String query2 = "Insert into SeguimRecordat24H values(@tiemp,@desc,@idS);";
                    SqlCommand cmd2 = new SqlCommand(query2, conexion);
                    cmd2.Parameters.AddWithValue("@tiemp", seg24.TiempoComida);
                    cmd2.Parameters.AddWithValue("@desc", seg24.Descripcion);
                    cmd2.Parameters.AddWithValue("@idS", idSeg);
                    conexion.Open();
                    cmd2.ExecuteNonQuery();
                    conexion.Close();
                }
                
            }
            String query3 = "Insert into SeguimAntropom values(@idSeg,@talla,@pesIdeal,@sEdad,@sPMB,@sFechSA,@sPeso,@sIMC," +
                             "@sPorcAnaliz, @sGrBasc, @sGBBI,@sGBBD,@sGBPI,@sGBPD,@sGBTron,@sAguaCorp," +
                             "@sMasaOsea,@sComplex,@sEdadMetab,@sCint,@sAbdomn,@sCader,@sMuslo,@sBrazo,@sPorcVicer,@spMuscul," +
                             "@spmBI, @sPMPD,@sPMBD,@sPMPI,@sPMTronc,@sObserv)";
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                SqlCommand cmd3 = new SqlCommand(query3, conexion);

            cmd3.Parameters.AddWithValue("@idSeg", idSeg); cmd3.Parameters.AddWithValue("@talla", segAnt.Talla);
            cmd3.Parameters.AddWithValue("@pesIdeal", segAnt.PesoIdeal); cmd3.Parameters.AddWithValue("@sEdad", segAnt.Edad);
            cmd3.Parameters.AddWithValue("@sPMB", segAnt.PMB); cmd3.Parameters.AddWithValue("@sFechSA", segAnt.Fecha_SA);
            cmd3.Parameters.AddWithValue("@sPeso", segAnt.Peso); cmd3.Parameters.AddWithValue("@sIMC", segAnt.IMC);
            cmd3.Parameters.AddWithValue("@sPorcAnaliz", segAnt.PorcGrasaAnalizador); cmd3.Parameters.AddWithValue("@sGrBasc", segAnt.PorcGr_Bascula);
            cmd3.Parameters.AddWithValue("@sGBBI", segAnt.GB_BI); cmd3.Parameters.AddWithValue("@sGBBD", segAnt.GB_BD);
            cmd3.Parameters.AddWithValue("@sGBPI", segAnt.GB_PI); cmd3.Parameters.AddWithValue("@sGBPD", segAnt.GB_PD);
            cmd3.Parameters.AddWithValue("@sGBTron", segAnt.GB_Tronco); cmd3.Parameters.AddWithValue("@sAguaCorp", segAnt.AguaCorporal);
            cmd3.Parameters.AddWithValue("@sMasaOsea", segAnt.MasaOsea); cmd3.Parameters.AddWithValue("@sComplex", segAnt.Complexión);
            cmd3.Parameters.AddWithValue("@sEdadMetab", segAnt.EdadMetabolica); cmd3.Parameters.AddWithValue("@sCint", segAnt.Cintura);
            cmd3.Parameters.AddWithValue("@sAbdomn", segAnt.Abdomen); cmd3.Parameters.AddWithValue("@sCader", segAnt.Cadera);
            cmd3.Parameters.AddWithValue("@sMuslo", segAnt.Muslo); cmd3.Parameters.AddWithValue("@sBrazo", segAnt.Brazo);
            cmd3.Parameters.AddWithValue("@sPorcVicer", segAnt.PorcentGViceral); cmd3.Parameters.AddWithValue("@spMuscul", segAnt.PorcentMusculo);
            cmd3.Parameters.AddWithValue("@spmBI", segAnt.PM_BI); cmd3.Parameters.AddWithValue("@sPMPD", segAnt.PM_PD);
            cmd3.Parameters.AddWithValue("@sPMBD", segAnt.PM_BD); cmd3.Parameters.AddWithValue("@sPMPI", segAnt.PM_PI);
            cmd3.Parameters.AddWithValue("@sPMTronc", segAnt.PM_Tronco); cmd3.Parameters.AddWithValue("@sObserv", segAnt.Observaciones);

            cmd3.ExecuteNonQuery();

            conexion.Close();

            return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public TODistribucionPorciones TraerDistribucion(string ced)
        {
            string qry = "select * from DistribucionPorcion where Cedula = " + ced;
            SqlCommand cmd = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    TODistribucionPorciones distrib = new TODistribucionPorciones(lector["Cedula"].ToString(), lector["Ayunas"].ToString(),
                        lector["Desayuno"].ToString(), lector["MediaMañana"].ToString(), lector["Almuerzo"].ToString(),
                        lector["MediaTarde"].ToString(), lector["Cena"].ToString(), lector["ColacionNocturna"].ToString());
                    conexion.Close();
                    return distrib;
                }
                else
                {
                    conexion.Close();
                    return null;
                }
            }
            catch (SqlException)
            {
                conexion.Close();
                return null;
            }
        }

        public TOPorciones TraerPorciones(string ced)
        {
            string qry = "select * from Porciones where Cedula = " + ced;
            SqlCommand cmd = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    TOPorciones porcion = new TOPorciones(lector["Cedula"].ToString(), Decimal.Parse(lector["Leche"].ToString()),
                        Decimal.Parse(lector["Carne"].ToString()), Decimal.Parse(lector["Vegetales"].ToString()), Decimal.Parse(lector["Grasa"].ToString()),
                        Decimal.Parse(lector["Fruta"].ToString()), Decimal.Parse(lector["Azucar"].ToString()), Decimal.Parse(lector["Harina"].ToString()), Decimal.Parse(lector["Suplemento"].ToString()));
                    conexion.Close();
                    return porcion;
                }
                else
                {
                    conexion.Close();
                    return null;
                }
            }
            catch (SqlException)
            {
                conexion.Close();
                return null;
            }
        }

        public TOHistorialMedico TraerHistorialMed(string ced)
        {
            TOHistorialMedico hm = new TOHistorialMedico();
            string query = "Select * from Historial_Medico where Cedula = " + ced;
            SqlCommand buscar = new SqlCommand(query, conexion);
            SqlDataReader lector;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                lector = buscar.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    hm.Cedula = lector["Cedula"].ToString();
                    hm.Antecedentes = lector["Antecedentes_Fam"].ToString();
                    hm.Patologias = lector["Patologias"].ToString();
                    hm.Fuma = Int32.Parse(lector["Fumador"].ToString());
                    hm.UltimoExamen = DateTime.Parse(lector["Fecha_Ult_Exm"].ToString());
                    hm.FrecFuma = lector["FrecFumar"].ToString();
                    hm.FrecLicor = lector["FrecTomar"].ToString();
                    hm.ActividadFisica = lector["ActividadFisica"].ToString();
                    conexion.Close();
                }
                else
                {
                    conexion.Close();
                    return null;
                }
            }
            catch
            { conexion.Close(); }
            return hm;
        }
        public bool GuardarHistorial(TOHistorialMedico historial, List<TOMedicamento> listaMedicamento)
        {
            string query1 = "Insert into Historial_Medico values(@antec,@patol,@consLic,@fum,@fechEx,@ced,@frecFum,@frecTom,@actvFis);";
           
            SqlCommand cmd = new SqlCommand(query1, conexion);

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
                conexion.Close();
                //Insercion de los medicamentos o suplementos del cliente.
                if (listaMedicamento != null)
                {
                    foreach (TOMedicamento medicamento in listaMedicamento)
                    {
                        string query2 = "Insert into Medic_Suplem values(@ced,@nomb,@mot,@frec,@dosis)";
                        SqlCommand cmd2 = new SqlCommand(query2, conexion);
                        cmd2.Parameters.AddWithValue("@ced", medicamento.Cedula);
                        cmd2.Parameters.AddWithValue("@nomb", medicamento.Nombre);
                        cmd2.Parameters.AddWithValue("@mot", medicamento.Motivo);
                        cmd2.Parameters.AddWithValue("@frec", medicamento.Frecuencia);
                        cmd2.Parameters.AddWithValue("@dosis", medicamento.Dosis);
                        conexion.Open();
                        cmd2.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
                
                return true;
            }
            catch (SqlException)
            {
                return false;
            }

        }

        public List<TORecordatorio24H> TraerRecord24H(string ced)
        {
            List<TORecordatorio24H> list = new List<TORecordatorio24H>();
            string qry = "Select * from Recordat24H where Cedula_Cliente =" + ced;
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
                    list.Add(new TORecordatorio24H(lector["Cedula_Cliente"].ToString(), lector["TiempoComida"].ToString(), lector["Comida"].ToString(),
                    lector["Cantidad"].ToString(), lector["Descripcion"].ToString()));
                }
                conexion.Close();
                return list;
            }
            else
            {
                conexion.Close();
                return null;
            }
        }

        public List<TOMedicamento> ListaSuplMed(string ced)
        {
            List<TOMedicamento> list = new List<TOMedicamento>();
            string qry = "Select * from Medic_Suplem where Cedula =" + ced;
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
                    list.Add(new TOMedicamento(lector["Cedula"].ToString(), lector["Nombre"].ToString(), lector["Motivo"].ToString(),
                    lector["Frecuencia"].ToString(), lector["Dosis"].ToString()));
                }
                conexion.Close();
                return list;
            }
            else
            {
                conexion.Close();
                return null;
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

        public TOHabitoAlimentario ConsultarHabitoAlimentario(string cedula)
        {

            string qry = "select * from HabitosAlimentario where Cedula = " + cedula;
            SqlCommand buscar = new SqlCommand(qry, conexion);
            SqlDataReader lector;

            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            lector = buscar.ExecuteReader();
            if (lector.HasRows)
            {
                lector.Read();
                TOHabitoAlimentario hab = new TOHabitoAlimentario(cedula, Int32.Parse(lector["ComidasDiarias"].ToString()),
                    Int32.Parse(lector["Com_Hor_Dias"].ToString()), Int32.Parse(lector["Afuera_Express"].ToString()),
                    lector["ComidaFuera"].ToString(), lector["AzucarBebida"].ToString(), lector["ComidaElaborada_Con"].ToString(),
                    Decimal.Parse(lector["VasosAguaDiaria"].ToString()), Int32.Parse(lector["Aderezos"].ToString()),
                    Int32.Parse(lector["Fruta"].ToString()), Int32.Parse(lector["Verdura"].ToString()),
                    Int32.Parse(lector["Leche"].ToString()), Int32.Parse(lector["Huevo"].ToString()),
                    Int32.Parse(lector["Yogurt"].ToString()), Int32.Parse(lector["Carne"].ToString()),
                    Int32.Parse(lector["Queso"].ToString()), Int32.Parse(lector["Aguacate"].ToString()),
                    Int32.Parse(lector["Semillas"].ToString()));
                conexion.Close();
                return hab;
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
            string query8 = "Delete from Porciones where Cedula = " + cedula;
            string query9 = "Delete from Recordat24H where Cedula_Cliente = " + cedula;

            SqlCommand cmd = new SqlCommand(query1, conexion);
            SqlCommand cmd2 = new SqlCommand(query2, conexion);
            SqlCommand cmd3 = new SqlCommand(query3, conexion);
            SqlCommand cmd4 = new SqlCommand(query4, conexion);
            SqlCommand cmd5 = new SqlCommand(query5, conexion);
            SqlCommand cmd6 = new SqlCommand(query6, conexion);
            SqlCommand cmd7 = new SqlCommand(query7, conexion);
            SqlCommand cmd8 = new SqlCommand(query8, conexion);
            SqlCommand cmd9 = new SqlCommand(query9, conexion);
            SqlDataReader lector;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                string seg = "Select ID_Seguim from SeguimNutricion where Cedula = " + cedula;
                SqlCommand segm = new SqlCommand(seg, conexion);
                List<int> ids = new List<int>();
                lector = segm.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        ids.Add(Int32.Parse(lector["ID_Seguim"].ToString()));
                        
                    }
                    conexion.Close();                   
                }
                else { ids = null; conexion.Close();}
                if(ids != null)
                {
                    foreach (int i in ids)
                    {
                        string query10 = "Delete from SeguimNutricion where ID_Seguim = " + i;
                        string query11 = "Delete from SeguimRecordat24H where ID_Seguimiento = " + i;
                        string query12 = "Delete from SeguimAntropom where ID_Seguimiento = " + i;

                        SqlCommand cmd10 = new SqlCommand(query10, conexion);
                        SqlCommand cmd11 = new SqlCommand(query11, conexion);
                        SqlCommand cmd12 = new SqlCommand(query12, conexion);
                        conexion.Open();
                        cmd12.ExecuteNonQuery();
                        cmd11.ExecuteNonQuery();
                        cmd10.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
                string query13 = "Delete from SeguimientoSemanal where Cedula = " + cedula;
                SqlCommand cmd13 = new SqlCommand(query13, conexion);
                if (conexion.State != ConnectionState.Open){conexion.Open();}
                cmd13.ExecuteNonQuery(); 
                cmd9.ExecuteNonQuery();
                cmd8.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();

                conexion.Close();
            }
            catch (SqlException)
            { }
        }

        public Boolean existeCliente(string cedula)
        {
            Boolean existe = false;
            string tel = "";
            string resi = "";

            try
            {
                SqlCommand buscar = new SqlCommand("select * from Cliente_Nutricion where Cedula = @ced;", conexion);

                buscar.Parameters.AddWithValue("@ced", cedula);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader lector = buscar.ExecuteReader();


                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        tel = lector["Telefono"].ToString();
                        resi = lector["Residencia"].ToString();
                    }
                    lector.Close();
                }

                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }

                if (tel != "" && resi != "")
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
                return existe;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<TOSeguimMensual> consultarSeguimMensual(String cedula)
        {
            //Buscar el o los seguimientos mensuales del cliente
            List<TOSeguimMensual> seguimMensual = new List<TOSeguimMensual>();
            string qry1 = "Select * from SeguimNutricion where Cedula = @ced";
            SqlCommand command = new SqlCommand(qry1, conexion);
            command.Parameters.AddWithValue("@ced", cedula);

            SqlDataReader lector;
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            lector = command.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int idSeg = Int32.Parse(lector["ID_Seguim"].ToString());
                    TOSeguimientoNutri nut = new TOSeguimientoNutri(lector["Cedula"].ToString(), int.Parse(lector["DiasEjercSem"].ToString()), lector["ComidaExtra"].ToString(), lector["NivelAnsiedad"].ToString());
                    seguimMensual.Add(new TOSeguimMensual(idSeg, nut));
                }
                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }
            }
            else
            {
                seguimMensual = null;
                if (conexion.State != ConnectionState.Closed) { conexion.Close(); }
            }
            if(seguimMensual != null)
            {
                foreach (TOSeguimMensual seg in seguimMensual)
                {
                    //Buscar la lista de los recordatorios de 24 horas del seguimiento nutricional 'nut'
                    string qry2 = "Select * from SeguimRecordat24H where ID_Seguimiento = @id";
                    SqlCommand cmd = new SqlCommand(qry2, conexion);
                    
                    cmd.Parameters.AddWithValue("@id", seg.id);

                    if (conexion.State != ConnectionState.Closed) { conexion.Close(); }
                    SqlDataReader lector2;
                    List<TOSeguimientoRecord24> nutrec = new List<TOSeguimientoRecord24>();
                    if (conexion.State != ConnectionState.Open) { conexion.Open(); }
                    lector2 = cmd.ExecuteReader();
                    if (lector2.HasRows)
                    {
                        while (lector2.Read())
                        {
                            nutrec.Add(new TOSeguimientoRecord24(int.Parse(lector2["ID_Seguimiento"].ToString()), lector2["TiempoComida"].ToString(), lector2["Descripcion"].ToString()));
                        }
                        seg.record = nutrec;
                        conexion.Close();
                    }
                    else { seg.record = null; }

                    //Seleccionar el seguimiento de antropometría del seguiemiento mensual
                    string qry3 = "Select * from SeguimAntropom where ID_Seguimiento =  @idAntr";
                    SqlCommand cmd3 = new SqlCommand(qry3, conexion);
                    cmd3.Parameters.AddWithValue("@idAntr", seg.id);

                    if (conexion.State != ConnectionState.Closed) { conexion.Close(); }
                    SqlDataReader lector3;
                    TOSegAntropometria nutantrop = null;
                    if (conexion.State != ConnectionState.Open) { conexion.Open(); }
                    lector3 = cmd3.ExecuteReader();
                    if (lector3.HasRows)
                    {
                        lector3.Read();
                        //while (lector2.Read())
                        //{
                        nutantrop = new TOSegAntropometria(int.Parse(lector3["ID_SegAntrop"].ToString()), int.Parse(lector3["ID_Seguimiento"].ToString()), decimal.Parse(lector3["Talla"].ToString()), decimal.Parse(lector3["PesoIdeal"].ToString()), decimal.Parse(lector3["Edad"].ToString()),
                        decimal.Parse(lector3["PMB"].ToString()), DateTime.Parse(lector3["Fecha_SA"].ToString()), decimal.Parse(lector3["Peso"].ToString()), decimal.Parse(lector3["IMC"].ToString()), decimal.Parse(lector3["PorcGrasaAnalizador"].ToString()), decimal.Parse(lector3["PorcGR_Bascula"].ToString()),
                        decimal.Parse(lector3["GB_BI"].ToString()), decimal.Parse(lector3["GB_BD"].ToString()), decimal.Parse(lector3["GB_PI"].ToString()), decimal.Parse(lector3["GB_PD"].ToString()), decimal.Parse(lector3["GB_Tronco"].ToString()), decimal.Parse(lector3["tPorcGVisceral"].ToString()),
                        decimal.Parse(lector3["PorcentMusculo"].ToString()), decimal.Parse(lector3["PM_BI"].ToString()), decimal.Parse(lector3["PM_PD"].ToString()), decimal.Parse(lector3["PM_BD"].ToString()), decimal.Parse(lector3["PM_PI"].ToString()), decimal.Parse(lector3["PM_Troco"].ToString()),
                        decimal.Parse(lector3["AguaCorporal"].ToString()), decimal.Parse(lector3["MasaOsea"].ToString()), decimal.Parse(lector3["Complexion"].ToString()), decimal.Parse(lector3["Edad_Metabolica"].ToString()), decimal.Parse(lector3["Cintura"].ToString()), decimal.Parse(lector3["Abdomen"].ToString()),
                        decimal.Parse(lector3["Cadera"].ToString()), lector3["Muslo"].ToString(), decimal.Parse(lector3["Brazo"].ToString()), lector3["Observaciones"].ToString());
                        //}
                        seg.antrop = nutantrop;
                        conexion.Close();
                    }
                    else { seg.antrop = null; }

                }
            }
            if (conexion.State != ConnectionState.Closed) { conexion.Close(); }
            return seguimMensual;
        }


    }
}
