using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace WebApp
{
    public partial class Productpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["productid"];
            string table = Request.QueryString["table"];
            SQLiteConnection liteConnection = new SQLiteConnection(@"URI=file:D:/product.db");
            SQLiteCommand liteCommand = new SQLiteCommand(liteConnection);
            liteConnection.Open();
            liteCommand.CommandText = $"SELECT * FROM {table} WHERE ID='{id}'";
            SQLiteDataReader dataReader = liteCommand.ExecuteReader();
            if (dataReader.Read())
            {
                Productname.Text = dataReader.GetString(1);
                Productprice.Text ="$" + dataReader.GetString(2);
                Productquant.Text = Convert.ToString(dataReader.GetInt32(3)) + "QT";
                reviews.Text = Convert.ToString(dataReader.GetInt32(7)) + "⭐";
                Description.Text = dataReader.GetString(4);
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

        protected void buybtn_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["productid"];
            string table = Request.QueryString["table"];
            string quant = quantbuy.SelectedValue;
            Response.Redirect($"Checkout.aspx?table={table}&productid={id}&quant={quant}");
        }

        protected void userreviewbtn_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["productid"];
            string table = Request.QueryString["table"];
            int numstar = Convert.ToInt32(starsreview.SelectedValue);
            int totalstar = 1;
            int reviewstar = 0;
            bool prp = false;

            SQLiteConnection liteConnection = new SQLiteConnection(@"URI=file:D:/product.db");
            liteConnection.Open();
            SQLiteCommand liteCommand = new SQLiteCommand(liteConnection);
            liteCommand.CommandText = $"SELECT SUMSTAR, NUMBERSTAR FROM {table} WHERE ID='{id}'";
            SQLiteDataReader dataReader = liteCommand.ExecuteReader();
            if (dataReader.Read())
            {
                totalstar += dataReader.GetInt32(0);
                numstar += dataReader.GetInt32(1);
                reviewstar = numstar / totalstar;
                prp = true;
            }
            dataReader.Close();
            if (prp)
            {
                liteCommand.CommandText = $"UPDATE {table} SET SUMSTAR='{totalstar}', NUMBERSTAR='{numstar}', REVIEWSTARS='{reviewstar}' WHERE ID='{id}'";
                liteCommand.ExecuteNonQuery();
            }
            else
            {
                liteConnection.Close();
                Response.Redirect("Errorpage.aspx");
            }
            liteConnection.Close();
            Response.Redirect($"Productpage.aspx?table={table}&productid={id}");
        }
    }
}