using DAO;
using EL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {

            Autores Entidad = new Autores();
            Entidad.Nombre = TbUsuario.Text;
            if (Validate())
            {
                int ID = DAL_Autores.Insert(Entidad);
                MessageBox.Show(ID.ToString());
            }
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(TbUsuario.Text) || string.IsNullOrWhiteSpace(TbUsuario.Text))
            {
                MessageBox.Show("Ingrese el nombre del autor");
                return false;
            }
            return true;
        }
    }
}


