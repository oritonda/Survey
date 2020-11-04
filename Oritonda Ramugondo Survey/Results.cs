using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oritonda_Ramugondo_Survey
{
    public partial class Results : Form
    {
        // setting up the database connection string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9SQRUPD;Initial Catalog=Survey;Integrated Security=True");

        public Results()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }
    
        public void numberOfSurveys()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select COUNT (*) as rows from SurveyData", con);
        SqlDataReader myReader = cmd.ExecuteReader();
        myReader.Read();
            totalSurveys.Text = myReader["rows"].ToString();
        con.Close();
        }

    
        public void maximumAge()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select max (Age) as max from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            maxAge.Text = myReader["max"].ToString();
            con.Close();
        }
        public void AvgAge()
        {
            int avg;
            con.Open();
            SqlCommand cmd = new SqlCommand("select avg (Age) as avg from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            avg = Convert.ToInt32(myReader["avg"]);
            AverageAge.Text = avg.ToString();
            con.Close();

        }

        public void minimumAge()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select min (Age) as min from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            minAge.Text = myReader["min"].ToString();
            con.Close();

        }
        public void pizza()
        {
            double pizza;
            double rows;
            double total;

            con.Open();
            SqlCommand cmd = new SqlCommand("select sum (Pizza) as pizza from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            pizza = Convert.ToInt32(myReader["pizza"]);
            con.Close();

            con.Open();
            SqlCommand row = new SqlCommand("select COUNT (*) as rows from SurveyData", con);
            SqlDataReader myReaders = row.ExecuteReader();
            myReaders.Read();

            rows = Convert.ToInt32( myReaders["rows"]);
            

            total = (pizza/rows)*100; // calculating to 100%
            pPizza.Text = total.ToString("0");
            con.Close();

        }
        public void pastaPercent()
        {
            double pasta;
            double rows;
            double total;

            con.Open();
            SqlCommand cmd = new SqlCommand("select sum (Pasta) as pasta from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            pasta = Convert.ToInt32(myReader["pasta"]);
            con.Close();

            con.Open();
            SqlCommand row = new SqlCommand("select COUNT (*) as rows from SurveyData", con);
            SqlDataReader myReaders = row.ExecuteReader();
            myReaders.Read();

            rows = Convert.ToInt32(myReaders["rows"]);


            total = ((pasta) / (rows)*100);// calculating to 100%
            Ppasta.Text = total.ToString("0");
            con.Close();
        }

        public void papPercent()
        {
            double papWors;
            double rows;
            double total;
            double round;

            con.Open();
            SqlCommand cmd = new SqlCommand("select sum (PapWors) as pap from SurveyData", con); // getting the sum
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            papWors = Convert.ToInt32(myReader["pap"]);
            con.Close();

            con.Open();
            SqlCommand row = new SqlCommand("select COUNT (*) as rows from SurveyData", con);// counting rows
            SqlDataReader myReaders = row.ExecuteReader();
            myReaders.Read();

            rows = Convert.ToInt32(myReaders["rows"]);


            total = ((papWors) / (rows) * 100);// calculating to 100%
            pPapWors.Text = total.ToString("0");
            con.Close();
        }
        public void eatOutRatings()
        {
            int round;
            con.Open();
            SqlCommand cmd = new SqlCommand("select avg (eatOut) as avg from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            round = Convert.ToInt32(myReader["avg"]);
            eatoutRating.Text = round.ToString();
            con.Close();
        }
        public void moviesRatings()
        {
            int round;
            con.Open();
            SqlCommand cmd = new SqlCommand("select avg (watchMovies) as avg from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            round = Convert.ToInt32(myReader["avg"]);
            movieRating.Text = round.ToString();
            con.Close();
        }
        public void TvRatings()
        {
            int round;
            con.Open();
            SqlCommand cmd = new SqlCommand("select avg (watchTv) as avg from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            round = Convert.ToInt32(myReader["avg"]);
            tvRating.Text = round.ToString();
            con.Close();

        }
        public void radioRatings()
        {
            int round;
            con.Open();
            SqlCommand cmd = new SqlCommand("select avg (ListenToRadio) as avg from SurveyData", con);
            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            round = Convert.ToInt32(myReader["avg"]);
            radioRating.Text = round.ToString();
            con.Close();
        }
        private void Results_Load(object sender, EventArgs e)
        {
            
            numberOfSurveys();
            minimumAge();
            AvgAge();
            maximumAge();
            //menu ratings
            pizza();
            papPercent();
            pastaPercent();

            // avarage ratings
            eatOutRatings();
            moviesRatings();
            TvRatings();
            radioRatings();
        }
    }
}
