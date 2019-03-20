using Excersise04Game.GameItemGenerator;
using System;
using System.Windows.Forms;

namespace Excersise04Game
{
    public partial class GameForm : Form
    {
        private const int DEFAULT_DIFFICULT = 800;
        private const int MAX_ITEMS_COUNT = 6;

        private IGameItemGenerator generator;
        private Stats stats = new Stats();

        public GameForm()
        {
            InitializeComponent();
            Name = Properties.Resources.ApplicationName;
            generator = new LetterGenerator();
            gameTimer.Interval = DEFAULT_DIFFICULT;
            gameTimer.Stop();
            stats.UpdatedStats += new Stats.UpdateStatsEventHandler(delegate (Object o, EventArgs a)
            {
                correctToolStripStatusLabel.Text = $"Correct: {stats.Correct}";
                missedToolStripStatusLabel.Text = $"Missed: {stats.Missed}";
                accurancyToolStripStatusLabel.Text = $"Accurancy: {stats.Accuracy}%";
            });
        }

        private void TimerTickHandler(object sender, EventArgs eventArgs)
        {
            if (gameItemListBox.Items.Count == MAX_ITEMS_COUNT)
            {
                gameTimer.Stop();
                MessageBox.Show("Game over!", Properties.Resources.ApplicationName);
            }
            else
            {
                gameItemListBox.Items.Add(generator.Next());
            }
        }

        private void DifficultProgressBarActualization()
        {
            difficultToolStripProgressBar.Value = GetNextProgressBarValue();
        }

        private int GetNextProgressBarValue()
        {
            int progressBarValue = 800 - gameTimer.Interval;
            if (progressBarValue < 0)
                progressBarValue = 0;
            else if (progressBarValue > 800)
                progressBarValue = 800;
            return progressBarValue;
        }

        private void GameAccelerate()
        {
            if (gameTimer.Interval > 400)
                gameTimer.Interval -= 60;
            else if (gameTimer.Interval > 250)
                gameTimer.Interval -= 15;
            else
                gameTimer.Interval -= 8;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGameData();
            gameTimer.Start();
        }

        private void ClearGameData()
        {
            stats.Clear();
            gameTimer.Interval = DEFAULT_DIFFICULT;
            gameItemListBox.Items.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            MessageBox.Show(Properties.Resources.AboutMessage, Properties.Resources.ApplicationName);
        }

        private void gameItemListBox_KeyDown(object sender, KeyEventArgs e)
        {
            bool correctKey = gameItemListBox.Items.Contains(e.KeyCode);
            if (correctKey)
            {
                gameItemListBox.Items.Remove(e.KeyCode);
                gameItemListBox.Refresh();
            }
            GameAccelerate();
            DifficultProgressBarActualization();
            stats.Update(correctKey);
        }

        private void CheckDifficultMenuItem(ToolStripMenuItem difficultGroup, ToolStripMenuItem checkedItem)
        {
            foreach (ToolStripMenuItem item in difficultGroup.DropDownItems)
            {
                if (item is ToolStripMenuItem itemWithState)
                {
                    itemWithState.Checked = itemWithState == checkedItem;
                }
            }
        }

        private void DifficultModeClick(object sender, EventArgs e)
        {
            StopGame();
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            CheckDifficultMenuItem(difficultToolStripMenuItem, item);
            SetGenerator(item);
        }

        private void SetGenerator(ToolStripMenuItem item)
        {
            if (item == advancedToolStripMenuItem)
            {
                if (!(generator is CharacterGenerator))
                    generator = new CharacterGenerator();
            }
            else
            {
                if (!(generator is LetterGenerator))
                    generator = new LetterGenerator();
            }
        }

        private void StopGame()
        {
            gameTimer.Stop();
            ClearGameData();
        }
    }
}
