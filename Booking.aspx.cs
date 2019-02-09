using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Booking : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
    SqlCommand cmd;
    SqlDataReader dr;
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

        conn.Open();
        SqlCommand cmd2 = conn.CreateCommand();
        SqlDataReader dr2;
        string cid = "Select CustomerId from admin";
        cmd2 = new SqlCommand(cid, conn);
        dr2 = cmd2.ExecuteReader();
        dr2.Read();
        int custid = Convert.ToInt32(dr2[0]);
        conn.Close();
        if (custid != 0)
        {
            Response.Redirect("Payment.aspx");
            
        }
        else
        {
            conn.Open();
            SqlCommand cmd1 = conn.CreateCommand();
            SqlDataReader dr1;
            string RegNum = "Select RegNo from admin";
            cmd1 = new SqlCommand(RegNum, conn);
            dr1 = cmd1.ExecuteReader();
            dr1.Read();
            int regno = Convert.ToInt32(dr1[0]);
            conn.Close();

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select RegNo,Make,model,color,type,transmode,image1,price,capacity from Vehicle where RegNo= " + regno + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            vdetail.DataSource = dt;
            vdetail.DataBind();

            conn.Close();
        }

    }

    protected void btn_Login_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }

    protected void btn_Guest_Click(object sender, EventArgs e)
    {
        Response.Redirect("Review.aspx");
    }
}