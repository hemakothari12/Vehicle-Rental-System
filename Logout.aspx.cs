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

    public partial class Logout : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            int setv = 0;
            SqlCommand cmd5 = new SqlCommand();
            cmd5.Connection = conn;
            cmd5.CommandText = "update Admin set customerid = '" + setv + "'";
            cmd5.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Home.aspx");
        }
    }
}