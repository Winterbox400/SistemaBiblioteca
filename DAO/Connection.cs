using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAO
{
    public class Connection
    {
        //Propiedades para realizar la conexion
        private readonly static string Server = "WINTERBOX400\\SQL2022";
        private readonly static string Database = "BD_ControlBiblioteca";
        private readonly static string User = "sa";
        private readonly static string Password = "1234";
        private readonly string connectionString = $"Server={Server};Database={Database};User Id={User};Password={Password};";

        //Clase para obtener la conexion
        public async Task<SqlConnection> GetConexionAsync()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                return connection;
            } catch (SqlException ex)
            {
                Console.WriteLine($"Hubo un error al conectarse a la base de datos\n");
                Console.WriteLine($"Codigo de error: {ex.ErrorCode}");
                return null;
            }
        }
    }
}
