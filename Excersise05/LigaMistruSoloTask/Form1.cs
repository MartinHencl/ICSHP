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
                    new object[] { hraci[i].Jmeno, hraci[i].Klub.ToString(), hraci[i].GolPocet });
            }
            listHracuDataGridView.Refresh();
        }

        private void GenerujParHracu()
        {
            hraci.Pridej(new Hrac("Karel", FotbalovyKlub.Arsenal, 5));
            hraci.Pridej(new Hrac("Pepa", FotbalovyKlub.Barcelona, 5));
            hraci.Pridej(new Hrac("Igor", FotbalovyKlub.FCPorto, 5));
            hraci.Pridej(new Hrac("Jan", FotbalovyKlub.RealMadrid, 15));
            hraci.Pridej(new Hrac("Někdo", FotbalovyKlub.Arsenal, 15));
        }

        /****** PRIVATE SYSTEM  ******/

        private void PridejButton_Click(object sender, EventArgs e)
        {
            HracDetailyForm formNovyHrac = new HracDetailyForm(hraci);
            formNovyHrac.ShowDialog();
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
    }
}
