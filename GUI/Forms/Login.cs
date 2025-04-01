using DAL;
using DAO;
using EL;
using Microsoft.Data.SqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        bool Validate = DAL_Usuarios.ValidateUsuarioAdmin();

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                if (Validate)
                {
                    LbUsuario.Text = "Usuario";
                    LbUsuario.Location = new Point(149, 241);
                    TbUsuario.Location = new Point(257, 241);
                    LbNametag.Location = new Point(129, 293);
                    TbNametag.Location = new Point(257, 288);
                    LbPassword.Location = new Point(129, 339);
                    TbPassword.Location = new Point(257, 334);
                    LbNametag.Visible = true;
                    TbNametag.ReadOnly = false;
                    TbNametag.Visible = true;
                }
            }catch(SqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
        }

        //ZONA DE VALIDACIONES
        private byte[] GenerarHash(string contrasena)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
            }
        }
        private bool ValidateUsuarioNull()
        {
            if (string.IsNullOrEmpty(TbUsuario.Text) || string.IsNullOrWhiteSpace(TbUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre del autor");
                return false;
            }
            return true;
        }
        private bool ValidatePasswordNull()
        {
            if (string.IsNullOrEmpty(TbPassword.Text) || string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                MessageBox.Show("Ingrese la contraseña");
                return false;
            }
            return true;
        }
        private bool ValidateNametagNull()
        {
            if(string.IsNullOrEmpty(TbNametag.Text) || string.IsNullOrWhiteSpace(TbNametag.Text))
            {
                MessageBox.Show("Ingrese un Nametag");
                return false;
            }
            return true;
        }

        //ZONA DE BOTONES
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuarios Entidad = new Usuarios();
            if (Validate && ValidateUsuarioNull() && ValidatePasswordNull() && ValidateNametagNull())
            {
                Entidad.Nombre = Regex.Replace(TbUsuario.Text.Trim(), "[^a-zA-Z0-9 ]", "");
                Entidad.Nametag = Regex.Replace(TbNametag.Text.Trim(), "[^a-zA-Z0-9 ]", "");
                Entidad.Contraseña = GenerarHash(TbPassword.Text.Trim());
                Entidad.IdRol = 1;
                Entidad.IdUsuarioRegistra = 1;
                DAL_Usuarios.Insertar(Entidad);
                MessageBox.Show("El usuario fue introducido Exitosamente");
            }
            else if(!Validate && ValidateUsuarioNull() && ValidatePasswordNull())
            {
                Entidad.Nametag = Regex.Replace(TbUsuario.Text.Trim(), "[^a-zA-Z0-9 ]", "");
                Entidad.Contraseña = GenerarHash(TbPassword.Text.Trim());
                
                if (DAL_Usuarios.ValidateLogin(Entidad))
                {
                    MessageBox.Show("Ingresando a la APP");
                }
                else
                {
                    MessageBox.Show("El Usuario o la Contraseña no son validos");
                }
            }
        }
    }
}

/**Recordatorio
 * Realizar un par mas de validaciones en el sistema, la contraseña recorda quitarles eso de los caracteres
 * permiti los caracteres en las contraseñas
 * 
 */


