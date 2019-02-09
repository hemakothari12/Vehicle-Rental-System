using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ViewBooking : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
    SqlCommand cmd;
    SqlDataReader dr;
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        bdetails.Visible = false;
        vdetail.Visible = false;

    }

    protected void viewbook_Click(object sender, EventArgs e)
    {    
        if(tbook.Text != "")
        {

            int bk = Convert.ToInt32(tbook.Text);
            conn.Open();
            SqlCommand cmd1 = conn.CreateCommand();
            SqlDataReader dr1;
            string qr = "Select RegNo from Booking where BookingId= " + bk + "";
            cmd1 = new SqlCommand(qr, conn);
            dr1 = cmd1.ExecuteReader();
            if (dr1 == null || !dr1.HasRows)
            {
                Response.Write("No records found");
            }
            else
            {
                Label1.Visible = true;
                vdetail.Visible = true;
                bdetails.Visible = true;
                dr1.Read();
                int regno = Convert.ToInt32(dr1[0]);
                conn.Close();

                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select DateFrom,DateTo,LocationFrom,LocationTo,Name,Email,Phone,Amount from Booking where BookingId= " + bk + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                bdetails.DataSource = dt;
                bdetails.DataBind();
                conn.Close();

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
            }
        }
        else
        {
            Response.Write("<span style= 'color:red'>Enter Booking Id<span>");
        }        
    }
}