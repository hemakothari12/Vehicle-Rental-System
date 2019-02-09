using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Speech;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Data.SqlClient;
using System.Data;

namespace webapp1
{

    public partial class Home : System.Web.UI.Page
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        Choices clist = new Choices();

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hema\source\repos\WebSite1\WebSite1\App_Data\Database.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                Calendar2.Visible = false;
            }
        }

        public void btn_Search_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && date1.Text != "" && date2.Text != "")
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update Admin set Location = '" + TextBox1.Text + "', DateFrom = '" + date1.Text + "', DateTo = '" + date2.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();                
                Response.Redirect("Vehicle.aspx");
            }
            else if (date1.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Date From<span>");
            }
            else if (date2.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Date To<span>");
            }
            else if (TextBox1.Text == "")
            {
                Response.Write("<span style= 'color:red'>Enter Location<span>");
            }
            else
            {
                Response.Write("<span style= 'color:red'>Enter All Fields<span>");
            }

        }

         public void VoiceButton_Click(object sender, EventArgs e)
        {
            VoiceButton.Enabled = false;
            clist.Add(new string[] { "New Haven", "Hamden", "DC","newhaven","Flanders","Morris" });
            Grammar gr = new Grammar(new GrammarBuilder(clist));
            try
            {

                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Single);
                sre.SpeechRecognized += Sre_SpeechRecognized;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    
        public void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string place = e.Result.Text;
            place = e.Result.Text.ToString();

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "update Admin set Location = '" + place + "', DateFrom = '" + date1.Text + "', DateTo = '" + date2.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Vehicle.aspx");
        }


        protected void bcal1_Click(object sender, EventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }

        protected void Calendar1_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
        {
            if (e.Day.Date <= DateTime.Now)
            {
                e.Cell.BackColor = System.Drawing.Color.Silver;
                e.Day.IsSelectable = false;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            date1.Text = Calendar1.SelectedDate.ToString("MM/dd/yyyy");          
            Calendar1.Visible = false;

        }

        protected void bcal2_Click(object sender, EventArgs e)
        {
            if (Calendar2.Visible)
            {
                Calendar2.Visible = false;
            }
            else
            {
                Calendar2.Visible = true;
            }
        }

        protected void Calendar2_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
        {
            if (e.Day.Date <= DateTime.Now)
            {
                e.Cell.BackColor = System.Drawing.Color.Silver;
                e.Day.IsSelectable = false;
            }
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            date2.Text = Calendar2.SelectedDate.ToString("MM/dd/yyyy");            
            Calendar2.Visible = false;
        }

    }
}