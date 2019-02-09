using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace webapp1
{

    public partial class Vehicle : System.Web.UI.Page
    {

        String make, model, color, transmission_mode, review, loc;
        int regNo, x, min = 0, max = 10000;
        string capacity, type, tm;
        float price, rate;
        Image carimage;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();


        public void Page_Load(object sender, EventArgs e)
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
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select RegNo,Make,image1,model,price from Vehicle where Location= '" + loc + "' order by price";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            gvvehicle.DataSource = dt;
            gvvehicle.DataBind();
            conn.Close();
        }

        public void getFilterDetails()
        {
            conn.Open();
            SqlCommand cmd2 = conn.CreateCommand();
            SqlDataReader dr2;
            string queryloc = "Select location from admin";
            cmd2 = new SqlCommand(queryloc, conn);
            dr2 = cmd2.ExecuteReader();
            dr2.Read();
            loc = dr2[0].ToString();
            conn.Close();

            capacity = DropDownList1.SelectedItem.Value;
            x = Convert.ToInt32(capacity);
            if (x.Equals(null))
            {
                x = 0;
            }
            type = "Car','Truck','Minivan','Vans','SUVs";
            if (DropDownList2.SelectedValue == "All")
            {
                type = "Car','Truck','Minivan','Vans','SUVs";
            }
            else if (DropDownList2.SelectedValue == "Car")
            {
                type = "Car";
            }
            else if (DropDownList2.SelectedValue == "Truck")
            {
                type = "Truck";
            }
            else if (DropDownList2.SelectedValue == "Vans")
            {
                type = "Vans";
            }
            else if (DropDownList2.SelectedValue == "SUVs")
            {
                type = "SUVs";
            }
            else if (DropDownList2.SelectedValue == "Minivan")
            {
                type = "Minivan";
            }

            min = 0;
            max = 10000;
            if (DropDownList3.SelectedValue == "1")
            {
                min = 0;
                max = 10000;
            }
            else if (DropDownList3.SelectedValue == "2")
            {
                min = 1;
                max = 10;
            }
            else if (DropDownList3.SelectedValue == "3")
            {
                min = 11;
                max = 30;
            }
            else if (DropDownList3.SelectedValue == "4")
            {
                min = 31;
                max = 50;
            }
            else if (DropDownList3.SelectedValue == "5")
            {
                min = 51;
                max = 100;
            }
            else if (DropDownList3.SelectedValue == "6")
            {
                min = 101;
                max = 200;
            }
            else if (DropDownList3.SelectedValue == "7")
            {
                min = 201;
                max = 1000000;
            }
            else
            {
                min = 0;
                max = 10000;
            }

            tm = "Manual','Automatic','SemiAutomatic";
            if (DropDownList4.SelectedValue == "All")
            {
                tm = "Manual','Automatic','SemiAutomatic";
            }
            else if (DropDownList4.SelectedValue == "Manual")
            {
                tm = "Manual";
            }
            else if (DropDownList4.SelectedValue == "Automatic")
            {
                tm = "Automatic";
            }
            else if (DropDownList4.SelectedValue == "SemiAutomatic")
            {
                tm = "SemiAutomatic";
            }
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            string ob = "asc";
            if (DropDownList5.SelectedValue == "2")
            {
                ob = "desc";
            }

            getFilterDetails();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select RegNo,Make,image1,model,price from Vehicle where Location= '"
                + loc + "' and capacity >= '" + x + "' and Type in ( '"
                + type + "' ) and TransMode in ( '" + tm + "' ) and price between '"
                + min + "' and '" + max + "' order by price " + ob + "";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            gvvehicle.DataSource = dt;
            gvvehicle.DataBind();
            conn.Close();
        }   

        public void filter_indexchanged(Object sender, EventArgs e)
        {
            getFilterDetails();

            if (DropDownList5.SelectedValue == "1")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select RegNo,Make,image1,model,price from Vehicle where Location= '"
                    + loc + "' and capacity >= '" + x + "' and Type in ( '"
                    + type + "' ) and TransMode in ( '" + tm + "' ) and price between '"
                    + min + "' and '" + max + "' Order by price" ;

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                gvvehicle.DataSource = dt;
                gvvehicle.DataBind();
                conn.Close();
            }

            if (DropDownList5.SelectedValue == "2")
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select RegNo,Make,image1,model,price from Vehicle where Location= '"
                    + loc + "' and capacity >= '" + x + "' and Type in ( '"
                    + type + "' ) and TransMode in ( '" + tm + "' ) and price between '"
                    + min + "' and '" + max + "' Order by price DESC";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                gvvehicle.DataSource = dt;
                gvvehicle.DataBind();
                conn.Close();
            }
        }

        protected void lnkBook_Click(object sender, EventArgs e)
        {
            int Regnum = Convert.ToInt32((sender as LinkButton).CommandArgument);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "update Admin set RegNo = '" + Regnum + "'";
            cmd1.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Booking.aspx");
        }
    }
}