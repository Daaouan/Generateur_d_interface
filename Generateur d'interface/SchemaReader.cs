using System;
using System.Data.SqlClient;
using System.Data;


namespace Generateur_d_interface
{
    public class SchemaReader
    {
        private string _connectionString;

        public SchemaReader(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetTables()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");
                return schema;
            }
        }

        public DataTable GetColumns(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Columns", new[] { null, null, tableName, null });
                return schema;
            }
        }
    }
}
