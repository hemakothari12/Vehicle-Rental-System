using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Payment : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
    SqlCommand cmd;
    SqlDataReader dr;
    DataTable dt = new DataTable();
    int regno;
    int difference, cost;
    string date1, date2, loc;
    string cname, cemail, cphone;
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd1 = conn.CreateCommand();
        SqlDataReader dr1;
        string custid = "Select customerid,RegNo,DateFrom,DateTo,location,DATEDIFF(day,DateFrom,DateTo) As DateDiff from admin";
        cmd1 = new SqlCommand(custid, conn);
        dr1 = cmd1.ExecuteReader();
        dr1.Read();
        regno = Convert.ToInt32(dr1[1]);
        int idcustomer = Convert.ToInt32(dr1[0]);
        date1 = dr1[2].ToString();
        date2 = dr1[3].ToString();
        loc = dr1[4].ToString();
        difference = Convert.ToInt32(dr1[5]);
        conn.Close();

        conn.Open();
        SqlCommand cmd4 = conn.CreateCommand();
        SqlDataReader dr4;
        string  query= "Select Name,Email,Phone from Customer where Id= " + idcustomer + "";
        cmd4 = new SqlCommand(query, conn);
        dr4 = cmd4.ExecuteReader();
        dr4.Read();
        cname = dr4[0].ToString();
        cemail = dr4[1].ToString();
        cphone = dr4[2].ToString();
        conn.Close();

        tname.Text = cname;
        temail.Text = cemail;
        tphone.Text = cphone;

        tdatefrom.Text = date1;
        tdateto.Text = date2;

        conn.Open();
        SqlCommand cmd2 = conn.CreateCommand();
        cmd2.CommandType = CommandType.Text;
        cmd2.CommandText = "Select RegNo,Make,model,color,type,transmode,image1,price,capacity from Vehicle where RegNo= " + regno + "";
        cmd2.ExecuteNonQuery();
        DataTable dt2 = new DataTable();
        SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
        sda2.Fill(dt2);
        vdetail.DataSource = dt2;
        vdetail.DataBind();
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
        tamount.Text = "$"+cost.ToString()+"";

    }

    protected void bconfirm_Click(object sender, EventArgs e)
    {
        if(cardname.Text != "" && cardno.Text != "" && edate.Text != "" && cvv.Text != "")
        {
            cmd = new SqlCommand("insert into Booking(RegNo,DateFrom,DateTo,LocationFrom,LocationTo,Name,Email,Phone,Amount) values (@RegNo1,@DateFrom1,@DateTo1,@LocationFrom1,@LocationTo1,@Name1,@Email1,@Phone1,@amount1)", conn);
            cmd.Parameters.AddWithValue("@RegNo1", regno);
            cmd.Parameters.AddWithValue("@DateFrom1", date1);
            cmd.Parameters.AddWithValue("@DateTo1", date2);
            cmd.Parameters.AddWithValue("@LocationFrom1", loc);
            cmd.Parameters.AddWithValue("@LocationTo1", loc);
            cmd.Parameters.AddWithValue("@Name1", tname.Text);
            cmd.Parameters.AddWithValue("@Email1", temail.Text);
            cmd.Parameters.AddWithValue("@Phone1", tphone.Text);
            cmd.Parameters.AddWithValue("@amount1", cost);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            int setv = 0;
            SqlCommand cmd5 = new SqlCommand();
            cmd5.Connection = conn;
            cmd5.CommandText = "update Admin set RegNo = '" + setv + "'";
            cmd5.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Confirmation.aspx");
        }
        else if(cardname.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Name On Card<span>");
        }
        else if(cardno.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Card Number<span>");
        }
        else if (edate.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Expiry Date<span>");
        }
        else if (cvv.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter CVV<span>");
        }
    }
}