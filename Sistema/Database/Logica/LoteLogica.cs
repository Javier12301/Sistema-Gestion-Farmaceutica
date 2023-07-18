using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Database.Modelo;

namespace Sistema.Database.Logica
{

    public class LoteLogica
    {
        // Obtener información de un lote utilizando su ID
        public Lote obtenerLotePorID(int loteID)
        {
            Lote lote = null;

            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();

                string query = "SELECT * FROM Lotes WHERE LoteID = @LoteID";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@LoteID", loteID);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lote = new Lote
                        {
                            LoteID = reader.GetInt32(0),
                            Stock = reader.GetInt32(1),
                            NombreMedicamento = reader.GetString(2),
                            Vencimiento = reader.GetDateTime(3)
                        };
                    }
                }             
            }
            return lote;
        }

        // Agregar un nuevo Lote
        public bool agregarLote(Lote lote)
        {
            using(SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();
                string query = "INSERT INTO Lotes (LoteID, Stock, Nombre_Medicamento, FechaVencimiento) VALUES (@LoteID ,@Stock, @NombreMedicamento, @Vencimiento)";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@LoteID", lote.LoteID);
                cmd.Parameters.AddWithValue("@Stock", lote.Stock);
                cmd.Parameters.AddWithValue("@NombreMedicamento", lote.NombreMedicamento);
                cmd.Parameters.AddWithValue("@Vencimiento", lote.Vencimiento);

                // Ejecutamos el comando
                cmd.ExecuteNonQuery();
            }
            return true;
        }
    }
}
