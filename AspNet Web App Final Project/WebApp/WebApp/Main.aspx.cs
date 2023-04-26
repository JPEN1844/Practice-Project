using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace WebApp
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Tablelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablename = Tablelist.SelectedValue;
            try
            {
                SQLiteConnection liteConnection = new SQLiteConnection(@"URI=file:D:/product.db");
                SQLiteCommand liteCommand = new SQLiteCommand(liteConnection);
                liteConnection.Open();
                liteCommand.CommandText = $"SELECT * FROM {tablename}";
                SQLiteDataReader dataReader = liteCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    TableRow tableRow = new TableRow();
                    TableCell tableCell = new TableCell();
                    string hyper = "<a href=\"Productpage.aspx?productid=" + Convert.ToString(dataReader.GetInt32(0)) + "&table="+ tablename +"\">" + dataReader.GetString(1) + "</a>";
                    tableCell.Text = hyper + "<br />" + "$" + dataReader.GetString(2) + "<br />" + dataReader.GetInt32(3) + "QT" + "<br />" + dataReader.GetInt32(7) + "⭐";
                    tableRow.Cells.Add(tableCell);
                    Table1.Rows.Add(tableRow);
                }
                dataReader.Close();
                liteConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(Convert.ToString(ex));
            }
        }
    }
}