namespace ChampionsLeague.Application
{
    partial class BestClubsForm
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
            this.goalsLabel = new System.Windows.Forms.Label();
            this.goalsTextBox = new System.Windows.Forms.TextBox();
            this.bestClubsLabel = new System.Windows.Forms.Label();
            this.bestClubsListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoalsLabel
            // 
            this.goalsLabel.AutoSize = true;
            this.goalsLabel.Location = new System.Drawing.Point(13, 13);
            this.goalsLabel.Name = "GoalsLabel";
            this.goalsLabel.Size = new System.Drawing.Size(45, 17);
            this.goalsLabel.TabIndex = 0;
            this.goalsLabel.Text = "Goals";
            // 
            // GoalsTextBox
            // 
            this.goalsTextBox.Enabled = false;
            this.goalsTextBox.Location = new System.Drawing.Point(16, 34);
            this.goalsTextBox.Name = "GoalsTextBox";
            this.goalsTextBox.Size = new System.Drawing.Size(100, 22);
            this.goalsTextBox.TabIndex = 1;
            // 
            // BestClubsLabel
            // 
            this.bestClubsLabel.AutoSize = true;
            this.bestClubsLabel.Location = new System.Drawing.Point(13, 63);
            this.bestClubsLabel.Name = "BestClubsLabel";
            this.bestClubsLabel.Size = new System.Drawing.Size(73, 17);
            this.bestClubsLabel.TabIndex = 2;
            this.bestClubsLabel.Text = "Best clubs";
            // 
            // BestClubsListBox
            // 
            this.bestClubsListBox.FormattingEnabled = true;
            this.bestClubsListBox.ItemHeight = 16;
            this.bestClubsListBox.Location = new System.Drawing.Point(16, 84);
            this.bestClubsListBox.Name = "BestClubsListBox";
            this.bestClubsListBox.Size = new System.Drawing.Size(197, 228);
            this.bestClubsListBox.TabIndex = 3;
            // 
            // OkButton
            // 
            this.okButton.Location = new System.Drawing.Point(138, 318);
            this.okButton.Name = "OkButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // BestClubs
            // 
            this.CancelButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 353);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.bestClubsListBox);
            this.Controls.Add(this.bestClubsLabel);
            this.Controls.Add(this.goalsTextBox);
            this.Controls.Add(this.goalsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BestClubs";
            this.ShowInTaskbar = false;
            this.Text = Properties.Resources.BestClubsFormTitle;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label goalsLabel;
        private System.Windows.Forms.TextBox goalsTextBox;
        private System.Windows.Forms.Label bestClubsLabel;
        private System.Windows.Forms.ListBox bestClubsListBox;
        private System.Windows.Forms.Button okButton;
    }
}