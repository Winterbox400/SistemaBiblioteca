using System;
using System.Windows.Forms;
using DAO;

namespace GUI.Movimientos
{
    public partial class MovimientosForm : Form
    {
        public MovimientosForm()
        {
            InitializeComponent();
        }
        /*
         Este formulario es para registrar los movimientos de los libros en el sistema, como el ingreso o salida de libros tambien Se seleccionan los libros, el tipo de movimiento y otros detalles al darle al botón de registrar, se valida la información y se guarda en la base de datos. Después de guardar, los campos se limpian para registrar nuevos movimientos si es necesario.

         */

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var movimiento = new Movimientos()
            {
                IdPrestamo = Convert.ToInt32(CmbPrestamo.SelectedValue),
                TipoMovimiento = TxtTipoMovimiento.Text,
                FechaMovimiento = DtpFechaMovimiento.Value
            };

            if (string.IsNullOrEmpty(movimiento.TipoMovimiento))
            {
                MessageBox.Show("Por favor ingrese el tipo de movimiento.");
                return;
            }

            int id = DAL_Movimientos.Insert(movimiento);
            MessageBox.Show($"Movimiento registrado con ID: {id}");

            DtpFechaMovimiento.Value = DateTime.Now;
            TxtTipoMovimiento.Clear();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            int idMovimiento = Convert.ToInt32(TxtIdMovimiento.Text);

            var movimiento = new Movimientos()
            {
                IdMovimiento = idMovimiento,
                IdPrestamo = Convert.ToInt32(CmbPrestamo.SelectedValue),
                TipoMovimiento = TxtTipoMovimiento.Text,
                FechaMovimiento = DtpFechaMovimiento.Value
            };

            DAL_Movimientos.Update(movimiento);
            MessageBox.Show($"Movimiento con ID {idMovimiento} actualizado.");

            DtpFechaMovimiento.Value = DateTime.Now;
            TxtTipoMovimiento.Clear();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int idMovimiento = Convert.ToInt32(TxtIdMovimiento.Text);

            DAL_Movimientos.Delete(idMovimiento);
            MessageBox.Show($"Movimiento con ID {idMovimiento} eliminado.");

            TxtIdMovimiento.Clear();
            TxtTipoMovimiento.Clear();
        }

        private void MovimientosForm_Load(object sender, EventArgs e)
        {
            var movimientos = DAL_Movimientos.GetAll();
            DgvMovimientos.DataSource = movimientos;
        }
    }
}

