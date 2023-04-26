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
    public partial class Read : Form
    {
        public Read()
        {
            //Inicializa el componente
            InitializeComponent();

            //Centraliza la ventana
            this.CenterToScreen();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txttablename.Text;

            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Borra la lista
                Productlist.Items.Clear();

                //Establece una conexion
                Program.SQLiteConnection = new SQLiteConnection(Program.ProductFile());
                Program.SQLiteConnection.Open();

                //Prepara el query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = $"SELECT ID, NAME FROM {name}";

                //Se leera el resultado del query en modo de lectura
                Program.SQLiteDataReader = Program.SQLiteCommand.ExecuteReader();
                
                //Se ejecuta mientras lea algun dato
                while (Program.SQLiteDataReader.Read())
                {
                    //Anade en la lista
                    Productlist.Items.Add(Program.SQLiteDataReader.GetString(1));
                }
                //Cierre de conexion
                Program.SQLiteDataReader.Close();
                Program.SQLiteConnection.Close();
            }
            //Se ejecuta si hubo un error en la ejecucion try
            catch (Exception ex)
            {
                //Imprime un mensaje
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void Productlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablename = txttablename.Text;
            int index = Productlist.SelectedIndex + 1;
            try
            {
                //Establece una conexion
                Program.SQLiteConnection = new SQLiteConnection(Program.ProductFile());
                Program.SQLiteConnection.Open();

                //Prepara el query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = $"SELECT * FROM {tablename} WHERE ID='{index}'";
                
                //Ejecuta el query
                Program.SQLiteDataReader = Program.SQLiteCommand.ExecuteReader();
                
                //Se ejecuta si lee algun dato
                if (Program.SQLiteDataReader.Read())
                {
                    lbid.Text = Convert.ToString(Program.SQLiteDataReader.GetInt32(0));
                    lbname.Text = Program.SQLiteDataReader.GetString(1);
                    lbprice.Text = Program.SQLiteDataReader.GetString(2);
                    lbquantity.Text = Convert.ToString(Program.SQLiteDataReader.GetInt32(3));
                    txtdescription.Text = Program.SQLiteDataReader.GetString(4);
                    lbsumstar.Text = Convert.ToString(Program.SQLiteDataReader.GetInt32(5));
                    lbnumstar.Text = Convert.ToString(Program.SQLiteDataReader.GetInt32(6));
                    lbreviewstar.Text = Convert.ToString(Program.SQLiteDataReader.GetInt32(7));
                }
                //Cierra la conexion
                Program.SQLiteDataReader.Close();
                Program.SQLiteConnection.Close();
            }
            catch (Exception ex) 
            {
                //Imprime un mensaje
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            //Muesta el menu
            Menu menu = new Menu();
            menu.Show();

            //Crea evento: si menuform cierra, cierra este formulario
            menu.FormClosing += (s, a) => this.Close();

            //Esconde el formulario
            this.Hide();
        }
    }
}
