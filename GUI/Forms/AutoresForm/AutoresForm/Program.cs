using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using DAO; // Usando el DAL para los Autores

namespace GUI.Autores
{
    public partial class AutoresForm : Form
    {
        public AutoresForm()
        {
            InitializeComponent();
        }
        /*En este formulario gestionamos los autores de los libros, Se escribe el nombre del autor y, 
         * al darle al botón de registrar, validamos que no esté vacío y lo guardamos en la base de datos. 
         * Después, los campos se limpian para poder registrar más autores si es necesario.*/


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var autor = new Autores()
            {
                Nombre = TxtNombre.Text,
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };
            if (string.IsNullOrEmpty(autor.Nombre))
            {
                MessageBox.Show("Por favor ingrese el nombre del autor.");
                return;
            }

      
            int id = DAL_Autores.Insert(autor);
            MessageBox.Show($"Autor registrado con ID: {id}");

          
            TxtNombre.Clear();
            ChkActivo.Checked = true;
        }

        /*Estuve iontentando hacer m,anero de errores y validaciones la entrada de los datos pero no supe como xd
         en caso de que se hagan validaciones me decis*/
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            
            int idAutor = Convert.ToInt32(TxtIdAutor.Text); 
            // Supongamos que se tiene un TextBox para el ID

            var autor = new Autores()
            {
                IdAutor = idAutor,
                Nombre = TxtNombre.Text,
                Activo = ChkActivo.Checked ? (byte)1 : (byte)0
            };

      
            if (string.IsNullOrEmpty(autor.Nombre))
            {
                MessageBox.Show("Por favor ingrese el nombre del autor.");
                return;
            }

            
            DAL_Autores.Update(autor);
            MessageBox.Show($"Autor con ID {idAutor} actualizado.");

            TxtNombre.Clear();
            ChkActivo.Checked = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
          
            int idAutor = Convert.ToInt32(TxtIdAutor.Text);

           
            DAL_Autores.Delete(idAutor);
            MessageBox.Show($"Autor con ID {idAutor} eliminado.");

        
            TxtIdAutor.Clear();
            TxtNombre.Clear();
            ChkActivo.Checked = true;
        }

        private void AutoresForm_Load(object sender, EventArgs e)
        {
         
            var autores = DAL_Autores.GetAll();
            DgvAutores.DataSource = autores;
        }
    }
}

