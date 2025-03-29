using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging;
using Microsoft.Data.SqlClient;


namespace DAO
{
    public class Connection
    {
        // Propiedades para realizar la conexión
        private readonly static string Server = "WINTERBOX400\\SQL2022";
        private readonly static string Database = "BD_ControlBiblioteca";
        private readonly static string User = "sa";
        private readonly static string Password = "1234";
        //private readonly string connectionString = $"Server={Server}; Database={Database}; User Id={User}; Password={Password};TrustServerCertificate=True";

        public static string ConexionString(bool SqlAuthentication = true)
        {
            SqlConnectionStringBuilder conn = new();
            conn.ApplicationName = "MySystem";
            conn.IntegratedSecurity = !SqlAuthentication;
            conn.DataSource = Server;
            conn.InitialCatalog = Database;
            conn.TrustServerCertificate = true;

            if (SqlAuthentication)
            {
                conn.UserID = User;
                conn.Password = Password;
            }
            return conn.ConnectionString;
        }

        public static bool ValidarRegistro(int ID)
        {
            if (ID > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //public SqlConnection conn;

        //// Constructor
        //public Connection()
        //{
        //    conn = new SqlConnection(connectionString);
        //}

        //// Método para abrir la conexión
        //public void abrir()
        //{
        //    try
        //    {
        //        if (conn.State == System.Data.ConnectionState.Closed)
        //        {
        //            conn.Open();
        //            Console.WriteLine("Conexión abierta correctamente.");
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine("Error al abrir la conexión: " + ex.Message);
        //    }
        //}

        //// Método para cerrar la conexión
        //public void cerrar()
        //{
        //    if (conn.State == System.Data.ConnectionState.Open)
        //    {
        //        conn.Close();
        //    }
        //}

        //// Implementación del método Dispose de IDisposable
        //public void Dispose()
        //{
        //    // Cerramos la conexión si está abierta y liberamos los recursos
        //    if (conn != null)
        //    {
        //        if (conn.State == System.Data.ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //        conn.Dispose();
        //    }
        //    GC.SuppressFinalize(this); // Suprime la finalización
        //}

        //// Finalizador (destructor) para asegurar que la conexión se cierre si Dispose no fue llamado.
        //~Connection()
        //{
        //    Dispose();
        //}
    }
}












//{
//    private SqlConnection conexion;
//    //Propiedades para realizar la conexion
//    private readonly static string Server = "WINTERBOX400\\SQL2022";
//    private readonly static string Database = "BD_ControlBiblioteca";
//    private readonly static string User = "sa";
//    private readonly static string Password = "1234";
//    private readonly string connectionString = $"Server={Server}; Database={Database}; User Id={User}; Password={Password};";

//    public void ObtenerConexion()
//    {
//        try
//        {
//            conexion = new SqlConnection(connectionString);
//            conexion.Open();
//        }
//        catch(SqlException ex)
//        {
//            Console.WriteLine(ex.Message);
//            Console.WriteLine(ex.ErrorCode);
//            Console.WriteLine(ex.Errors);
//        }
//    }

//    public SqlConnection getConexion()
//    {
//        return conexion;
//    }


//    private SqlConnection conexion;

//    // Método para configurar la conexión
//    public void ConectarBD()
//    {
//        string cadenaConexion = "Server=WINTERBOX400\\SQL2022; Database=BD_ControlBiblioteca; User Id=sa; Password=1234;";
//        conexion = new SqlConnection(cadenaConexion);
//    }

//    // Método para abrir la conexión
//    public void AbrirConexion()
//    {
//        try
//        {
//            if (conexion != null && conexion.State == System.Data.ConnectionState.Closed)
//            {
//                conexion.Open();
//                Console.WriteLine("Conexión abierta correctamente.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error al abrir la conexión: " + ex.Message);
//        }
//    }

//    // Método para cerrar la conexión
//    public void CerrarConexion()
//    {
//        try
//        {
//            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
//            {
//                conexion.Close();
//                Console.WriteLine("Conexión cerrada correctamente.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
//        }
//    }
//}



//Propiedades para realizar la conexion
//private readonly static string Server = "WINTERBOX400\\SQL2022";
//private readonly static string Database = "BD_ControlBiblioteca";
//private readonly static string User = "sa";
//private readonly static string Password = "1234";
//private readonly string connectionString = "Server=WINTERBOX400\\SQL2022; Database=BD_ControlBiblioteca; User Id=sa; Password=1234;";

//Clase para obtener la conexion
//public void GetConexion()
//{
//    SqlConnection connection = new SqlConnection(connectionString);
//    try
//    {

//        connection.Open();
//    }
//    catch (SqlException ex)
//    {
//        Console.WriteLine($"Hubo un error al conectarse a la base de datos\n");
//        Console.WriteLine($"Mensaje de error: {ex.Message}");
//        Console.WriteLine($"Código de error: {ex.ErrorCode}");
//    }
//    //}
//}


////Clase para obtener la conexion Asincronamente
//public async Task<SqlConnection> GetConexionAsync()
//{
//    try
//    {
//        var connection = new SqlConnection(connectionString);
//        await connection.OpenAsync();
//        return connection;
//    }
//    catch (SqlException ex)
//    {
//        Console.WriteLine($"Hubo un error al conectarse a la base de datos\n");
//        Console.WriteLine($"Codigo de error: {ex.ErrorCode}");
//        return null;
//    }
//}








//// Método corregido para validar si existe un usuario administrador
//public bool Verdadero()
//{
//    try
//    {
//        abrir(); // Aseguramos que la conexión esté abierta

//        using (SqlCommand comm = new SqlCommand("EXEC Sp_ValideAdmin", conn))
//        {
//            object obj = comm.ExecuteScalar();
//            int resultado = obj != null ? Convert.ToInt32(obj) : 0;

//            return resultado > 0;
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Error en ExecuteScalar: " + ex.Message);
//        return false;
//    }
//    finally
//    {
//        cerrar(); // Cerramos la conexión después de usarla
//    }
//}