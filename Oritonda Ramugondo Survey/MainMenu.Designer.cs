namespace Oritonda_Ramugondo_Survey
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFillSurvey = new System.Windows.Forms.Button();
            this.btnSurveyResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFillSurvey
            // 
            this.btnFillSurvey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFillSurvey.Location = new System.Drawing.Point(291, 189);
            this.btnFillSurvey.Name = "btnFillSurvey";
            this.btnFillSurvey.Size = new System.Drawing.Size(200, 50);
            this.btnFillSurvey.TabIndex = 0;
            this.btnFillSurvey.Text = "Fill out survey";
            this.btnFillSurvey.UseVisualStyleBackColor = true;
            this.btnFillSurvey.Click += new System.EventHandler(this.btnFillSurvey_Click);
            // 
            // btnSurveyResults
            // 
            this.btnSurveyResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSurveyResults.Location = new System.Drawing.Point(291, 265);
            this.btnSurveyResults.Name = "btnSurveyResults";
            this.btnSurveyResults.Size = new System.Drawing.Size(200, 50);
            this.btnSurveyResults.TabIndex = 1;
            this.btnSurveyResults.Text = "View survey results";
            this.btnSurveyResults.UseVisualStyleBackColor = true;
            this.btnSurveyResults.Click += new System.EventHandler(this.btnSurveyResults_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSurveyResults);
            this.Controls.Add(this.btnFillSurvey);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFillSurvey;
        private System.Windows.Forms.Button btnSurveyResults;
    }
}

