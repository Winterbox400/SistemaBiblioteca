using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAO.ValideQuery
{
    public class ValideQueryBLL
    {
        public bool ValidarExisteAdmin()
        {
            //DAO.Connection conexion = new DAO.Connection();
            try
            {
                SqlConnection conexion = new SqlConnection(Connection.ConexionString());
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Sp_ValideAdmin", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@parametro", "valor");
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conexion.Close();
                conexion.Dispose();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ExecuteScalar: " + ex.Message);
                return false;
            }
            finally
            {
                //conexion.cerrar(); // Nos aseguramos de cerrar la conexión al finalizar
            }
        }
    }
}
