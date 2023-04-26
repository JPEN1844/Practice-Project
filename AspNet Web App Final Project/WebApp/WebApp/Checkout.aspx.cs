using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
namespace WebApp
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string table = Request.QueryString["table"];
            string id = Request.QueryString["productid"];
            string quant = Request.QueryString["quant"];
            SQLiteConnection liteConnection = new SQLiteConnection(@"URI=file:D:/product.db");
            liteConnection.Open();
            SQLiteCommand liteCommand = new SQLiteCommand(liteConnection);
            liteCommand.CommandText = $"SELECT NAME, PRICE FROM {table} WHERE ID='{id}'";
            SQLiteDataReader dataReader = liteCommand.ExecuteReader();
            if (dataReader.Read())
            {
                Productname.Text = dataReader.GetString(0);
                Productprice.Text = "$" + dataReader.GetString(1);
                Productquant.Text = quant;
                double total = Convert.ToInt32(dataReader.GetString(1)) * Convert.ToDouble(quant);
                Totalcost.Text = "$" + Convert.ToString(total);
            }
            else
            {
                dataReader.Close();
                liteConnection.Close();
                Response.Redirect("Errorpage.aspx");
            }
            dataReader.Close();
            liteConnection.Close();
        }

        protected void Paybtn_Click(object sender, EventArgs e)
        {
            string table = Request.QueryString["table"];
            string id = Request.QueryString["productid"];
            string quant = Request.QueryString["quant"];
            int newquant = Convert.ToInt32(quant);
            SQLiteConnection liteConnection = new SQLiteConnection(@"URI=file:D:/product.db");
            liteConnection.Open();
            SQLiteCommand liteCommand = new SQLiteCommand(liteConnection);
            liteCommand.CommandText = $"SELECT QUANTITY FROM {table} WHERE ID='{id}'";
            SQLiteDataReader dataReader = liteCommand.ExecuteReader();
            if (dataReader.Read())
            {
                newquant = dataReader.GetInt32(0) - Convert.ToInt32(quant);
            }
            else
            {
                dataReader.Close();
                liteConnection.Close();
                Response.Redirect("Errorpage.aspx");
            }
            dataReader.Close();
            liteCommand.CommandText = $"UPDATE {table} SET QUANTITY='{newquant}' WHERE ID='{id}'";
            liteCommand.ExecuteReader();
            liteConnection.Close();
            Response.Redirect($"Productpage.aspx?table={table}&productid={id}");
        }
    }
}