using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Sistema.Database.Modelo;



namespace Sistema.Database.Logica
{

    public class CategoriaLogica
    {
        public bool agregarCategoria(Categoria categoria)
        {
            using (SqlConnection conex = new SqlConnection())
            {   
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();
                string query = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                // Ejecutamos el comando
                cmd.ExecuteNonQuery();
            }
              return true; // Operación exitosa
        }

        public bool modificarCategoria(Categoria categoria)
        {
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();

                string query = "UPDATE Categorias SET Nombre = @Nombre, Descripcion = @Descripcion WHERE CategoriaID = @CategoriaID";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@Id_Categoria", categoria.CategoriaID);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                // Ejecutamos el comando
                int rowAfectadas = cmd.ExecuteNonQuery();
                return rowAfectadas > 0; // Operación exitosa si se afectó alguna fila
            }
        }

        public bool eliminarCategoria(int CategoriaID)
        {
            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                conex.Open();

                string query = "DELETE FROM Categorias WHERE CategoriaID = @Id_Categoria";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@Id_Categoria", CategoriaID);

                // Se ejecuta el comando
                // ExecuteNonQuery devuelve el número de filas afectadas
                int rowAfectadas = cmd.ExecuteNonQuery();
                return rowAfectadas > 0; //
            }
        }



        public List<Categoria> obtenerCategoria()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection conex = new SqlConnection())
            {
                conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                string query = "SELECT * FROM Categorias";
                SqlCommand cmd = new SqlCommand(query, conex);
                conex.Open();

                // Ejecutamos el comando y obtenemos el resultado de la consulta
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Mientras se pueda leer el resultado de la consulta
                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria();
                        categoria.CategoriaID = reader.GetInt32(0);
                        categoria.Nombre = reader.GetString(1);
                        categoria.Descripcion = reader.GetString(2);

                        // Agregamos el objeto a la lista
                        categorias.Add(categoria);
                    }
                }              
            }
            return categorias;
        }

        // Obtener cantidad total de categorias
        public int obtenerCantidadCategorias()
        {
            try
            {
                using(SqlConnection conex = new SqlConnection())
                {
                    conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                    string query = "SELECT COUNT(*) FROM Categorias";
                    SqlCommand cmd = new SqlCommand(query, conex);
                    conex.Open();

                    // Ejecutamos el comando y obtenemos el resultado de la consulta
                    return (int)cmd.ExecuteScalar();
                }

            }catch(SqlException)
            {
                throw;
            }
        }

        // Obtener nombres de categorias
        public List<string> obtenerNombresCategorias()
        {
            List<string> nombresCategorias = new List<string>();
            try
            {
                using(SqlConnection conex = new SqlConnection())
                {
                    conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                    string query = "SELECT Nombre FROM Categorias";
                    SqlCommand cmd = new SqlCommand(query, conex);
                    conex.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string nombreCategoria = reader.GetString(0);
                            nombresCategorias.Add(nombreCategoria);
                        }
                    }
                }

            }catch(SqlException)
            {
                throw;
            }
            return nombresCategorias;
        }

        // Obtener ID de categoria por nombre
        public int obtenerIDCategoriaPorNombre(string nombreCategoria)
        {
            try
            {
                using(SqlConnection conex = new SqlConnection())
                {
                    conex.ConnectionString = conexionDB.getInstance().getConnectionString();
                    string query = "SELECT CategoriaID FROM Categorias WHERE Nombre = @Nombre";
                    SqlCommand cmd = new SqlCommand(query, conex);
                    cmd.Parameters.AddWithValue("@Nombre", nombreCategoria);
                    conex.Open();
                    // Ejecutamos el comando y obtenemos el resultado de la consulta
                    return (int)cmd.ExecuteScalar();
                }
            }catch(SqlException)
            {
                throw;
            }
        }

    }
}
