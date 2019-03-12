namespace MessageLogger
{
    partial class MessageLoggerApplicationForm
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
            this.SendButton = new System.Windows.Forms.Button();
            this.RightPanelCheckBox = new System.Windows.Forms.CheckBox();
            this.LeftPanelCheckBox = new System.Windows.Forms.CheckBox();
            this.InputMessageEditControl = new System.Windows.Forms.TextBox();
            this.LeftOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.LeftOutputTextBox = new System.Windows.Forms.TextBox();
            this.RightOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.RightOutputTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.LeftOutputGroupBox.SuspendLayout();
            this.RightOutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(421, 73);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // RightPanelCheckBox
            // 
            this.RightPanelCheckBox.AutoSize = true;
            this.RightPanelCheckBox.Location = new System.Drawing.Point(218, 12);
            this.RightPanelCheckBox.Name = "RightPanelCheckBox";
            this.RightPanelCheckBox.Size = new System.Drawing.Size(102, 21);
            this.RightPanelCheckBox.TabIndex = 1;
            this.RightPanelCheckBox.Text = "Right panel";
            this.RightPanelCheckBox.UseVisualStyleBackColor = true;
            // 
            // LeftPanelCheckBox
            // 
            this.LeftPanelCheckBox.AutoSize = true;
            this.LeftPanelCheckBox.Location = new System.Drawing.Point(12, 12);
            this.LeftPanelCheckBox.Name = "LeftPanelCheckBox";
            this.LeftPanelCheckBox.Size = new System.Drawing.Size(93, 21);
            this.LeftPanelCheckBox.TabIndex = 2;
            this.LeftPanelCheckBox.Text = "Left panel";
            this.LeftPanelCheckBox.UseVisualStyleBackColor = true;
            this.LeftPanelCheckBox.CheckedChanged += new System.EventHandler(this.OutputEnabledCheckBox_CheckedChanged);
            // 
            // InputMessageEditControl
            // 
            this.InputMessageEditControl.Location = new System.Drawing.Point(9, 73);
            this.InputMessageEditControl.Multiline = true;
            this.InputMessageEditControl.Name = "InputMessageEditControl";
            this.InputMessageEditControl.Size = new System.Drawing.Size(406, 70);
            this.InputMessageEditControl.TabIndex = 4;
            // 
            // LeftOutputGroupBox
            // 
            this.LeftOutputGroupBox.Controls.Add(this.LeftOutputTextBox);
            this.LeftOutputGroupBox.Location = new System.Drawing.Point(9, 150);
            this.LeftOutputGroupBox.Name = "LeftOutputGroupBox";
            this.LeftOutputGroupBox.Size = new System.Drawing.Size(200, 334);
            this.LeftOutputGroupBox.TabIndex = 8;
            this.LeftOutputGroupBox.TabStop = false;
            this.LeftOutputGroupBox.Text = "Left output";
            // 
            // LeftOutputTextBox
            // 
            this.LeftOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftOutputTextBox.Enabled = false;
            this.LeftOutputTextBox.Location = new System.Drawing.Point(3, 18);
            this.LeftOutputTextBox.Multiline = true;
            this.LeftOutputTextBox.Name = "LeftOutputTextBox";
            this.LeftOutputTextBox.Size = new System.Drawing.Size(194, 313);
            this.LeftOutputTextBox.TabIndex = 0;
            // 
            // RightOutputGroupBox
            // 
            this.RightOutputGroupBox.Controls.Add(this.RightOutputTextBox);
            this.RightOutputGroupBox.Location = new System.Drawing.Point(215, 150);
            this.RightOutputGroupBox.Name = "RightOutputGroupBox";
            this.RightOutputGroupBox.Size = new System.Drawing.Size(200, 334);
            this.RightOutputGroupBox.TabIndex = 9;
            this.RightOutputGroupBox.TabStop = false;
            this.RightOutputGroupBox.Text = "Right output";
            // 
            // RightOutputTextBox
            // 
            this.RightOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightOutputTextBox.Enabled = false;
            this.RightOutputTextBox.Location = new System.Drawing.Point(3, 18);
            this.RightOutputTextBox.Multiline = true;
            this.RightOutputTextBox.Name = "RightOutputTextBox";
            this.RightOutputTextBox.Size = new System.Drawing.Size(194, 313);
            this.RightOutputTextBox.TabIndex = 0;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 50);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(43, 17);
            this.InputLabel.TabIndex = 10;
            this.InputLabel.Text = "Input:";
            // 
            // MessageLoggerApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 486);
            this.Controls.Add(this.LeftPanelCheckBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.RightPanelCheckBox);
            this.Controls.Add(this.RightOutputGroupBox);
            this.Controls.Add(this.LeftOutputGroupBox);
            this.Controls.Add(this.InputMessageEditControl);
            this.Controls.Add(this.SendButton);
            this.Name = "MessageLoggerApplicationForm";
            this.Text = "Message Logger Application";
            this.LeftOutputGroupBox.ResumeLayout(false);
            this.LeftOutputGroupBox.PerformLayout();
            this.RightOutputGroupBox.ResumeLayout(false);
            this.RightOutputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.CheckBox RightPanelCheckBox;
        private System.Windows.Forms.CheckBox LeftPanelCheckBox;
        private System.Windows.Forms.TextBox InputMessageEditControl;
        private System.Windows.Forms.GroupBox LeftOutputGroupBox;
        private System.Windows.Forms.GroupBox RightOutputGroupBox;
        private System.Windows.Forms.TextBox RightOutputTextBox;
        private System.Windows.Forms.TextBox LeftOutputTextBox;
        private System.Windows.Forms.Label InputLabel;
    }
}

