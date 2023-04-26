using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            //Carga todos los componentes
            InitializeComponent();

            //Centraliza la ventana
            this.CenterToScreen();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            Create createform = new Create();
            
            //Crea evento: Si este formulario cierra, el formulario menu cierra
            createform.FormClosing += (s, a) => this.Close();

            //Inicializa la formula de crear y esconde el menu
            createform.Show();
            this.Hide();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            Read readform = new Read();

            //Crea evento: Si este formulario cierra, el formulario menu cierra
            readform.FormClosing += (s, a) => this.Close();

            //Inicializa la formula de crear y esconde el menu
            readform.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Update updateform = new Update();

            //Crea evento: Si este formulario cierra, el formulario menu cierra
            updateform.FormClosing += (s, a) => this.Close();

            //Inicializa la formula de crear y esconde el menu
            updateform.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Delete deleteform = new Delete();

            //Crea evento: Si este formulario cierra, el formulario menu cierra
            deleteform.FormClosing += (s, a) => this.Close();

            //Inicializa la formula de crear y esconde el menu
            deleteform.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            Close();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            Add addform = new Add();

            //Crea evernto: Si este formulario cierra, el formulario menu cierra
            addform.FormClosing += (s, a) => this.Close();

            //Inicializa la formula de crear y esconde el menu
            addform.Show();
            this.Hide();
        }
    }
}
