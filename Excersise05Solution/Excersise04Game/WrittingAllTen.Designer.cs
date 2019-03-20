namespace Excersise04Game
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accurancyToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.gameItemListBox = new System.Windows.Forms.ListBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.spaceAfterProgressBarToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // difficultToolStripMenuItem
            // 
            this.difficultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.difficultToolStripMenuItem.Name = "difficultToolStripMenuItem";
            this.difficultToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.difficultToolStripMenuItem.Text = "Difficult";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Checked = true;
            this.easyToolStripMenuItem.CheckOnClick = true;
            this.easyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.DifficultModeClick);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.CheckOnClick = true;
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.advancedToolStripMenuItem.Text = "Advanced";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.DifficultModeClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctToolStripStatusLabel,
            this.missedToolStripStatusLabel,
            this.accurancyToolStripStatusLabel,
            this.difficultyToolStripStatusLabel,
            this.difficultToolStripProgressBar,
            this.spaceAfterProgressBarToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 161);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1293, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip";
            // 
            // correctToolStripStatusLabel
            // 
            this.correctToolStripStatusLabel.Name = "correctToolStripStatusLabel";
            this.correctToolStripStatusLabel.Size = new System.Drawing.Size(72, 20);
            this.correctToolStripStatusLabel.Text = "Correct: 0";
            // 
            // missedToolStripStatusLabel
            // 
            this.missedToolStripStatusLabel.Name = "missedToolStripStatusLabel";
            this.missedToolStripStatusLabel.Size = new System.Drawing.Size(70, 20);
            this.missedToolStripStatusLabel.Text = "Missed: 0";
            // 
            // accurancyToolStripStatusLabel
            // 
            this.accurancyToolStripStatusLabel.Name = "accurancyToolStripStatusLabel";
            this.accurancyToolStripStatusLabel.Size = new System.Drawing.Size(103, 20);
            this.accurancyToolStripStatusLabel.Text = "Accurancy: 0%";
            // 
            // difficultyToolStripStatusLabel
            // 
            this.difficultyToolStripStatusLabel.Name = "difficultyToolStripStatusLabel";
            this.difficultyToolStripStatusLabel.Size = new System.Drawing.Size(892, 20);
            this.difficultyToolStripStatusLabel.Spring = true;
            this.difficultyToolStripStatusLabel.Text = "Dificult:";
            this.difficultyToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultToolStripProgressBar
            // 
            this.difficultToolStripProgressBar.Maximum = 800;
            this.difficultToolStripProgressBar.Name = "difficultToolStripProgressBar";
            this.difficultToolStripProgressBar.Size = new System.Drawing.Size(100, 19);
            this.difficultToolStripProgressBar.Value = 0;
            // 
            // gameItemListBox
            // 
            this.gameItemListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameItemListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameItemListBox.FormattingEnabled = true;
            this.gameItemListBox.ItemHeight = 91;
            this.gameItemListBox.Location = new System.Drawing.Point(0, 28);
            this.gameItemListBox.MultiColumn = true;
            this.gameItemListBox.Name = "gameItemListBox";
            this.gameItemListBox.Size = new System.Drawing.Size(1293, 133);
            this.gameItemListBox.TabIndex = 2;
            this.gameItemListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameItemListBox_KeyDown);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 800;
            this.gameTimer.Tick += new System.EventHandler(this.TimerTickHandler);
            // 
            // spaceAfterProgressBarToolStripStatusLabel
            // 
            this.spaceAfterProgressBarToolStripStatusLabel.Name = "spaceAfterProgressBarToolStripStatusLabel";
            this.spaceAfterProgressBarToolStripStatusLabel.Size = new System.Drawing.Size(13, 20);
            this.spaceAfterProgressBarToolStripStatusLabel.Text = " ";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 186);
            this.Controls.Add(this.gameItemListBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "Writing all ten";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel accurancyToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel difficultyToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar difficultToolStripProgressBar;
        private System.Windows.Forms.ListBox gameItemListBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ToolStripStatusLabel spaceAfterProgressBarToolStripStatusLabel;
    }
}

