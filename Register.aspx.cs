using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Register : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
    SqlCommand cmd;
    SqlDataReader dr;
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Register_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "")
        {
            if(TextBox2.Text == TextBox3.Text)
            {
                string role1 = "user";
                cmd = new SqlCommand("insert into Customer(Name,Phone,Username,Password,Email,DOB,Role) values (@name1,@phone1,@username1,@password1,@email1,@dob1,@role2)", conn);
                cmd.Parameters.AddWithValue("@name1", TextBox4.Text);
                cmd.Parameters.AddWithValue("@phone1", TextBox5.Text);
                cmd.Parameters.AddWithValue("@username1", TextBox1.Text);
                cmd.Parameters.AddWithValue("@password1", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email1", TextBox6.Text);
                cmd.Parameters.AddWithValue("@dob1", TextBox7.Text);
                cmd.Parameters.AddWithValue("@role2", role1);
                Response.Write("User Added successfully");
                conn.Open();
                cmd.ExecuteNonQuery();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                conn.Close();
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Response.Write("<span style= 'color:red'>Password and Confirm Password does not match<span>");
            }            
        }
        else if(TextBox1.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Username<span>");
        }
        else if (TextBox2.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Password<span>");
        }
        else if (TextBox3.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Confirm Password<span>");
        }
        else if (TextBox4.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Name<span>");
        }
        else if (TextBox5.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Phone<span>");
        }
        else if (TextBox6.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Email<span>");
        }
        else if (TextBox7.Text == "")
        {
            Response.Write("<span style= 'color:red'>Enter Date of Birth<span>");
        }
    }

    protected void btn_Cancel_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        Response.Redirect("Home.aspx");
    }
}