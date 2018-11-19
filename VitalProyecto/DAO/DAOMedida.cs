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
            try
            {
                
            String query = "Insert into Medidas values (@freCard, @peso, @porcGrasa, @IMC, @cint, @abdmn, @cader, @muslo, @estat, @ced);";
            SqlCommand Insertar = new SqlCommand(query, conexion);
            Insertar.Parameters.AddWithValue("@ced", medida.Ced_Cliente);
            Insertar.Parameters.AddWithValue("@freCard", medida.Frec_Cardiaca);
            Insertar.Parameters.AddWithValue("@peso", medida.Peso);
            Insertar.Parameters.AddWithValue("@porcGrasa", medida.Porcent_Grasa);
            Insertar.Parameters.AddWithValue("@IMC", medida.IMC);
            Insertar.Parameters.AddWithValue("@cint", medida.Cintura);
            Insertar.Parameters.AddWithValue("@adbmn", medida.Abdomen);
            Insertar.Parameters.AddWithValue("@cader", medida.Cadera);
            Insertar.Parameters.AddWithValue("@muslo", medida.Muslo);
            Insertar.Parameters.AddWithValue("@estat", medida.Estatura);

                conexion.Open();
                Insertar.ExecuteNonQuery();
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
