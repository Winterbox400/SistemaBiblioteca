using System;
using System.Windows.Forms;
using DAO;

namespace GUI.Sucursales
{
    public partial class SucursalesForm : Form
    {
        public SucursalesForm()
        {
            InitializeComponent();
        }
        /*
         Este formulario es para gestionar las sucursales de la biblioteca, se escribe el nombre de la sucursal y 
        al darle al boton de registrar, validamos que no este vacío se guarda en la base de datos. Despues
        los campos se limpian para que se puedan registrar otras sucursales si es necesario.
         */

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var sucursal = new Sucursales()
            {
                Nombre = TxtNombre.Text,
                Direccion = TxtDireccion.Text,
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

            if (string.IsNullOrEmpty(sucursal.Nombre))
            {
                MessageBox.Show("Por favor ingrese el nombre de la sucursal.");
                return;
            }

            int id = DAL_Sucursales.Insert(sucursal);
            MessageBox.Show($"Sucursal registrada con ID: {id}");

            TxtNombre.Clear();
            TxtDireccion.Clear();
            ChkActivo.Checked = true;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            int idSucursal = Convert.ToInt32(TxtIdSucursal.Text);

            var sucursal = new Sucursales()
            {
                IdSucursal = idSucursal,
                Nombre = TxtNombre.Text,
                Direccion = TxtDireccion.Text,
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

            DAL_Sucursales.Update(sucursal);
            MessageBox.Show($"Sucursal con ID {idSucursal} actualizada.");

            TxtNombre.Clear();
            TxtDireccion.Clear();
            ChkActivo.Checked = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int idSucursal = Convert.ToInt32(TxtIdSucursal.Text);

            DAL_Sucursales.Delete(idSucursal);
            MessageBox.Show($"Sucursal con ID {idSucursal} eliminada.");

            TxtIdSucursal.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            ChkActivo.Checked = true;
        }

        private void SucursalesForm_Load(object sender, EventArgs e)
        {
            var sucursales = DAL_Sucursales.GetAll();
            DgvSucursales.DataSource = sucursales;
        }
    }
}
