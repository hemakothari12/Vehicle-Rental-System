using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace webapp1
{
    public partial class Admin : System.Web.UI.Page
    {
        String adminusername, adminpassword;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        string userrole = "";
        int cid;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (usernametxt.Text != "" && Password_txt.Text != "")
            {
                adminusername = usernametxt.Text;
                adminpassword = Password_txt.Text;
                conn.Open();
                String query = "select role,Id from Customer where username= '" + adminusername + "' and password = '" + adminpassword + "'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    Response.Write("<span style= 'color:red'>Invalid Username and Password<span>");
                }
                else
                {
                    dr.Read();
                    userrole = dr[0].ToString();
                    cid = Convert.ToInt32(dr[1]);
                    if (userrole == "admin")
                    {

                        Response.Redirect("Main.aspx");
                    }
                    else if (userrole == "user")
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd2 = conn.CreateCommand();
                        SqlDataReader dr2;
                        string RegNum = "Select RegNo from admin";
                        cmd2 = new SqlCommand(RegNum, conn);
                        dr2 = cmd2.ExecuteReader();
                        dr2.Read();
                        int regno = Convert.ToInt32(dr2[0]);
                        conn.Close();
                        if (regno == 0)
                        {
                            conn.Open();
                            SqlCommand cmd6 = new SqlCommand();
                            cmd6.Connection = conn;
                            cmd6.CommandText = "update Admin set Customerid = '" + cid + "'";
                            cmd6.ExecuteNonQuery();
                            conn.Close();
                            Response.Redirect("Home.aspx");
                        }
                        else
                        {
                            conn.Open();
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Connection = conn;
                            cmd1.CommandText = "update Admin set Customerid = '" + cid + "'";
                            cmd1.ExecuteNonQuery();
                            conn.Close();
                            Response.Redirect("Payment.aspx");
                        }
                    }
                }
            }   
            else if(usernametxt.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Username<span>");
            }
            else if(Password_txt.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Password<span>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}