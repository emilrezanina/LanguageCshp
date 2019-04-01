using ChampionsLeague.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChampionsLeague.Application
{
    public partial class FootballerForm : Form
    {
        public Footballer ResultFootballer { get; set; }

        public FootballerForm()
        {
            ResultFootballer = new Footballer();
            Initialize();
        }

        public FootballerForm(Footballer footballer)
        {
            ResultFootballer = footballer;
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            InitializeFootballerUI();
        }

        private void InitializeFootballerUI()
        {
            nameTextBox.Text = ResultFootballer.Name;
            footballClubComboBox.SelectedItem = ResultFootballer.Club;
            goalsTextBox.Text = ResultFootballer.GoalCount.ToString();
        }

        private void goalsTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void okButtonClick(object sender, EventArgs e)
        {
            ResultFootballer.Name = nameTextBox.Text;
            ResultFootballer.Club = (FootballClub)footballClubComboBox.SelectedItem;
            ResultFootballer.GoalCount = uint.Parse(goalsTextBox.Text);
        }

        private void footballerFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                if (MessageBox.Show(Properties.Resources.WithoutNameFootballerFormWarningText, Text,
                   MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
