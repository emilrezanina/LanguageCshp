using ChampionsLeague.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeague.Application
{
    public partial class BestClubsForm : Form
    {
        public BestClubsForm(IEnumerable<(FootballClub, uint)> data)
        {
            InitializeComponent();
            if (data.Count() == 0)
                return;
            goalsTextBox.Text = data.First().Item2.ToString();
            foreach (var item in data)
            {
                bestClubsListBox.Items.Add(item.Item1);
            }
        }
    }
}
