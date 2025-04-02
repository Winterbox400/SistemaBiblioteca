using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using DAO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI.Editoriales
{
    public partial class EditorialesForm : Form
    {
        public EditorialesForm()
        {
            InitializeComponent();
        }

        /*formulario para gestionar las editoriales de los libros, Se escribe el nombre de la editorial y
         * al darle al botón de registrar, validamos que el campo no esté vacío y 
         * lo guardamos en la base de datos. Después, los campos se limpian para permitir el registro de otras editoriales.*/


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var editorial = new Editoriales()
            {
                Nombre = TxtNombre.Text,
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

            if (string.IsNullOrEmpty(editorial.Nombre))
            {
                MessageBox.Show("Por favor ingrese el nombre de la editorial.");
                return;
            }

            int id = DAL_Editoriales.Insert(editorial);
            MessageBox.Show($"Editorial registrada con ID: {id}");

            TxtNombre.Clear();
            ChkActivo.Checked = true;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            int idEditorial = Convert.ToInt32(TxtIdEditorial.Text);

            var editorial = new Editoriales()
            {
                IdEditorial = idEditorial,
                Nombre = TxtNombre.Text,
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

            if (string.IsNullOrEmpty(editorial.Nombre))
            {
                MessageBox.Show("Por favor ingrese el nombre de la editorial.");
                return;
            }

            DAL_Editoriales.Update(editorial);
            MessageBox.Show($"Editorial con ID {idEditorial} actualizada.");

            TxtNombre.Clear();
            ChkActivo.Checked = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int idEditorial = Convert.ToInt32(TxtIdEditorial.Text);

            DAL_Editoriales.Delete(idEditorial);
            MessageBox.Show($"Editorial con ID {idEditorial} eliminada.");

            TxtIdEditorial.Clear();
            TxtNombre.Clear();
            ChkActivo.Checked = true;
        }

        private void EditorialesForm_Load(object sender, EventArgs e)
        {
            var editoriales = DAL_Editoriales.GetAll();
            DgvEditoriales.DataSource = editoriales;
        }
    }
}

