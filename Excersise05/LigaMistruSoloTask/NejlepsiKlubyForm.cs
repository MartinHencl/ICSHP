using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
