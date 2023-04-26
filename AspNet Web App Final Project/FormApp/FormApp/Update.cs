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
    public partial class Update : Form
    {
        public Update()
        {
            //Inicializa los componentes
            InitializeComponent();

            //Centraliza la ventana
            this.CenterToScreen();
        }

        private void bntsearch_Click(object sender, EventArgs e)
        {
            string tablename = txttablename.Text;
            int id = Convert.ToInt32(txtid.Text);
            
            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Establece una conexion
                Program.SQLiteConnection = new SQLiteConnection(Program.ProductFile());
                Program.SQLiteConnection.Open();

                //Prepara un query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = $"SELECT * FROM {tablename} WHERE ID='{id}'";

                //Ejecuta el query
                Program.SQLiteDataReader = Program.SQLiteCommand.ExecuteReader();

                //Se ejecuta si lee algo
                if (Program.SQLiteDataReader.Read())
                {
                    txtname.Text = Program.SQLiteDataReader.GetString(1);
                    txtprice.Text = Program.SQLiteDataReader.GetString(2);
                    txtquantity.Text= Convert.ToString(Program.SQLiteDataReader.GetInt32(3));
                    txtdescription.Text = Program.SQLiteDataReader.GetString(4);
                }
                //Cierra la conexion
                Program.SQLiteDataReader.Close();
                Program.SQLiteConnection.Close();
            }
            //Se ejecuta si hubo un error en la ejecucion try
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string tablename = txttablename.Text, name=txtname.Text, price=txtprice.Text, desc=txtdescription.Text;
            int id = Convert.ToInt32(txtid.Text), quant= Convert.ToInt32(txtquantity.Text);

            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Establece una conexion
                Program.SQLiteConnection = new SQLiteConnection(Program.ProductFile());
                Program.SQLiteConnection.Open();

                //Prepara el query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = 
                    $"UPDATE {tablename} " +
                    $"SET NAME ='{name}', PRICE='{price}', QUANTITY='{quant}', DESCRIPTION='{desc}' " +
                    $"WHERE ID='{id}'";

                //Ejecuta el query
                Program.SQLiteCommand.ExecuteNonQuery();

                //Cierra la conexion
                Program.SQLiteConnection.Close();

                //Imprime un mensaje
                MessageBox.Show("--Product updated");
            }
            //Se ejecuta si hubo un error en la ejecucion try
            catch (Exception ex)
            {
                //Imprime un mensaje
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            //Muestra el menu
            Menu menu = new Menu();
            menu.Show();

            //Crea evento: si menu cierra, cierra este formulario
            menu.FormClosing += (s, a) => this.Close();

            //Esconde el formulario
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string tablename = txttablename.Text;
            int id = Convert.ToInt32(txtid.Text);

            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Establece una conexion
                Program.SQLiteConnection = new SQLiteConnection(Program.ProductFile());
                Program.SQLiteConnection.Open();

                //Prepara el query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = $"DELETE FROM {tablename} WHERE ID='{id}'";

                //Ejecuta el query
                Program.SQLiteCommand.ExecuteNonQuery();

                //Cierra la conexiones
                Program.SQLiteConnection.Close();

                //Imprime un mensaje
                MessageBox.Show("--Product deleted");
            }
            //Se ejecuta si hubo un error en la ejecucion try
            catch (Exception ex)
            {
                //Imprime un mensaje
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
