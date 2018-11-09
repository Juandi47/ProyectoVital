using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class Class1
    {

        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

        public void ActualizarRegistroPersona() {

            StreamReader reader = new StreamReader("C:/Users/antho/Desktop/padron/PADRON_COMPLETO.txt", System.Text.Encoding.Default);
            String line;
            int counter = 0;

            String ced = "";
            String nombre = "";
            String ape1 = "";
            String ape2 = "";

            List<Persona> lista = new List<Persona>();

            while ((line = reader.ReadLine()) != null) {

                if (counter > -1)
                {
                    String[] info = line.Split(',');

                    ced = info[0];
                    nombre = info[5].TrimEnd(' ');
                    ape1 = info[6].TrimEnd(' ');
                    ape2 = info[7].TrimEnd(' ');


                    lista.Add(new Persona(ced, nombre, ape1, ape2));
                }
                counter++;
            }

            SqlCommand cmd;
            foreach (Persona p in lista) {

                cmd = new SqlCommand("insert into Persona values (@ced,@nom,@ap1,@ap2);", conexion);

                cmd.Parameters.AddWithValue("@ced", p.ced);
                cmd.Parameters.AddWithValue("@nom", p.nom);
                cmd.Parameters.AddWithValue("@ap1", p.ap1);
                cmd.Parameters.AddWithValue("@ap2", p.ap2);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception){

                }
            }



        }

    }
}
