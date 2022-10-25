namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tournamentname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnly = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.VersesLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentname
            // 
            this.tournamentname.AutoSize = true;
            this.tournamentname.Location = new System.Drawing.Point(290, 28);
            this.tournamentname.Name = "tournamentname";
            this.tournamentname.Size = new System.Drawing.Size(118, 38);
            this.tournamentname.TabIndex = 1;
            this.tournamentname.Text = "<none>";
            this.tournamentname.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(190, 98);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(218, 45);
            this.roundDropDown.TabIndex = 3;
            // 
            // UnplayedOnly
            // 
            this.UnplayedOnly.AutoSize = true;
            this.UnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedOnly.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UnplayedOnly.Location = new System.Drawing.Point(190, 174);
            this.UnplayedOnly.Name = "UnplayedOnly";
            this.UnplayedOnly.Size = new System.Drawing.Size(257, 50);
            this.UnplayedOnly.TabIndex = 4;
            this.UnplayedOnly.Text = "Unplayed Only";
            this.UnplayedOnly.UseVisualStyleBackColor = true;
            this.UnplayedOnly.CheckedChanged += new System.EventHandler(this.UnplayedOnly_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 37;
            this.matchupListBox.Location = new System.Drawing.Point(44, 259);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(364, 261);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Location = new System.Drawing.Point(556, 186);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(172, 38);
            this.teamOneName.TabIndex = 8;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(556, 262);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamOneScoreLabel.TabIndex = 9;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(648, 259);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(125, 43);
            this.teamOneScoreValue.TabIndex = 10;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(648, 461);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(125, 43);
            this.teamTwoScoreValue.TabIndex = 13;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(556, 464);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamTwoScoreLabel.TabIndex = 12;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Location = new System.Drawing.Point(556, 388);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(170, 38);
            this.teamTwoName.TabIndex = 11;
            this.teamTwoName.Text = "<team two>";
            // 
            // VersesLabel
            // 
            this.VersesLabel.AutoSize = true;
            this.VersesLabel.Location = new System.Drawing.Point(648, 331);
            this.VersesLabel.Name = "VersesLabel";
            this.VersesLabel.Size = new System.Drawing.Size(71, 38);
            this.VersesLabel.TabIndex = 14;
            this.VersesLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.Location = new System.Drawing.Point(826, 322);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(119, 47);
            this.scoreButton.TabIndex = 15;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 832);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.VersesLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnly);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tournamentname);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TournamentViewerForm";
            this.Text = " Unplayed Only";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public Label tournamentname;
        private Label label2;
        private ComboBox roundDropDown;
        private CheckBox UnplayedOnly;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label VersesLabel;
        private Button scoreButton;
    }
}