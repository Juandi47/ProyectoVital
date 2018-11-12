using System;
using System.Collections.Generic;
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
            String query = "Insert into Medidas values(@freCard,@peso,@porcGrasa,@IMC,@cint,@abdmn,@cader,@muslo,@estat,@ced);";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@ced", medida.Ced_Cliente);
            cmd.Parameters.AddWithValue("@freCard", medida.Frec_Cardiaca);
            cmd.Parameters.AddWithValue("@peso", medida.Peso);
            cmd.Parameters.AddWithValue("@porcGrasa", medida.Porcent_Grasa);
            cmd.Parameters.AddWithValue("@IMC", medida.IMC);
            cmd.Parameters.AddWithValue("@cint", medida.Cintura);
            cmd.Parameters.AddWithValue("@adbmn", medida.Abdomen);
            cmd.Parameters.AddWithValue("@cader", medida.Cadera);
            cmd.Parameters.AddWithValue("@muslo", medida.Muslo);
            cmd.Parameters.AddWithValue("@estat", medida.Estatura);
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
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
    }
}
