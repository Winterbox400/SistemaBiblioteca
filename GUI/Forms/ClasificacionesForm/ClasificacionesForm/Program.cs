using System;
using System.Windows.Forms;
using DAO;

namespace GUI.Clasificaciones
{
    public partial class ClasificacionesForm : Form
    {
        public ClasificacionesForm()
        {
            InitializeComponent();
        }
        /*aqui se van a clasificar los libros, Se escribe el nombre de la clasificación y, al presionar el botón de registrar, 
         * se valida que el campo no esté vacío y se guarda en la base de datos, Luego, los 
         * campos se limpian para registrar nuevas clasificaciones si fuera necesario.
*/

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var clasificacion = new Clasificaciones()
            {
                Clasificacion = TxtClasificacion.Text,
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

            if (string.IsNullOrEmpty(clasificacion.Clasificacion))
            {
                MessageBox.Show("Por favor ingrese una clasificación.");
                return;
            }

            int id = DAL_Clasificaciones.Insert(clasificacion);
            MessageBox.Show($"Clasificación registrada con ID: {id}");

            TxtClasificacion.Clear();
            ChkActivo.Checked = true;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            int idClasificacion = Convert.ToInt32(TxtIdClasificacion.Text);

            var clasificacion = new Clasificaciones()
            {
                IdClasificacion = idClasificacion,
                Clasificacion = TxtClasificacion.Text,
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

            if (string.IsNullOrEmpty(clasificacion.Clasificacion))
            {
                MessageBox.Show("Por favor ingrese una clasificación.");
                return;
            }

            DAL_Clasificaciones.Update(clasificacion);
            MessageBox.Show($"Clasificación con ID {idClasificacion} actualizada.");

            TxtClasificacion.Clear();
            ChkActivo.Checked = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int idClasificacion = Convert.ToInt32(TxtIdClasificacion.Text);

            DAL_Clasificaciones.Delete(idClasificacion);
            MessageBox.Show($"Clasificación con ID {idClasificacion} eliminada.");

            TxtIdClasificacion.Clear();
            TxtClasificacion.Clear();
            ChkActivo.Checked = true;
        }

        private void ClasificacionesForm_Load(object sender, EventArgs e)
        {
            var clasificaciones = DAL_Clasificaciones.GetAll();
            DgvClasificaciones.DataSource = clasificaciones;
        }
    }
}

