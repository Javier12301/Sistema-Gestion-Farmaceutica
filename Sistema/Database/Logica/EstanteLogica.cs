using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Database.Modelo;

namespace Sistema.Database.Logica
{
    public class EstanteLogica
    {

        // Obtener Lista de Categoria para cargar Datagridview
        public List<Estante> obtenerEstante()
        {
            List<Estante> listaEstante = new List<Estante>();

            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                string query = "SELECT * FROM Estantes";
                SqlCommand cmd = new SqlCommand(query, conex);
                conex.Open();

                // Ejecutamos el comando
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Estante estante = new Estante();
                        estante.EstanteID = reader.GetInt32(0);
                        estante.Nombre = reader.GetString(1);
                        estante.Num_Estante = reader.GetInt32(2);
                        estante.Sector = reader.GetString(3);

                        // Agregamos el objeto a la lista
                        listaEstante.Add(estante);
                    }
                }
            }
            return listaEstante;
        }

        // Agregar Estantes
        public bool agregarEstante(Estante estante)
        {
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();
                string query = "INSERT INTO Estantes (Nombre, Numero_de_estante, Sector) VALUES (@Nombre, @Num_Estante, @Sector)";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@Nombre", estante.Nombre);
                cmd.Parameters.AddWithValue("@Num_Estante", estante.Num_Estante);
                cmd.Parameters.AddWithValue("@Sector", estante.Sector);

                // Ejecutamos el comando
                cmd.ExecuteNonQuery();
            }
            return true; // Operación exitosa
        }

        // Modificar Estantes
        public bool modificarEstante(Estante estante)
        {
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();

                string query = "UPDATE Estantes SET Nombre = @Nombre, Numero_de_estante = @Num_Estante, Sector = @Sector WHERE EstanteID = @EstanteID";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@EstanteID", estante.EstanteID);
                cmd.Parameters.AddWithValue("@Nombre", estante.Nombre);
                cmd.Parameters.AddWithValue("@Num_Estante", estante.Num_Estante);
                cmd.Parameters.AddWithValue("@Sector", estante.Sector);

                // Ejecutamos el comando
                int rowAfectadas = cmd.ExecuteNonQuery();
                return rowAfectadas > 0; // Operación exitosa si se afectó alguna fila
            }
        }

        // Eliminar Estantes
        public bool eliminarEstante(int _id)
        {
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();

                string query = "DELETE FROM Estantes WHERE EstanteID = @EstanteID";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@EstanteID", _id);

                // Ejecutamos el comando
                int rowAfectadas = cmd.ExecuteNonQuery();
                return rowAfectadas > 0; // Operación exitosa si se afectó alguna fila
            }
        }

        // Obtener cantidad total de estantes
        public int obtenerCantidadEstantes()
        {
            try
            {
                using (SqlConnection conex = new SqlConnection())
                {
                    conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                    string query = "SELECT COUNT(*) FROM Estantes";
                    SqlCommand cmd = new SqlCommand(query, conex);
                    conex.Open();

                    // Ejecutamos la consulta y retornamos el resultado
                    return (int)cmd.ExecuteScalar();
                }

            }catch(SqlException)
            {
                throw;
            }
        }

        // Obtener nombres de estantes
        public List<string> obtenerNombresEstantes()
        {
            List<string> nombresEstantes = new List<string> ();
            try
            {
                using(SqlConnection conex = new SqlConnection())
                {
                    conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                    string query = "SELECT Nombre FROM Estantes";
                    SqlCommand cmd = new SqlCommand(query, conex);
                    conex.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreEstante = reader.GetString(0);
                            nombresEstantes.Add(nombreEstante);
                        }
                    }
                }

            }catch(SqlException)
            {
                throw;
            }
            return nombresEstantes;
        }

        // Obtener ID de estante por nombre
        public int obtenerIDEstantePorNombre(string _nombre)
        {
            try
            {
                using (SqlConnection conex = new SqlConnection())
                {
                    conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                    string query = "SELECT EstanteID FROM Estantes WHERE Nombre = @Nombre";
                    SqlCommand cmd = new SqlCommand(query, conex);
                    cmd.Parameters.AddWithValue("@Nombre", _nombre);
                    conex.Open();
                    // Ejecutamos la consulta y retornamos el resultado
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
