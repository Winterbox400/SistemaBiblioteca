using System;
using System.Windows.Forms;
using DAO;

namespace GUI.Libros
{
    public partial class LibrosForm : Form
    {
        public LibrosForm()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTitulo.Text) || string.IsNullOrEmpty(TxtISBN.Text) ||
                CmbAutor.SelectedIndex == -1 || CmbEditorial.SelectedIndex == -1 || CmbClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor ingrese todos los campos requeridos.");
                return;
            }

            var libro = new Libros()
            {
                Titulo = TxtTitulo.Text,
                IdAutor = Convert.ToInt32(CmbAutor.SelectedValue),
                IdEditorial = Convert.ToInt32(CmbEditorial.SelectedValue),
                FechaPublicacion = DtpFechaPublicacion.Value,
                IdClasificacion = Convert.ToInt32(CmbClasificacion.SelectedValue),
                ISBN = TxtISBN.Text,
                Ubicacion = TxtUbicacion.Text,
                IdUsuarioRegistro = ObtenerUsuarioActual()
            };

            int id = DAL_Libros.Insert(libro);
            MessageBox.Show($"Libro registrado con ID: {id}");
            LimpiarCampos();
            CargarLibros();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtIdLibro.Text, out int idLibro))
            {
                MessageBox.Show("Por favor ingrese un ID válido.");
                return;
            }

            var libro = new Libros()
            {
                IdLibro = idLibro,
                Titulo = TxtTitulo.Text,
                IdAutor = Convert.ToInt32(CmbAutor.SelectedValue),
                IdEditorial = Convert.ToInt32(CmbEditorial.SelectedValue),
                FechaPublicacion = DtpFechaPublicacion.Value,
                IdClasificacion = Convert.ToInt32(CmbClasificacion.SelectedValue),
                ISBN = TxtISBN.Text,
                Ubicacion = TxtUbicacion.Text
            };

            DAL_Libros.Update(libro);
            MessageBox.Show($"Libro con ID {idLibro} actualizado.");
            LimpiarCampos();
            CargarLibros();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtIdLibro.Text, out int idLibro))
            {
                MessageBox.Show("Por favor ingrese un ID válido.");
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Está seguro de que desea eliminar el libro con ID {idLibro}?",
                                                      "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                DAL_Libros.Delete(idLibro);
                MessageBox.Show($"Libro con ID {idLibro} eliminado.");
                LimpiarCampos();
                CargarLibros();
            }
        }

        private void LibrosForm_Load(object sender, EventArgs e)
        {
            CargarLibros();
            CargarCombos();
        }

        private void CargarLibros()
        {
            DgvLibros.DataSource = DAL_Libros.GetAll();
        }

        private void CargarCombos()
        {
            CmbAutor.DataSource = DAL_Autores.GetAll();
            CmbAutor.DisplayMember = "Nombre";
            CmbAutor.ValueMember = "IdAutor";

            CmbEditorial.DataSource = DAL_Editoriales.GetAll();
            CmbEditorial.DisplayMember = "Nombre";
            CmbEditorial.ValueMember = "IdEditorial";

            CmbClasificacion.DataSource = DAL_Clasificaciones.GetAll();
            CmbClasificacion.DisplayMember = "Descripcion";
            CmbClasificacion.ValueMember = "IdClasificacion";
        }

        private void LimpiarCampos()
        {
            TxtIdLibro.Clear();
            TxtTitulo.Clear();
            TxtISBN.Clear();
            TxtUbicacion.Clear();
            CmbAutor.SelectedIndex = -1;
            CmbEditorial.SelectedIndex = -1;
            CmbClasificacion.SelectedIndex = -1;
        }

        private int ObtenerUsuarioActual()
        {
            //obtener el ID del usuario que esta logueado en el sistema
            return 1;
        }
    }
}
