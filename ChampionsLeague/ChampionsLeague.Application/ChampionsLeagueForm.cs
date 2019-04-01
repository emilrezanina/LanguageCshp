using ChampionsLeague.Common;
using System;
using System.Windows.Forms;

namespace ChampionsLeague.Application
{
    public partial class ChampionsLeagueForm : Form
    {
        private Footballers footballers { get; set; }

        private delegate void LogCountChangeHander(uint previousCount, uint newCount);

        private LogCountChangeHander logCountChangeHander = null;

        public ChampionsLeagueForm()
        {
            footballers = new Footballers();
            InitializeComponent();
            RefillFootballersView();
        }

        private void RefillFootballersView()
        {
            footballersDataGridView.Rows.Clear();
            for (uint i = 0; i < footballers.Count; i++)
            {
                footballersDataGridView.Rows.Add(footballers[i].Name,
                    footballers[i].Club.ToString(),
                    footballers[i].GoalCount.ToString());
            }
        }

        private void addButtonClick(object sender, EventArgs e)
        {
            FootballerForm footballerForm = new FootballerForm
            {
                Text = Properties.Resources.CreateFootballerFormTitle
            };
            if (footballerForm.ShowDialog() == DialogResult.OK)
            {
                logCountChangeHander?.Invoke(footballers.Count, footballers.Count + 1);
                footballers.Add(footballerForm.ResultFootballer);
                RefillFootballersView();
            }
        }

        private void removeButtonClick(object sender, EventArgs e)
        {
            if (footballersDataGridView.SelectedRows.Count == 0)
                return;
            logCountChangeHander?.Invoke(footballers.Count, footballers.Count - (uint)footballersDataGridView.SelectedRows.Count);
            bool reorganizeAfter = footballersDataGridView.SelectedRows.Count > 1;
            for (int i = 0; i < footballersDataGridView.SelectedRows.Count; i++)
            {
                footballers.Remove((uint)footballersDataGridView.SelectedRows[i].Index, !reorganizeAfter);
            }
            if (reorganizeAfter)
                footballers.Reorganize();
            RefillFootballersView();
        }

        private bool CorrectSelectedItemForEdit()
        {
            if (footballersDataGridView.SelectedRows.Count == 0)
                return false;
            if (footballersDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show(Properties.Resources.EditMultipleFootballerWarningText, Properties.Resources.ChampionsLeagueFormTitle);
                return false;
            }
            return true;
        }

        private void editButtonClick(object sender, EventArgs e)
        {
            if (!CorrectSelectedItemForEdit())
                return;
            uint index = (uint)footballersDataGridView.SelectedRows[0].Index;
            FootballerForm footballerForm = new FootballerForm(footballers[index].Clone());
            footballerForm.Text = Properties.Resources.EditFootballerFormTitle;
            if (footballerForm.ShowDialog() == DialogResult.OK)
            {
                if (footballers[index] == footballerForm.ResultFootballer)
                    return;
                footballers[index] = footballerForm.ResultFootballer;
                RefillFootballersView();
            }
        }

        private void bestPlayerButtonClick(object sender, EventArgs e)
        {
            BestClubsForm bestClubs = new BestClubsForm(footballers.FindBestFootbalersClubs());
            bestClubs.ShowDialog();
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            logListBox.Items.Add(Properties.Resources.RegisterLogChangeCountHandlerText);
            logCountChangeHander = LogMessageToLogListBox;
        }

        private void unregisterButtonClick(object sender, EventArgs e)
        {
            logListBox.Items.Add(Properties.Resources.UnregisterLogChangeCountHandlerText);
            logCountChangeHander = null;
        }

        private void LogMessageToLogListBox(uint previousCount, uint newCount)
        {
            logListBox.Items.Add(string.Format(Properties.Resources.LogChangeFootballersCountText, previousCount, newCount));
        }
    }
}
