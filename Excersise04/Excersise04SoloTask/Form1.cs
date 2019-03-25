using System;
using System.Windows.Forms;

namespace Excersise04SoloTask
{
    public partial class LetterGuesser : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        
        public LetterGuesser()
        {
            stats.UpdatedStats += Stats_UpdatedStats;
            InitializeComponent();
            this.Name = Properties.Resources.ApplicationTitle;
            this.Text = Properties.Resources.ApplicationTitle;
        }

        private void Stats_UpdatedStats(object sender, EventArgs e)
        {
            correctLabel.Text = stats.Correct.ToString();
            missedLabel.Text = stats.Missed.ToString();
            accurancyLabel.Text = stats.Accuracy.ToString() + " %";
        }

        private void Tick(object sender, EventArgs e)
        {
            if (gameListBox.Items.Count > 6)
            {
                timer.Stop();
                gameListBox.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.ListBoxKeyDown);
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game Over!");
            }
            else
            {
                gameListBox.Items.Add((Keys)random.Next(65, 91));
            }
        }

        private void ListBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (gameListBox.Items.Contains(e.KeyCode))
            {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();

                if (timer.Interval >= 400)
                {
                    timer.Interval -= 60;
                }
                else if (timer.Interval >= 250)
                {
                    timer.Interval -= 15;
                }
                else if (timer.Interval >= 150)
                {
                    timer.Interval -= 8;
                }
                if (timer.Interval > 800)
                {
                    timer.Interval = 800;
                }
                else if (timer.Interval <= 0)
                {
                    timer.Interval = 1;
                }
                int difficulty = 800 - timer.Interval;
                difficultProgressBar.Value = difficulty;

                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

        }
    }
}
