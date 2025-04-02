using System;
using System.Windows.Forms;
using DAO;
using System.Security.Cryptography;
using System.Text;

namespace GUI.Usuarios
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios()
            {
                Nombre = TxtNombre.Text,
                Correo = TxtCorreo.Text,
                Password = EncryptPassword(TxtPassword.Text),
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

            if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Correo) || string.IsNullOrEmpty(usuario.Password))
            {
                MessageBox.Show("Por favor ingrese todos los campos requeridos.");
                return;
            }

            int id = DAL_Usuarios.Insert(usuario);
            MessageBox.Show($"Usuario registrado con ID: {id}");

            ClearFields();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtIdUsuario.Text, out int idUsuario))
            {
                MessageBox.Show("Por favor ingrese un ID de usuario válido.");
                return;
            }

            var usuario = new Usuarios()
            {
                IdUsuario = idUsuario,
                Nombre = TxtNombre.Text,
                Correo = TxtCorreo.Text,
                Password = EncryptPassword(TxtPassword.Text),
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

            DAL_Usuarios.Update(usuario);
            MessageBox.Show($"Usuario con ID {idUsuario} actualizado.");

            ClearFields();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtIdUsuario.Text, out int idUsuario))
            {
                MessageBox.Show("Por favor ingrese un ID de usuario válido.");
                return;
            }

            DAL_Usuarios.Delete(idUsuario);
            MessageBox.Show($"Usuario con ID {idUsuario} eliminado.");

            ClearFields();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            var usuarios = DAL_Usuarios.GetAll();
            DgvUsuarios.DataSource = usuarios;
        }

        private void ClearFields()
        {
            TxtIdUsuario.Clear();
            TxtNombre.Clear();
            TxtCorreo.Clear();
            TxtPassword.Clear();
            ChkActivo.Checked = true;
        }

        private string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return password;

            using (var sha256 = SHA256.Create())
            {
                byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var builder = new StringBuilder();
                foreach (var byteData in data)
                {
                    builder.Append(byteData.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

