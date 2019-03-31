using System;
using System.Windows.Forms;

namespace LigaMistruSoloTask
{
    public partial class LigaMistruForm : Form
    {
        Hraci hraci;

        public LigaMistruForm()
        {
            hraci = new Hraci();
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Liga Mistrů";
            DataGridNastaveni();
            GenerujParHracu();
            ObnovDataGridHracu();
        }

        /****** PRIVATE OWN ******/
        private void DataGridNastaveni()
        {
            listHracuDataGridView.ColumnCount = 3;
            listHracuDataGridView.Columns[0].Name = "Jméno";
            listHracuDataGridView.Columns[0].ReadOnly = true;
            listHracuDataGridView.Columns[1].Name = "Klub";
            listHracuDataGridView.Columns[1].ReadOnly = true;
            listHracuDataGridView.Columns[2].Name = "Góly";
            listHracuDataGridView.Columns[2].ReadOnly = true;
            listHracuDataGridView.Rows.Clear();
            listHracuDataGridView.Refresh();
        }

        private void ObnovDataGridHracu()
        {
            listHracuDataGridView.Rows.Clear();
            for (int i = 0; i < hraci.Pocet; i++)
            {
                listHracuDataGridView.Rows.Add(
                    new object[] { hraci[i].Jmeno, hraci[i].Klub.GetDescription(), hraci[i].GolPocet });
            }
            listHracuDataGridView.Refresh();
        }

        private void GenerujParHracu()
        {
            Random rand = new Random();
            int index = -1;
            hraci.Pridej(new Hrac("Karel" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Pepa" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Igor" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Jan" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Někdo" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Karel" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Pepa" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Igor" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Jan" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Někdo" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Karel" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Pepa" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Igor" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Jan" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Někdo" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Karel" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Pepa" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Igor" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Jan" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
            hraci.Pridej(new Hrac("Někdo" + ++index, (FotbalovyKlub)rand.Next(1, 7), rand.Next(1, 8)));
        }

        /****** PRIVATE SYSTEM  ******/

        private void PridejButton_Click(object sender, EventArgs e)
        {
            HracDetailyForm formNovyHrac = new HracDetailyForm(hraci);
            formNovyHrac.ShowDialog(this);
            ObnovDataGridHracu();
        }

        private void VymazButton_Click(object sender, EventArgs e)
        {
            int itemIndex = listHracuDataGridView.SelectedCells[0].RowIndex;
            hraci.Vymaz(itemIndex);
            ObnovDataGridHracu();
            
        }

        private void UpravitButton_Click(object sender, EventArgs e)
        {
            int vybranyIndex = listHracuDataGridView.CurrentCell.RowIndex;
            HracDetailyForm formUpravitHrac = new HracDetailyForm(hraci, vybranyIndex);
            formUpravitHrac.ShowDialog(this);
            ObnovDataGridHracu();
        }

        private void NejlepsiButton_Click(object sender, EventArgs e)
        {
            NejlepsiKlubyForm formKluby = new NejlepsiKlubyForm(hraci);
            formKluby.ShowDialog(this);
            ObnovDataGridHracu();
        }

        private void KonecButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrovatButton_Click(object sender, EventArgs e)
        {
            hraci.PocetZmenen += new Hraci.PocetZmenenEventHandler(Hraci_PocetZmenen);
            LogyTextBox.Text += "Handler pridan" + "\r\n";
        }

        private void ZrusitButton_Click(object sender, EventArgs e)
        {
            hraci.PocetZmenen -= new Hraci.PocetZmenenEventHandler(Hraci_PocetZmenen);
            LogyTextBox.Text += "Handler odebran" + "\r\n";
        }

        private void Hraci_PocetZmenen(object sender, EventArgs e)
        {
            LogyTextBox.Text += "Event procnul ";
            LogyTextBox.Text += hraci.Pocet;
            LogyTextBox.Text += "\r\n";
        }
    }
}
