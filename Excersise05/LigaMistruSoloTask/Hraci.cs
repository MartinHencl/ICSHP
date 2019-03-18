using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaMistruSoloTask
{
    class Hraci
    {
        public Hrac[] poleHracu;
        public int Pocet { get; set; }

        public Hraci()
        {
            poleHracu = new Hrac[100];
            Pocet = 0;
        }

        public void Vymaz(int index)
        {
            poleHracu[index] = null;

            A TADY TO TROCHU ODROTOVAT ABYCH NEMEL DIRY
        }

        public void Pridej(Hrac hracNovy)
        {
            ++Pocet;
        }

        public Hrac this[int index]
        {
            get
            {
                return poleHracu[index];
            }
            set
            {
                poleHracu[index] = value;
            }
        }
        
        public void NajdiNejlepsiKluby(out FotbalovyKlub klub, out int pocet)
        {
            klub = new FotbalovyKlub();
            pocet = 0;
        }

        public delegate void PocetZmenenEventHandler(object sender, EventArgs e);

        public event PocetZmenenEventHandler PocetZmenen;

        private void OnPocetZmenen()
        {
            PocetZmenenEventHandler handler = PocetZmenen;
            if (handler != null)
                handler(this, new EventArgs());
        }
    }
}
