using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FormApp
{
    public partial class Create : Form
    {
        public Create()
        {
            //Inicializa los componentes
            InitializeComponent();

            //Centraliza la ventana
            this.CenterToScreen();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            
            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Establece conexion
                Program.SQLiteConnection = new SQLiteConnection(Program.ProductFile());
                Program.SQLiteConnection.Open();

                //Prepara el query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText=
                    $"CREATE TABLE {name} (" +
                    $"ID INTERGER PRIMARY KEY NOT NULL," +
                    $"NAME TEXT," +
                    $"PRICE TEXT," +
                    $"QUANTITY INTERGER," +
                    $"DESCRIPTION TEXT," +
                    $"SUMSTAR INTERGER," +
                    $"NUMBERSTAR INTERGER," +
                    $"REVIEWSTARS INTERGER)";

                //Ejecuta el query
                Program.SQLiteCommand.ExecuteNonQuery();

                //Cierra la conexion
                Program.SQLiteConnection.Close();

                //Imprime un mensaje
                MessageBox.Show("--Table added--");
            }
            //Se ejecuta si hubo un error en la ejecucion try
            catch (Exception ex)
            { 
                //Imprime un mensaje
                MessageBox.Show(Convert.ToString(ex)); 
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            //Muestra el formulario menu
            Menu menuform = new Menu();
            menuform.Show();

            //Crea evento: Si menuform cierra, cierra este formulario 
            menuform.FormClosing += (s, args) => this.Close();

            //Esconde el formulario
            this.Hide();
        }
    }
}
