
using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public abstract class Conexion
    {
        private readonly string connectionString;

        // Constructor de la clase conexion
        public Conexion()
        {
            connectionString = "Server=PC01\\SQLEXPRESSTEST;Initial Catalog=GesotecDB;Persist Security Info=True;User ID=admingst;Password=admin123";           
        }

        // Cierra la Conecion con la base de datos
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
