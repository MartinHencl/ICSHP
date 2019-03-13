using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise04SoloTask
{
    class Stats
    {
        public int Correct { get; set; }
        public int Missed { get; set; }
        public int Accuracy { get; set; }

        public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);
        public event UpdatedStatsEventHandler UpdatedStats;
        private void OnUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        private void Update(bool coorectkey)
        {
            if (coorectkey)
            {
                Correct++;
            } else
            {
                Missed++;
            }
            Accuracy = (int)(Correct / (Correct + Missed)) * 100;

            OnUpdatedStats();
        }

    }
}
