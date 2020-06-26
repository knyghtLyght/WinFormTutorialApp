namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.newPrizeButton = new System.Windows.Forms.Button();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamListBox = new System.Windows.Forms.ListBox();
            this.activeTeamsLabel = new System.Windows.Forms.Label();
            this.activeTeamsListBox = new System.Windows.Forms.ListBox();
            this.newTeamButton = new System.Windows.Forms.Button();
            this.addTeamBUtton = new System.Windows.Forms.Button();
            this.removeTeamButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.removePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentLabel.Location = new System.Drawing.Point(12, 9);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(286, 50);
            this.createTournamentLabel.TabIndex = 0;
            this.createTournamentLabel.Text = "New Tournament";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nameLabel.Location = new System.Drawing.Point(21, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 37);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(30, 113);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 33);
            this.nameTextBox.TabIndex = 1;
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeeLabel.Location = new System.Drawing.Point(21, 149);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(124, 37);
            this.entryFeeLabel.TabIndex = 0;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.Location = new System.Drawing.Point(151, 156);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(147, 33);
            this.entryFeeTextBox.TabIndex = 1;
            // 
            // newPrizeButton
            // 
            this.newPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.newPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.newPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.newPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newPrizeButton.Location = new System.Drawing.Point(30, 195);
            this.newPrizeButton.Name = "newPrizeButton";
            this.newPrizeButton.Size = new System.Drawing.Size(268, 46);
            this.newPrizeButton.TabIndex = 5;
            this.newPrizeButton.Text = "Create and add Prize";
            this.newPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizeListBox
            // 
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 25;
            this.prizeListBox.Location = new System.Drawing.Point(30, 247);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(268, 229);
            this.prizeListBox.TabIndex = 6;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamLabel.Location = new System.Drawing.Point(334, 73);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(160, 37);
            this.selectTeamLabel.TabIndex = 0;
            this.selectTeamLabel.Text = "Select Teams";
            // 
            // selectTeamListBox
            // 
            this.selectTeamListBox.FormattingEnabled = true;
            this.selectTeamListBox.ItemHeight = 25;
            this.selectTeamListBox.Location = new System.Drawing.Point(334, 113);
            this.selectTeamListBox.Name = "selectTeamListBox";
            this.selectTeamListBox.Size = new System.Drawing.Size(252, 354);
            this.selectTeamListBox.TabIndex = 6;
            // 
            // activeTeamsLabel
            // 
            this.activeTeamsLabel.AutoSize = true;
            this.activeTeamsLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activeTeamsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.activeTeamsLabel.Location = new System.Drawing.Point(698, 73);
            this.activeTeamsLabel.Name = "activeTeamsLabel";
            this.activeTeamsLabel.Size = new System.Drawing.Size(162, 37);
            this.activeTeamsLabel.TabIndex = 0;
            this.activeTeamsLabel.Text = "Active Teams";
            // 
            // activeTeamsListBox
            // 
            this.activeTeamsListBox.FormattingEnabled = true;
            this.activeTeamsListBox.ItemHeight = 25;
            this.activeTeamsListBox.Location = new System.Drawing.Point(698, 113);
            this.activeTeamsListBox.Name = "activeTeamsListBox";
            this.activeTeamsListBox.Size = new System.Drawing.Size(252, 354);
            this.activeTeamsListBox.TabIndex = 6;
            // 
            // newTeamButton
            // 
            this.newTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.newTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.newTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.newTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newTeamButton.Location = new System.Drawing.Point(592, 114);
            this.newTeamButton.Name = "newTeamButton";
            this.newTeamButton.Size = new System.Drawing.Size(100, 75);
            this.newTeamButton.TabIndex = 5;
            this.newTeamButton.Text = "New Team";
            this.newTeamButton.UseVisualStyleBackColor = true;
            // 
            // addTeamBUtton
            // 
            this.addTeamBUtton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamBUtton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamBUtton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamBUtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamBUtton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamBUtton.Location = new System.Drawing.Point(592, 195);
            this.addTeamBUtton.Name = "addTeamBUtton";
            this.addTeamBUtton.Size = new System.Drawing.Size(100, 46);
            this.addTeamBUtton.TabIndex = 5;
            this.addTeamBUtton.Text = "Add";
            this.addTeamBUtton.UseVisualStyleBackColor = true;
            // 
            // removeTeamButton
            // 
            this.removeTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeTeamButton.Location = new System.Drawing.Point(592, 247);
            this.removeTeamButton.Name = "removeTeamButton";
            this.removeTeamButton.Size = new System.Drawing.Size(100, 49);
            this.removeTeamButton.TabIndex = 5;
            this.removeTeamButton.Text = "Remove";
            this.removeTeamButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.Location = new System.Drawing.Point(511, 473);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(268, 46);
            this.createTournamentButton.TabIndex = 5;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // removePrizeButton
            // 
            this.removePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removePrizeButton.Location = new System.Drawing.Point(30, 482);
            this.removePrizeButton.Name = "removePrizeButton";
            this.removePrizeButton.Size = new System.Drawing.Size(268, 37);
            this.removePrizeButton.TabIndex = 5;
            this.removePrizeButton.Text = "Remove Selected Prize";
            this.removePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 542);
            this.Controls.Add(this.removePrizeButton);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removeTeamButton);
            this.Controls.Add(this.addTeamBUtton);
            this.Controls.Add(this.newTeamButton);
            this.Controls.Add(this.activeTeamsListBox);
            this.Controls.Add(this.activeTeamsLabel);
            this.Controls.Add(this.selectTeamListBox);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.newPrizeButton);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Button newPrizeButton;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ListBox selectTeamListBox;
        private System.Windows.Forms.Label activeTeamsLabel;
        private System.Windows.Forms.ListBox activeTeamsListBox;
        private System.Windows.Forms.Button newTeamButton;
        private System.Windows.Forms.Button addTeamBUtton;
        private System.Windows.Forms.Button removeTeamButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button removePrizeButton;
    }
}