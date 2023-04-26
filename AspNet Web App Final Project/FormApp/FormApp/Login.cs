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
    public partial class Login : Form
    {
        public Login()
        {
            //Carga todo los componentes
            InitializeComponent();

            //Centraliza la ventana
            this.CenterToScreen();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text, password = txtpassword.Text;

            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Establece la conexion con la base de datos
                Program.SQLiteConnection = new SQLiteConnection(Program.AdminFile());
                Program.SQLiteConnection.Open();

                //Prepara el query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = $"SELECT 'USERNAME', 'PASSWORD' FROM ADMIN WHERE USERNAME='{username}' AND PASSWORD='{password}'";
                Program.SQLiteCommand.Prepare();

                //El resultado del query sera recibido en modo de lectura
                Program.SQLiteDataReader = Program.SQLiteCommand.ExecuteReader();

                //Si lee algo, ejecuta el codigo
                if (Program.SQLiteDataReader.Read())
                {
                    //Envia una condicion y cierra el formulario
                    Program.loginconfirm = true;
                    Close();
                }
                else
                {
                    //Imprime un mensaje
                    MessageBox.Show("--Error--\nUsuario no encontrado");
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text, password = txtpassword.Text;

            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Establece la conexion con la base de datos
                Program.SQLiteConnection = new SQLiteConnection(Program.AdminFile());
                Program.SQLiteConnection.Open();

                //Prepara el query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = $"INSERT INTO ADMIN (USERNAME, PASSWORD) VALUES (@USERNAME, @PASSWORD)";
                Program.SQLiteCommand.Parameters.AddWithValue("@USERNAME", username);
                Program.SQLiteCommand.Parameters.AddWithValue("@PASSWORD", password);
                Program.SQLiteCommand.Prepare();

                //Ejecuta el query
                Program.SQLiteCommand.ExecuteNonQuery();

                //Cierre de conexion
                Program.SQLiteConnection.Close();

                //Imprime un mensaje
                MessageBox.Show("--User added--");
            }
            //Se ejecuta si hubo un error en la ejecucion try
            catch (Exception ex)
            {
                //Imprime un mensaje
                MessageBox.Show(Convert.ToString(ex));
            }

        }
        private void btntable_Click(object sender, EventArgs e)
        {
            //Ejecuta hasta que se encuentre un error de sintax o de logica
            try
            {
                //Establece la conexion con la base de datos
                Program.SQLiteConnection = new SQLiteConnection(Program.AdminFile());
                Program.SQLiteConnection.Open();

                //Prepara el query
                Program.SQLiteCommand = new SQLiteCommand(Program.SQLiteConnection);
                Program.SQLiteCommand.CommandText = $"CREATE TABLE ADMIN(USERNAME TEXT, PASSWORD TEXT)";

                //Ejecuta el query
                Program.SQLiteCommand.ExecuteNonQuery();

                //Cierre de conexion
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
        private void btnexit_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            Close();
        }

        private void intbtn_Click(object sender, EventArgs e)
        {
            //Imprime un mensaje
            MessageBox.Show("Para utilizar este programa debe crear un tabla y anadir un usuario antes de entrar a la base de datos.\n\nOJO:\nSe la base de datos se guardara en la particion D:/");
        }
    }
}
