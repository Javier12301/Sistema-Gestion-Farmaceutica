using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Database.Modelo;

namespace Sistema.Database.Logica
{
    public class MedicamentoLogica
    {
        public Medicamento obtenerMedicamentoPorID(int LoteID)
        {
            Medicamento medicamento = null;
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();

                // Consulta SQL
                string query = "SELECT * FROM Medicamentos WHERE LoteID = @LoteID";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@LoteID", LoteID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        medicamento = new Medicamento
                        {
                            LoteID = reader.GetInt32(0),
                            CategoriaID = reader.GetInt32(1),
                            EstanteID = reader.GetInt32(2),
                            PrecioUnitario = reader.GetDecimal(3),
                        };
                    }
                }
            }
            return medicamento;
        }

        // Obtener todos los medicamentos filtrados por ID CategoriaForm y ID Estante
        public List<Medicamento> obtenerMedicamentoParaDataGridView()
        {
            List<Medicamento> medicamentos = new List<Medicamento>();
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();

                // Consulta SQL
                string query = @"
SELECT 
    M.LoteID AS Lote,
    L.Nombre_Medicamento AS Nombre_Medicamento,
    L.Stock AS Cantidad,
    L.FechaVencimiento AS Vencimiento,
    C.Nombre AS CategoriaForm,
    E.Nombre AS Nombre_Estante,
    E.Sector AS Sector,
    E.Numero_de_estante AS Numero_Estante
FROM Medicamentos M
INNER JOIN Lotes L ON M.LoteID = L.LoteID
INNER JOIN Categorias C ON M.CategoriaID = C.CategoriaID
INNER JOIN EstantesForm E ON M.EstanteID = E.EstanteID;

";
                SqlCommand cmd = new SqlCommand(query, conex);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Inicializar los objetos
                        Medicamento medicamento = new Medicamento();
                        medicamento.LoteID = reader.GetInt32(0);
                        medicamento.Nombre_Medicamento = reader.GetString(1);
                        medicamento.Stock = reader.GetInt32(2);
                        medicamento.FechaVencimiento = reader.GetDateTime(3);
                        medicamento.CategoriaNombre = reader.GetString(4);
                        medicamento.Nombre_Estante = reader.GetString(5);
                        medicamento.Sector = reader.GetString(6);
                        medicamento.Numero_Estante = reader.GetInt32(7);
                        // Agregar a la lista
                        medicamentos.Add(medicamento);
                    }
                }
            }
            return medicamentos;
        }

        // Agrer un nuevo medicamento
        public bool agregarMedicamento(Medicamento medicamento)
        {
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();

                // Consulta SQL
                string query = "INSERT INTO Medicamentos (LoteID, CategoriaID, EstanteID, PrecioUnitario) " +
                               "VALUES (@LoteID, @CategoriaID, @EstanteID, @PrecioUnitario)";

                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@LoteID", medicamento.LoteID);
                cmd.Parameters.AddWithValue("@CategoriaID", medicamento.CategoriaID);
                cmd.Parameters.AddWithValue("@EstanteID", medicamento.EstanteID);
                cmd.Parameters.AddWithValue("@PrecioUnitario", medicamento.PrecioUnitario);

                // Filas afectadas
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0; // Si es mayor a 0, se agregó correctamente
            }
        }

        // Obtener cantidad total de medicamentos
        public int obtenerCantidadMedicamentos()
        {
            int cantidad = 0;
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();
                // Consulta SQL
                string query = "SELECT COUNT(*) FROM Medicamentos";
                SqlCommand cmd = new SqlCommand(query, conex);
                cantidad = (int)cmd.ExecuteScalar();
            }
            return cantidad;
        }

    }
}
