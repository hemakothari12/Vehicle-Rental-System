using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Confirmation : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
    SqlCommand cmd;
    SqlDataReader dr;
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink2.Visible = false;
        conn.Open();
        SqlCommand cmd3 = conn.CreateCommand();
        SqlDataReader dr3;
        string Bid = "Select top 1 BookingId from Booking order by BookingId desc";
        cmd3 = new SqlCommand(Bid, conn);
        dr3 = cmd3.ExecuteReader();
        dr3.Read();
        int bookid = Convert.ToInt32(dr3[0]);
        conn.Close();

        TextBox1.Text = bookid.ToString();

        conn.Open();
        SqlCommand cmd1 = conn.CreateCommand();
        SqlDataReader dr1;
        string query = "Select customerid from Admin";
        cmd1 = new SqlCommand(query, conn);
        dr1 = cmd1.ExecuteReader();
        dr1.Read();
        int custid = Convert.ToInt32(dr1[0]);
        conn.Close();

        if(custid != 0)
        {
            HyperLink2.Visible = true;
            HyperLink2.Enabled = true;
        }
    }
}