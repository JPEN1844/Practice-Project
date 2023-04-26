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
    public partial class Add : Form
    {
        public Add()
        {
            //Inicializa los componentes
            InitializeComponent();

            //Centraliza la ventana
            this.CenterToScreen();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string tablename = txttablename.Text, name = txtname.Text, price = txtprice.Text, desc = txtdescription.Text;
            int quant = Convert.ToInt32(txtquantity.Text), maxid = 0;
            
            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Establece una conexion
                Program.SQLiteConnection = new SQLiteConnection(Program.ProductFile());
                Program.SQLiteConnection.Open();

                //Prepara un query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = $"SELECT ID FROM {tablename} WHERE ID=(SELECT MAX(ID) FROM {tablename})";

                //Ejecuta el query en modo de lectura
                Program.SQLiteDataReader = Program.SQLiteCommand.ExecuteReader();

                //Se ejecuta si lee un dato
                if (Program.SQLiteDataReader.Read())
                {
                    maxid = Convert.ToInt32(Program.SQLiteDataReader.GetInt32(0));
                }
                //Cierre de conexion
                Program.SQLiteDataReader.Close();

                //Prepara un query
                Program.SQLiteCommand.CommandText = 
                    $"INSERT INTO {tablename}" +
                    $"(ID, NAME, PRICE, QUANTITY, DESCRIPTION, SUMSTAR, NUMBERSTAR, REVIEWSTARS) " +
                    $"VALUES (@ID, @NAME, @PRICE, @QUANTITY, @DESC, @SUMSTAR, @NUMSTAR, @REVIEWSTARS)";
                Program.SQLiteCommand.Parameters.AddWithValue("@ID", maxid + 1);
                Program.SQLiteCommand.Parameters.AddWithValue("@NAME", name);
                Program.SQLiteCommand.Parameters.AddWithValue("@PRICE", price);
                Program.SQLiteCommand.Parameters.AddWithValue("@QUANTITY", quant);
                Program.SQLiteCommand.Parameters.AddWithValue("@DESC", desc);
                Program.SQLiteCommand.Parameters.AddWithValue("@SUMSTAR", 0);
                Program.SQLiteCommand.Parameters.AddWithValue("@NUMSTAR", 0);
                Program.SQLiteCommand.Parameters.AddWithValue("@REVIEWSTARS", 0);
                Program.SQLiteCommand.Prepare();

                //Ejecuta el query
                Program.SQLiteCommand.ExecuteNonQuery();

                //Cierra de conexion
                Program.SQLiteConnection.Close();

                //Imprime un mensaje
                MessageBox.Show("--Product added--");
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

            //Esconde este formulario
            this.Hide();
        }
    }
}
