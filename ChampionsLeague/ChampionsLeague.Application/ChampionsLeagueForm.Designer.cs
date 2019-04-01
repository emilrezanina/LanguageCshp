using System.Windows.Forms;

namespace ChampionsLeague.Application
{
    partial class ChampionsLeagueForm
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
            this.footballersDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.bestPlayerButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.unregisterButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.footballersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // footballersDataGridView
            // 
            this.footballersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.footballersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.footballersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.ClubColumn,
            this.GoalsColumn});
            this.footballersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.footballersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.footballersDataGridView.Name = "footballersDataGridView";
            this.footballersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.footballersDataGridView.Size = new System.Drawing.Size(510, 288);
            this.footballersDataGridView.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // ClubColumn
            // 
            this.ClubColumn.HeaderText = "Club";
            this.ClubColumn.Name = "ClubColumn";
            this.ClubColumn.ReadOnly = true;
            // 
            // GoalsColumn
            // 
            this.GoalsColumn.HeaderText = "Goals";
            this.GoalsColumn.Name = "GoalsColumn";
            this.GoalsColumn.ReadOnly = true;
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 16;
            this.logListBox.Location = new System.Drawing.Point(12, 306);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(619, 132);
            this.logListBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(528, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 25);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButtonClick);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(528, 41);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(103, 25);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButtonClick);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(528, 70);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 25);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit...";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButtonClick);
            // 
            // bestPlayerButton
            // 
            this.bestPlayerButton.Location = new System.Drawing.Point(528, 99);
            this.bestPlayerButton.Name = "bestPlayerButton";
            this.bestPlayerButton.Size = new System.Drawing.Size(103, 25);
            this.bestPlayerButton.TabIndex = 5;
            this.bestPlayerButton.Text = "Best...";
            this.bestPlayerButton.UseVisualStyleBackColor = true;
            this.bestPlayerButton.Click += new System.EventHandler(this.bestPlayerButtonClick);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(528, 128);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(103, 25);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButtonClick);
            // 
            // unregisterButton
            // 
            this.unregisterButton.Location = new System.Drawing.Point(528, 157);
            this.unregisterButton.Name = "unregisterButton";
            this.unregisterButton.Size = new System.Drawing.Size(103, 25);
            this.unregisterButton.TabIndex = 7;
            this.unregisterButton.Text = "Unregister";
            this.unregisterButton.UseVisualStyleBackColor = true;
            this.unregisterButton.Click += new System.EventHandler(this.unregisterButtonClick);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(528, 186);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(103, 25);
            this.endButton.TabIndex = 8;
            this.endButton.Text = "End";
            this.endButton.UseVisualStyleBackColor = true;
            // 
            // ChampionsLeagueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.unregisterButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.bestPlayerButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.footballersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChampionsLeagueForm";
            this.Text = "Champions League";
            ((System.ComponentModel.ISupportInitialize)(this.footballersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView footballersDataGridView;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button bestPlayerButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button unregisterButton;
        private System.Windows.Forms.Button endButton;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ClubColumn;
        private DataGridViewTextBoxColumn GoalsColumn;
    }
}

