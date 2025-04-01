using DAO;
using EL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Usuarios
    {
        public static void Insertar(Usuarios Entidad)
        {
            SqlConnection conn = new SqlConnection(Connection.ConexionString());
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("InsertUsuario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@NameTag", Entidad.Nametag);
                cmd.Parameters.AddWithValue("@Contraseña", Entidad.Contraseña);
                cmd.Parameters.AddWithValue("@IdRol", Entidad.IdRol);
                cmd.Parameters.AddWithValue("@IdUsuarioRegistro", Entidad.IdUsuarioRegistra);
                cmd.ExecuteScalar();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }catch(SqlException ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }
        }

        public static void Update(Usuarios Entidad, int CambiarPassword)
        {
            SqlConnection conn = new SqlConnection(Connection.ConexionString());
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("UpdateAutor", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", Entidad.IdUsuario);
                cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@Nametag", Entidad.Nametag);
                cmd.Parameters.AddWithValue("@Contraseña", Entidad.Contraseña);
                cmd.Parameters.AddWithValue("@IdRol", Entidad.IdRol);
                cmd.Parameters.AddWithValue("@IdUsuarioActualiza", Entidad.IdUsuarioActualiza);
                cmd.Parameters.AddWithValue("@CambiarPassword", CambiarPassword);
                cmd.ExecuteScalar();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }catch(SqlException ex)
            {
                throw new Exception("Error al cambiar el usuario en la base de datos: " + ex.Message);
            }
        }

        public static void Delete(Usuarios Entidad)
        {
            SqlConnection conn = new SqlConnection(Connection.ConexionString());
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("DeleteUsuario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", Entidad.IdUsuario);
                cmd.Parameters.AddWithValue("@IdUsuarioActualiza", Entidad.IdUsuarioActualiza);
                cmd.ExecuteScalar();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }catch(SqlException ex)
            {
                throw new Exception("Error al eliminar el Usuario en la base de datos: " + ex.Message);
            }
        }


        /**
         * Hacer un metodo que busque si hay usuarios en la base de datos y que devuelva un booleano
         * true si hay, false si no hay.
         * el metodo será capturado por una variable en el login, lo cual servira para el boton Ingresar
         * Si no habían usuarios se desplegara el metodo de mostrar el valor Nametag, etc. y de paso cambiará
         * este booleano a true para evitar un ciclo infinito.
         * Si hay usuarios simplemente se ingresará al programa y podremos ingresar nuestros usaurios y contraseña.
         */
        public static bool ValidateUsuarioAdmin()
        {
            int admin;
            SqlConnection conn = new SqlConnection(Connection.ConexionString());
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("ExistenciaUsuarioAdmin", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                admin = Convert.ToInt32(cmd.ExecuteScalar());

                if (admin == 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                    return true;
                }
                return false;
            }catch(SqlException ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }
        }

        public static bool ValidateLogin(Usuarios Entidad)
        {
            SqlConnection conn = new SqlConnection(Connection.ConexionString());
            conn.Open();
            byte[] Contraseña;
            try
            {
                SqlCommand cmd = new SqlCommand("ValidateLogin", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nametag", Entidad.Nametag);
                Contraseña = (byte[])cmd.ExecuteScalar();
                if(Contraseña != null)
                {
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                    bool ComprobarHash = Entidad.Contraseña.SequenceEqual(Contraseña);
                    return ComprobarHash;
                }
                return false;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error base de datos: " + ex.Message);
            }
        }
    }
}
