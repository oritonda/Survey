using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oritonda_Ramugondo_Survey
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnFillSurvey_Click(object sender, EventArgs e)
        {
            SurveyMenu surveyActivity = new SurveyMenu();
            surveyActivity.Show();
            this.Hide();
        }

        private void btnSurveyResults_Click(object sender, EventArgs e)
        {
            Results results = new Results();
            results.Show();
            this.Hide();
        }
    }
}
