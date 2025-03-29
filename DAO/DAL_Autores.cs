using EL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class DAL_Autores
    {
        public static bool Insert(Autores Entidad)
        {
            SqlConnection conexion = new SqlConnection(Connection.ConexionString());
            conexion.Open();

            try
            {
                SqlCommand cmd = new("SPInsertAutores", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
                int ID = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                conexion.Close();
                conexion.Dispose();
                
                return Connection.ValidarRegistro(ID);
            }
            catch(SqlException ex)
            {
                return false;
            }
        }

        public static void Update(Autores Entidad)
        {
            SqlConnection conextion = new SqlConnection(Connection.ConexionString());
            conextion.Open();

                SqlCommand cmd = new("UpdateAutor", conextion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@IdAutor", Entidad.IdAutor);
                cmd.ExecuteScalar();
        }

        public static void Delete(Autores Entidad)
        {
            SqlConnection conextion = new(Connection.ConexionString());
            conextion.Open();

            SqlCommand cmd = new("DeleteAutor", conextion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdAutor", Entidad.IdAutor);
            cmd.ExecuteScalar();
        }
    }
}
