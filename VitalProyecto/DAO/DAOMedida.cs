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
    public class DAOMedida
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
        public Boolean AgregarMedida(TOMedida medida)
        {
            //    try
            //    {

            String query = "Insert into Medidas values (@freCard, @peso, @porcGrasa, @IMC, @cint, @abdom, @cader, @muslo, @estat, @ced, @fechM)";
                SqlCommand Insertar = new SqlCommand(query, conexion);
              
                Insertar.Parameters.AddWithValue("@freCard", medida.Frec_Cardiaca);
                Insertar.Parameters.AddWithValue("@peso", medida.Peso);
                Insertar.Parameters.AddWithValue("@porcGrasa", medida.Porcent_Grasa);
                Insertar.Parameters.AddWithValue("@IMC", medida.IMC);
                Insertar.Parameters.AddWithValue("@cint", medida.Cintura);
                Insertar.Parameters.AddWithValue("@adbom", medida.Abdomen);
                Insertar.Parameters.AddWithValue("@cader", medida.Cadera);
                Insertar.Parameters.AddWithValue("@muslo", medida.Muslo);
                Insertar.Parameters.AddWithValue("@estat", medida.Estatura);
                Insertar.Parameters.AddWithValue("@ced", medida.Ced_Cliente);
                Insertar.Parameters.AddWithValue("@fechM", medida.Fecha_medida);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                Insertar.ExecuteNonQuery();
                conexion.Close();

                return true;
            //}
            //catch (SqlException)
            //{
            //    return false;
            //}
        }

        public List<TOMedida> ListaCliente()
        {
            List<TOMedida> ListaMedidas = new List<TOMedida>();
            string qry = "Select * from Medidas";
            SqlCommand sent = new SqlCommand(qry, conexion);
            SqlDataReader lector;
            conexion.Open();
            lector = sent.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ListaMedidas.Add(new TOMedida((int)lector["Clave_Medida"], lector["Frecuencia_Cardiaca"].ToString(),
                    (decimal)lector["Peso"], (decimal)lector["Porcentaje_Grasa"], (decimal)lector["IMC"], decimal.Parse(lector["Cintura"].ToString()), decimal.Parse(lector["Abdomen"].ToString()),
                    (decimal)lector["Cadera"], (decimal)lector["Muslo"], (decimal)lector["Estatura"], lector["Cedula"].ToString()));

                }
                conexion.Close();
            }
            else
            {
                conexion.Close();
            }
            return ListaMedidas;
        }

        public TOMedida buscarMedidasCliente(String cedula)
        {
            try
            {
                TOMedida medida = new TOMedida();

                SqlCommand buscar = new SqlCommand("select *  from Medidas where cedula = @cedula", conexion);
                buscar.Parameters.AddWithValue("@cedula", cedula);
                conexion.Open();
                SqlDataReader lector = buscar.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        //medida.Clave = Int32.Parse(lector["Clave_Medida"].ToString());
                        medida.Frec_Cardiaca = lector["Frecuencia_Cardiaca"].ToString();
                        medida.Peso = decimal.Parse(lector["Peso"].ToString());
                        medida.Porcent_Grasa = decimal.Parse(lector["Porcentaje_Grasa"].ToString());
                        medida.IMC = decimal.Parse(lector["IMC"].ToString());
                        medida.Cintura = decimal.Parse(lector["Cintura"].ToString());
                        medida.Abdomen = decimal.Parse(lector["Abdomen"].ToString());
                        medida.Cadera = decimal.Parse(lector["Cadera"].ToString());
                        medida.Muslo = decimal.Parse(lector["Muslo"].ToString());
                        medida.Estatura = decimal.Parse(lector["Estatura"].ToString());
                        medida.Ced_Cliente = lector["Cedula"].ToString();
                        medida.Fecha_medida = DateTime.Parse(lector["Fecha_Medida"].ToString());
                    }
                    lector.Close();
                }
                conexion.Close();
                return medida;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
