using System;
using System.Windows.Forms;
using DAO;

namespace GUI.Clientes
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        /*
         en este formulario se van a gestionar los clientes de la biblioteca, 
        Se escribe el nombre, correo, teléfono y otros datos del cliente, Al darle al boton de registrar, 
        se valida que los campos no estén vacíos y se guarda la información en la base de datos despues
        los campos se limpian para registrar más clientes si es necesario.

         */

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes()
            {
                Nombre = TxtNombre.Text,
                Direccion = TxtDireccion.Text,
                Telefono = TxtTelefono.Text,
                Email = TxtEmail.Text
            };

            if (string.IsNullOrEmpty(cliente.Nombre))
            {
                MessageBox.Show("Por favor ingrese el nombre del cliente.");
                return;
            }

            // segun vi se pueden agregar mensajes de confirmacion para evitar eliminaciones accidentales 
             

            int id = DAL_Clientes.Insert(cliente);
            MessageBox.Show($"Cliente registrado con ID: {id}");

            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(TxtIdCliente.Text);

            var cliente = new Clientes()
            {
                IdCliente = idCliente,
                Nombre = TxtNombre.Text,
                Direccion = TxtDireccion.Text,
                Telefono = TxtTelefono.Text,
                Email = TxtEmail.Text
            };

            DAL_Clientes.Update(cliente);
            MessageBox.Show($"Cliente con ID {idCliente} actualizado.");

            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(TxtIdCliente.Text);

            DAL_Clientes.Delete(idCliente);
            MessageBox.Show($"Cliente con ID {idCliente} eliminado.");

            TxtIdCliente.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            var clientes = DAL_Clientes.GetAll();
            DgvClientes.DataSource = clientes;
        }
    }
}

