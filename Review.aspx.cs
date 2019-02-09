using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Review : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
    SqlCommand cmd; 
    SqlDataReader dr;
    DataTable dt = new DataTable();
    string loc="";
    int difference,cost;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bconfirm_Click(object sender, EventArgs e)
    {
        if (fname.Text != "" && email.Text != "" && phone.Text != "" && cardname.Text != "" && cardno.Text != "" && edate.Text != "" && cvv.Text != "")
        {
            conn.Open();
            SqlCommand cmd1 = conn.CreateCommand();
            SqlDataReader dr1;
            string queryloc = "Select location from admin";
            cmd1 = new SqlCommand(queryloc, conn);
            dr1 = cmd1.ExecuteReader();
            dr1.Read();
            loc = dr1[0].ToString();
            conn.Close();

            conn.Open();
            SqlCommand cmd2 = conn.CreateCommand();
            SqlDataReader dr2;
            string RegNum = "Select RegNo,DateFrom,DateTo,DATEDIFF(day,DateFrom,DateTo) As DateDiff from admin";
            cmd2 = new SqlCommand(RegNum, conn);
            dr2 = cmd2.ExecuteReader();
            dr2.Read();
            int regno = Convert.ToInt32(dr2[0]);
            string date1 = dr2[1].ToString();
            string date2 = dr2[2].ToString();
            difference = Convert.ToInt32(dr2[3]);
            conn.Close();


            conn.Open();
            SqlCommand cmd6 = conn.CreateCommand();
            SqlDataReader dr6;
            string query1 = "Select price from Vehicle where RegNo= " + regno + "";
            cmd6 = new SqlCommand(query1, conn);
            dr6 = cmd6.ExecuteReader();
            dr6.Read();
            int price1 = Convert.ToInt32(dr6[0]);
            conn.Close();

            cost = difference * price1;

            cmd = new SqlCommand("insert into Booking(RegNo,DateFrom,DateTo,LocationFrom,LocationTo,Name,Email,Phone,amount) values (@RegNo1,@DateFrom1,@DateTo1,@LocationFrom1,@LocationTo1,@Name1,@Email1,@Phone1,@amount1)", conn);
            cmd.Parameters.AddWithValue("@RegNo1", regno);
            cmd.Parameters.AddWithValue("@DateFrom1", date1);
            cmd.Parameters.AddWithValue("@DateTo1", date2);
            cmd.Parameters.AddWithValue("@LocationFrom1", loc);
            cmd.Parameters.AddWithValue("@LocationTo1", loc);
            cmd.Parameters.AddWithValue("@Name1", fname.Text);
            cmd.Parameters.AddWithValue("@Email1", email.Text);
            cmd.Parameters.AddWithValue("@Phone1", phone.Text);
            cmd.Parameters.AddWithValue("@amount1", cost);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            int setv = 0;
            SqlCommand cmd4 = new SqlCommand();
            cmd4.Connection = conn;
            cmd4.CommandText = "update Admin set RegNo = '" + setv + "'";
            cmd4.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Confirmation.aspx");
        }
        else if(fname.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Name<span>");
        }
        else if (email.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Email<span>");
        }
        else if (phone.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Phone<span>");
        }
        else if (cardname.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Name on Card<span>");
        }
        else if (cardno.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Card Number<span>");
        }
        else if (edate.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Exipry Date<span>");
        }
        else if (cvv.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter CVV<span>");
        }
    }
}