using System;

namespace Excersise04SoloTask
{
    class Stats
    {
        public int Correct { get; private set; }
        public int Missed { get; private set; }
        public int Accuracy { get; private set; }

        public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);

        public event UpdatedStatsEventHandler UpdatedStats;

        private void OnUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        public void Update(bool coorectkey)
        {
            if (coorectkey)
            {
                Correct++;
            } else
            {
                Missed++;
            }
            Accuracy = Correct / (Correct + Missed) * 100;

            OnUpdatedStats();
        }

        public Stats()
        {
            Correct = 0;
            Missed = 0;
            Accuracy = 0;
        }
    }
}
