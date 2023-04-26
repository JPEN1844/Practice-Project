using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;

namespace FormApp
{
    static class Program
    {
        //Instrucciones get y set que se utilizara a travez de la aplicacion.
        public static string AdminFile() { return @"URI = file:D:\Adminlist.db"; }
        public static string ProductFile() { return @"URI=file:D:\product.db"; }
        public static SQLiteConnection SQLiteConnection { get; set; }
        public static SQLiteDataReader SQLiteDataReader { get; set; }
        public static SQLiteCommand SQLiteCommand { get; set; }
        public static bool loginconfirm { get; set; }

        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Login loginform = new Login();
            //Ejecuta la variable loginform
            Application.Run(loginform);

            //Si loginconfirm es cierto, el codigo se ejecuta
            if (loginconfirm)
            {
                Menu menuform = new Menu();
                //Ejecuta la variable menuform
                Application.Run(menuform);
            }
        }
    }
}
