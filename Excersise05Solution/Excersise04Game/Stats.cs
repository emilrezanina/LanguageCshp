using System;

namespace Excersise04Game
{
    internal class Stats
    {
        public delegate void UpdateStatsEventHandler(object sender, EventArgs e);

        public int Correct { get; private set; }
        public int Missed { get; private set; }
        public int Accuracy
        {
            get
            {
                double accurancy = (double)Correct / (Correct + Missed);
                return (int)Math.Round(accurancy * 100, 0);
            }
        }

        public event UpdateStatsEventHandler UpdatedStats;

        private void OnUpdateStats()
        {
            UpdatedStats?.Invoke(this, new EventArgs());
        }

        public void Update(bool correctKey)
        {
            if (correctKey)
                Correct++;
            else
                Missed++;
            OnUpdateStats();
        }

        public void Clear()
        {
            Correct = 0;
            Missed = 0;
        }
    }
}
