using System;
using System.Windows.Forms;

namespace LigaMistruSoloTask
{
    public partial class NejlepsiKlubyForm : Form
    {
        public NejlepsiKlubyForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        public NejlepsiKlubyForm(Hraci hraci) : this()
        {
            hraci.NajdiNejlepsiKluby(out FotbalovyKlub[] nejlepsiKluby, out int pocet);
            foreach (var klub in nejlepsiKluby)
            {
                if (klub == 0)
                {
                    break;
                }
                KlubyListBox.Items.Add(klub);
            }
            GolyTextBox.Text = pocet.ToString();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
