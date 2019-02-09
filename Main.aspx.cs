using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using webapp1;

namespace webapp1
{
    
    public partial class Main : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        //string vis = "hidden";
        //bool vis = false;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox9.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Button1.Visible = false;
        }
 
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
            {
                String image2 = "Images/" + TextBox1.Text + TextBox2.Text + ".JPG";
                cmd = new SqlCommand("insert into Vehicle(Make,Model,Color,Type,TransMode,Price,Capacity,Location,image1) values (@make1,@model1,@color1,@type1,@transmode1,@price1,@capacity1,@location1,@image3)", conn);
                cmd.Parameters.AddWithValue("@make1", TextBox1.Text);
                cmd.Parameters.AddWithValue("@model1", TextBox2.Text);
                cmd.Parameters.AddWithValue("@color1", TextBox3.Text);
                cmd.Parameters.AddWithValue("@type1", TextBox4.Text);
                cmd.Parameters.AddWithValue("@transmode1", TextBox6.Text);
                cmd.Parameters.AddWithValue("@price1", TextBox7.Text);
                cmd.Parameters.AddWithValue("@capacity1", TextBox8.Text);
                cmd.Parameters.AddWithValue("@location1", TextBox9.Text);
                cmd.Parameters.AddWithValue("@image3", image2);
                conn.Open();
                cmd.ExecuteNonQuery();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                conn.Close();
            }
            else if(TextBox1.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Make<span>");
            }
            else if (TextBox2.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Model<span>");
            }
            else if (TextBox3.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Color<span>");
            }
            else if (TextBox4.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Type<span>");
            }
            else if (TextBox6.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Transmission Mode<span>");
            }
            else if (TextBox7.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Price<span>");
            }
            else if (TextBox8.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Capacity<span>");
            }
            else if (TextBox9.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Location<span>");
            }
            settrue();
            
        }

        public void settrue ()
        {
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox9.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label6.Visible = true;
            Label7.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;
            Button1.Visible = true;
            Label11.Visible = true;
        }


        protected void addvehicle_Click(object sender, EventArgs e)
        {
            settrue();
        }
    }
}