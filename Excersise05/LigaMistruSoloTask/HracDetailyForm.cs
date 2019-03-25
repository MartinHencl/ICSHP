using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LigaMistruSoloTask
{
    public partial class HracDetailyForm : Form
    {
        Hraci hraci;
        bool editace = false;
        int indexUpravy = -1;

        public HracDetailyForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        public HracDetailyForm(Hraci hraci) : this()
        {
            editace = false;
            this.hraci = hraci;
            KlubComboBox.DisplayMember = "Description";
            KlubComboBox.ValueMember = "Value";
            KlubComboBox.DataSource = Enum.GetValues(typeof(FotbalovyKlub))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
        }

        public HracDetailyForm(Hraci hraci, int indexVybraneho) : this(hraci)
        {
            editace = true;
            string jmeno = hraci[indexVybraneho].Jmeno;
            FotbalovyKlub klub = hraci[indexVybraneho].Klub;
            int goly = hraci[indexVybraneho].GolPocet;
            Hrac hracVybrany = new Hrac(jmeno, klub, goly);
            indexUpravy = indexVybraneho;
            JmenoTextBox.Text = hracVybrany.Jmeno;
            KlubComboBox.SelectedValue = hracVybrany.Klub;
            GolyTextBox.Text = hracVybrany.GolPocet.ToString();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string jmeno = JmenoTextBox.Text;
            Enum.TryParse(KlubComboBox.SelectedValue.ToString(), out FotbalovyKlub klub);
            int.TryParse(GolyTextBox.Text, out int goly);
            if (editace)
            {
                hraci.Uprav(new Hrac(jmeno, klub, goly), indexUpravy);
            }
            else
            {
                hraci.Pridej(new Hrac(jmeno, klub, goly));
            }
            this.Close();
        }

        private void ZrusitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
