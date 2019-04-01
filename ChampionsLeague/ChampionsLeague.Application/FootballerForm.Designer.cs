using ChampionsLeague.Common;
using System;

namespace ChampionsLeague.Application
{
    partial class FootballerForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.clubLabel = new System.Windows.Forms.Label();
            this.goalsLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.footballClubComboBox = new System.Windows.Forms.ComboBox();
            this.goalsTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // clubLabel
            // 
            this.clubLabel.AutoSize = true;
            this.clubLabel.Location = new System.Drawing.Point(12, 38);
            this.clubLabel.Name = "clubLabel";
            this.clubLabel.Size = new System.Drawing.Size(36, 17);
            this.clubLabel.TabIndex = 1;
            this.clubLabel.Text = "Club";
            // 
            // goalsLabel
            // 
            this.goalsLabel.AutoSize = true;
            this.goalsLabel.Location = new System.Drawing.Point(12, 73);
            this.goalsLabel.Name = "goalsLabel";
            this.goalsLabel.Size = new System.Drawing.Size(45, 17);
            this.goalsLabel.TabIndex = 2;
            this.goalsLabel.Text = "Goals";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(89, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(222, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // footballClubComboBox
            // 
            this.footballClubComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.footballClubComboBox.FormattingEnabled = true;
            this.footballClubComboBox.Items.AddRange(new object[] {
            ChampionsLeague.Common.FootballClub.None,
            ChampionsLeague.Common.FootballClub.FCPorto,
            ChampionsLeague.Common.FootballClub.Arsenal,
            ChampionsLeague.Common.FootballClub.RealMadrid,
            ChampionsLeague.Common.FootballClub.Chelsea,
            ChampionsLeague.Common.FootballClub.Barcelone});
            this.footballClubComboBox.Location = new System.Drawing.Point(190, 35);
            this.footballClubComboBox.Name = "footballClubComboBox";
            this.footballClubComboBox.Size = new System.Drawing.Size(121, 24);
            this.footballClubComboBox.TabIndex = 4;
            // 
            // goalsTextBox
            // 
            this.goalsTextBox.Location = new System.Drawing.Point(211, 70);
            this.goalsTextBox.Name = "goalsTextBox";
            this.goalsTextBox.Size = new System.Drawing.Size(100, 22);
            this.goalsTextBox.TabIndex = 5;
            this.goalsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goalsTextBoxKeyPress);
            this.goalsTextBox.ShortcutsEnabled = false;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(155, 114);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(236, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // FootballerForm
            // 
            this.AcceptButton = this.okButton;
            this.CancelButton = this.cancelButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 149);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.goalsTextBox);
            this.Controls.Add(this.footballClubComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.goalsLabel);
            this.Controls.Add(this.clubLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FootballerForm";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.footballerFormFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label clubLabel;
        private System.Windows.Forms.Label goalsLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox footballClubComboBox;
        private System.Windows.Forms.TextBox goalsTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}