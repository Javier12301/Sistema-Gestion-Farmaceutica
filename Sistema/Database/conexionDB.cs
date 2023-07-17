using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace Sistema.Database
{
    public class conexionDB
    {
        // Conexión a la Base de Datos utilizando patrón singleton
        private static conexionDB _instance = null;
        private string _connectionString;

        // Constructor protected para que no se pueda instanciar desde fuera
        protected conexionDB()
        {
                _connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;                                      
        }

        // Método para obtener la instancia de la clase
        public static conexionDB getInstance()
        {
            if (_instance == null)
            {
                _instance = new conexionDB();
            }
            return _instance;
        }

        //Método para obtener la cadena de conexión
        public string getConnectionString()
        {
            return _connectionString;
        }        

    }
}
