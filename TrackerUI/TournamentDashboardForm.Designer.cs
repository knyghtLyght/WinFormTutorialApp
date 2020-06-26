namespace TrackerUI
{
    partial class TournamentDashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentsDropDown = new System.Windows.Forms.ComboBox();
            this.showActiveOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.roundsLable = new System.Windows.Forms.Label();
            this.roundsDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.roundsListBox = new System.Windows.Forms.ListBox();
            this.prizeListLable = new System.Windows.Forms.Label();
            this.firstPrizeLable = new System.Windows.Forms.Label();
            this.secondPrizeLabel = new System.Windows.Forms.Label();
            this.thirdPrizeLable = new System.Windows.Forms.Label();
            this.teamONeLable = new System.Windows.Forms.Label();
            this.tesmTwoLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.temOneScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.tournamentWinnerLabel = new System.Windows.Forms.Label();
            this.winningTeamLabel = new System.Windows.Forms.Label();
            this.newTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentDashboardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(12, 9);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(385, 50);
            this.tournamentDashboardLabel.TabIndex = 0;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 71);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(85, 37);
            this.tournamentNameLabel.TabIndex = 0;
            this.tournamentNameLabel.Text = "Name";
            // 
            // tournamentsDropDown
            // 
            this.tournamentsDropDown.FormattingEnabled = true;
            this.tournamentsDropDown.Location = new System.Drawing.Point(124, 74);
            this.tournamentsDropDown.Name = "tournamentsDropDown";
            this.tournamentsDropDown.Size = new System.Drawing.Size(273, 38);
            this.tournamentsDropDown.TabIndex = 1;
            // 
            // showActiveOnlyCheckBox
            // 
            this.showActiveOnlyCheckBox.AutoSize = true;
            this.showActiveOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showActiveOnlyCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.showActiveOnlyCheckBox.Location = new System.Drawing.Point(161, 119);
            this.showActiveOnlyCheckBox.Name = "showActiveOnlyCheckBox";
            this.showActiveOnlyCheckBox.Size = new System.Drawing.Size(135, 23);
            this.showActiveOnlyCheckBox.TabIndex = 2;
            this.showActiveOnlyCheckBox.Text = "Show Active Only";
            this.showActiveOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // roundsLable
            // 
            this.roundsLable.AutoSize = true;
            this.roundsLable.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundsLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundsLable.Location = new System.Drawing.Point(12, 143);
            this.roundsLable.Name = "roundsLable";
            this.roundsLable.Size = new System.Drawing.Size(100, 37);
            this.roundsLable.TabIndex = 0;
            this.roundsLable.Text = "Rounds";
            this.roundsLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundsDropDown
            // 
            this.roundsDropDown.FormattingEnabled = true;
            this.roundsDropDown.Location = new System.Drawing.Point(124, 146);
            this.roundsDropDown.Name = "roundsDropDown";
            this.roundsDropDown.Size = new System.Drawing.Size(273, 38);
            this.roundsDropDown.TabIndex = 1;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(161, 190);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(156, 23);
            this.unplayedOnlyCheckbox.TabIndex = 2;
            this.unplayedOnlyCheckbox.Text = "Show Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // roundsListBox
            // 
            this.roundsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundsListBox.FormattingEnabled = true;
            this.roundsListBox.ItemHeight = 30;
            this.roundsListBox.Location = new System.Drawing.Point(24, 231);
            this.roundsListBox.Name = "roundsListBox";
            this.roundsListBox.Size = new System.Drawing.Size(373, 392);
            this.roundsListBox.TabIndex = 3;
            // 
            // prizeListLable
            // 
            this.prizeListLable.AutoSize = true;
            this.prizeListLable.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeListLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeListLable.Location = new System.Drawing.Point(459, 71);
            this.prizeListLable.Name = "prizeListLable";
            this.prizeListLable.Size = new System.Drawing.Size(90, 37);
            this.prizeListLable.TabIndex = 0;
            this.prizeListLable.Text = "Prizes:";
            // 
            // firstPrizeLable
            // 
            this.firstPrizeLable.AutoSize = true;
            this.firstPrizeLable.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstPrizeLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstPrizeLable.Location = new System.Drawing.Point(562, 71);
            this.firstPrizeLable.Name = "firstPrizeLable";
            this.firstPrizeLable.Size = new System.Drawing.Size(163, 37);
            this.firstPrizeLable.TabIndex = 0;
            this.firstPrizeLable.Text = "<First Prize>";
            // 
            // secondPrizeLabel
            // 
            this.secondPrizeLabel.AutoSize = true;
            this.secondPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondPrizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.secondPrizeLabel.Location = new System.Drawing.Point(562, 108);
            this.secondPrizeLabel.Name = "secondPrizeLabel";
            this.secondPrizeLabel.Size = new System.Drawing.Size(185, 37);
            this.secondPrizeLabel.TabIndex = 0;
            this.secondPrizeLabel.Text = "<Secon Prize>";
            this.secondPrizeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // thirdPrizeLable
            // 
            this.thirdPrizeLable.AutoSize = true;
            this.thirdPrizeLable.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thirdPrizeLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.thirdPrizeLable.Location = new System.Drawing.Point(562, 147);
            this.thirdPrizeLable.Name = "thirdPrizeLable";
            this.thirdPrizeLable.Size = new System.Drawing.Size(174, 37);
            this.thirdPrizeLable.TabIndex = 0;
            this.thirdPrizeLable.Text = "<Third Prize>";
            // 
            // teamONeLable
            // 
            this.teamONeLable.AutoSize = true;
            this.teamONeLable.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamONeLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamONeLable.Location = new System.Drawing.Point(459, 231);
            this.teamONeLable.Name = "teamONeLable";
            this.teamONeLable.Size = new System.Drawing.Size(168, 37);
            this.teamONeLable.TabIndex = 0;
            this.teamONeLable.Text = "<Team One>";
            // 
            // tesmTwoLabel
            // 
            this.tesmTwoLabel.AutoSize = true;
            this.tesmTwoLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tesmTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tesmTwoLabel.Location = new System.Drawing.Point(711, 231);
            this.tesmTwoLabel.Name = "tesmTwoLabel";
            this.tesmTwoLabel.Size = new System.Drawing.Size(164, 37);
            this.tesmTwoLabel.TabIndex = 0;
            this.tesmTwoLabel.Text = "<Team Two>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.versusLabel.Location = new System.Drawing.Point(647, 301);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(45, 37);
            this.versusLabel.TabIndex = 0;
            this.versusLabel.Text = "VS";
            // 
            // temOneScoreValueTextBox
            // 
            this.temOneScoreValueTextBox.Location = new System.Drawing.Point(493, 304);
            this.temOneScoreValueTextBox.Name = "temOneScoreValueTextBox";
            this.temOneScoreValueTextBox.Size = new System.Drawing.Size(100, 35);
            this.temOneScoreValueTextBox.TabIndex = 4;
            // 
            // teamTwoScoreValueTextBox
            // 
            this.teamTwoScoreValueTextBox.Location = new System.Drawing.Point(751, 304);
            this.teamTwoScoreValueTextBox.Name = "teamTwoScoreValueTextBox";
            this.teamTwoScoreValueTextBox.Size = new System.Drawing.Size(100, 35);
            this.teamTwoScoreValueTextBox.TabIndex = 4;
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.Location = new System.Drawing.Point(595, 367);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(141, 46);
            this.scoreButton.TabIndex = 5;
            this.scoreButton.Text = "Score Match";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // tournamentWinnerLabel
            // 
            this.tournamentWinnerLabel.AutoSize = true;
            this.tournamentWinnerLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentWinnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentWinnerLabel.Location = new System.Drawing.Point(544, 470);
            this.tournamentWinnerLabel.Name = "tournamentWinnerLabel";
            this.tournamentWinnerLabel.Size = new System.Drawing.Size(238, 37);
            this.tournamentWinnerLabel.TabIndex = 0;
            this.tournamentWinnerLabel.Text = "Tournament Winner";
            // 
            // winningTeamLabel
            // 
            this.winningTeamLabel.AutoSize = true;
            this.winningTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winningTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.winningTeamLabel.Location = new System.Drawing.Point(562, 535);
            this.winningTeamLabel.Name = "winningTeamLabel";
            this.winningTeamLabel.Size = new System.Drawing.Size(212, 37);
            this.winningTeamLabel.TabIndex = 0;
            this.winningTeamLabel.Text = "<Winning Team>";
            // 
            // newTournamentButton
            // 
            this.newTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.newTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.newTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.newTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newTournamentButton.Location = new System.Drawing.Point(711, 13);
            this.newTournamentButton.Name = "newTournamentButton";
            this.newTournamentButton.Size = new System.Drawing.Size(197, 46);
            this.newTournamentButton.TabIndex = 5;
            this.newTournamentButton.Text = "New Tournament";
            this.newTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 640);
            this.Controls.Add(this.newTournamentButton);
            this.Controls.Add(this.winningTeamLabel);
            this.Controls.Add(this.tournamentWinnerLabel);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamTwoScoreValueTextBox);
            this.Controls.Add(this.temOneScoreValueTextBox);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.tesmTwoLabel);
            this.Controls.Add(this.teamONeLable);
            this.Controls.Add(this.thirdPrizeLable);
            this.Controls.Add(this.secondPrizeLabel);
            this.Controls.Add(this.firstPrizeLable);
            this.Controls.Add(this.prizeListLable);
            this.Controls.Add(this.roundsListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundsDropDown);
            this.Controls.Add(this.roundsLable);
            this.Controls.Add(this.showActiveOnlyCheckBox);
            this.Controls.Add(this.tournamentsDropDown);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboard";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.ComboBox tournamentsDropDown;
        private System.Windows.Forms.CheckBox showActiveOnlyCheckBox;
        private System.Windows.Forms.Label roundsLable;
        private System.Windows.Forms.ComboBox roundsDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox roundsListBox;
        private System.Windows.Forms.Label prizeListLable;
        private System.Windows.Forms.Label firstPrizeLable;
        private System.Windows.Forms.Label secondPrizeLabel;
        private System.Windows.Forms.Label thirdPrizeLable;
        private System.Windows.Forms.Label teamONeLable;
        private System.Windows.Forms.Label tesmTwoLabel;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.TextBox temOneScoreValueTextBox;
        private System.Windows.Forms.TextBox teamTwoScoreValueTextBox;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Label tournamentWinnerLabel;
        private System.Windows.Forms.Label winningTeamLabel;
        private System.Windows.Forms.Button newTournamentButton;
    }
}

