using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oritonda_Ramugondo_Survey
{
    public partial class SurveyMenu : Form
    {
        // setting up the database connection string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9SQRUPD;Initial Catalog=Survey;Integrated Security=True");

        public SurveyMenu()
        {
            InitializeComponent();
        }
        public void takeSurvey()
        {
            // defing user details variables
            String name, surname;
            DateTime date;
            int contact, age;

            name = txtName.Text.Trim();
            surname = txtSurname.Text.Trim();
            date = txtDate.Value;


            if (name == "")
            {
                MessageBox.Show("Please enter your name");
            }
            if (surname == "")
            {
                MessageBox.Show("please enter your surname");
            }
            if (this.txtContacts == null)
            {
                MessageBox.Show("please enter your contact number");
            }
            if (this.txtAge == null)
            {
                MessageBox.Show("please enter your age");
            }
            // Menu
            // 
            int pizza;
            int pasta;
            int PapWors;
            int Chicken;
            int Beef;
            int Other;

            // using statements to record a menu when a check box is checked
            // a menu is assigned a value of one when selected this makes it simple to calculate number of times it was orderd

            if (checkPizza.Checked)
            {
                pizza = 1;
            }
            else
            {
                pizza = 0;
            }
            if (checkPasta.Checked)
            {
                pasta = 1;
            }
            else
            {
                pasta = 0;
            }
            if (checkPap.Checked)
            {
                PapWors = 1;

            }
            else
            {
                PapWors = 0;
            }
            if (checkChicken.Checked)
            {
                Chicken = 1;
            }
            else
            {
                Chicken = 0;

            }
            if (checkBeef.Checked)
            {
                Beef = 1;
            }
            else
            {
                Beef = 0;
            }
            if (checkOther.Checked)
            {
                Other = 1;
            }
            else
            {
                Other = 0;
            }



            // Ratings


            // different Ratings variables
            int Eat_Out_Rating = 0;
            int Watch_Movies_Rating = 0;
            int Watch_TV_Rating = 0;
            int Listen_to_Radio_Rating = 0;

            // setting up condion of ratings when a radio button is checked

            if (WatchMovieStronglyAgree.Checked == true)

            {
                Watch_Movies_Rating = 1;

            }
            if (eatOutStronlyAgree.Checked == true)
            {
                Eat_Out_Rating = 1;
            }
            if (WatchTVStronglyAgree.Checked == true)
            {
                Watch_TV_Rating = 1;
            }
            if (ListenToRadioStronglyAgree.Checked == true)
            {
                Listen_to_Radio_Rating = 1;


            }

            if (eatOutAgree.Checked == true)
            {
                Eat_Out_Rating = 2;
            }
            if (WatchMoviesAgree.Checked == true)
            {
                Watch_Movies_Rating = 2;
            }
            if (WatchTVAgree.Checked == true)
            {
                Watch_TV_Rating = 2;
            }
            if (ListenToRadioAgree.Checked == true)
            {
                Listen_to_Radio_Rating = 2;
            }

            if (eatOutNeutral.Checked == true)
            {

                Eat_Out_Rating = 3;
            }
            if (WatchMoviesNeutral.Checked == true)
            {
                Watch_Movies_Rating = 3;
            }
            if (WatchTVNeutal.Checked == true)
            {
                Watch_TV_Rating = 3;
            }
            if (ListenToRadioNeutral.Checked == true)
            {
                Listen_to_Radio_Rating = 3;
            }


            if (eatOutDisagree.Checked == true)

            {
                Eat_Out_Rating = 4;

            }
            if (WatchMoviesDisagree.Checked == true)
            {
                Watch_Movies_Rating = 4;
            }
            if (WatchTVDisagree.Checked == true)
            {
                Watch_TV_Rating = 4;
            }
            if (ListenToRadioDisagree.Checked == true)
            {
                Listen_to_Radio_Rating = 4;
            }


            if (WatchMoviesStronglyDisagree.Checked == true)
            {

                Eat_Out_Rating = 5;
            }

            if (eatOutStronglyDisagree.Checked == true)
            {
                Watch_Movies_Rating = 5;
            }
            if (WatchTVStronglyDisagree.Checked == true)
            {
                Watch_TV_Rating = 5;
            }
            if (ListenToRadioStronglyDisagree.Checked == true)
            {
                Listen_to_Radio_Rating = 5;
            }


            string Query = "insert into SurveyData (Surname,Firstname,ContactsNumber,date,age,Pizza,Pasta,PapWors,ChickenStirFry,BeefStireFry,Other,eatOut,watchMovies,watchTv,ListenToRadio) values('" + this.txtSurname.Text + "','" + this.txtName.Text + "','" + this.txtContacts.Text + "','" + this.txtDate.Value + "','" + txtAge.Text + "','" + pizza + "','" + pasta + "','" + PapWors + "','" + Chicken + "','" + Beef + "','" + Other + "','" + Eat_Out_Rating + "','" + Watch_Movies_Rating + "','" + Watch_TV_Rating + "','" + Listen_to_Radio_Rating + "') ;";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            // going back to main menu after a survey is completed
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            takeSurvey();
            

                }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // going back to main menu after a survey is completed
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();

        }
    }
        }
 

