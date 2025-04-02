using System;
using System.Windows.Forms;
using DAO;

namespace GUI.Prestamos
{
    public partial class PrestamosForm : Form
    {
        public PrestamosForm()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var prestamo = new Prestamos()
            {
                IdCliente = Convert.ToInt32(CmbCliente.SelectedValue),
                IdLibro = Convert.ToInt32(CmbLibro.SelectedValue),
                FechaPrestamo = DtpFechaPrestamo.Value,
                FechaDevolucion = DtpFechaDevolucion.Value
            };

            if (prestamo.IdCliente == 0 || prestamo.IdLibro == 0)
            {
                MessageBox.Show("Por favor seleccione un cliente y un libro.");
                return;
            }

            int id = DAL_Prestamos.Insert(prestamo);
            MessageBox.Show($"Préstamo registrado con ID: {id}");

            DtpFechaPrestamo.Value = DateTime.Now;
            DtpFechaDevolucion.Value = DateTime.Now;
        }

        // se pudieran hacer mas validaciones pero aja, no me quiero enredar mas 
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            int idPrestamo = Convert.ToInt32(TxtIdPrestamo.Text);

            var prestamo = new Prestamos()
            {
                IdPrestamo = idPrestamo,
                IdCliente = Convert.ToInt32(CmbCliente.SelectedValue),
                IdLibro = Convert.ToInt32(CmbLibro.SelectedValue),
                FechaPrestamo = DtpFechaPrestamo.Value,
                FechaDevolucion = DtpFechaDevolucion.Value
            };

            DAL_Prestamos.Update(prestamo);
            MessageBox.Show($"Préstamo con ID {idPrestamo} actualizado.");

            DtpFechaPrestamo.Value = DateTime.Now;
            DtpFechaDevolucion.Value = DateTime.Now;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int idPrestamo = Convert.ToInt32(TxtIdPrestamo.Text);

            DAL_Prestamos.Delete(idPrestamo);
            MessageBox.Show($"Préstamo con ID {idPrestamo} eliminado.");

            TxtIdPrestamo.Clear();
            DtpFechaPrestamo.Value = DateTime.Now;
            DtpFechaDevolucion.Value = DateTime.Now;
        }

        private void PrestamosForm_Load(object sender, EventArgs e)
        {
            var prestamos = DAL_Prestamos.GetAll();
            DgvPrestamos.DataSource = prestamos;
        }
    }
}
