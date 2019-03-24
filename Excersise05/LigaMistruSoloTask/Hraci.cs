using System;
using System.Collections.Generic;
using System.Linq;

namespace LigaMistruSoloTask
{
    class Hraci
    {
        public Hrac[] poleHracu;
        public int Pocet { get; private set; }

        public Hraci()
        {
            poleHracu = new Hrac[100];
            Pocet = 0;
        }

        public void Vymaz(int index)
        {
            for (int i = Pocet; i > index; i--)
            {
                poleHracu[i - 1] = poleHracu[i];
            }
            poleHracu[Pocet] = null;
            Pocet--;
        }

        public void Pridej(Hrac hracNovy)
        {
            poleHracu[Pocet] = hracNovy;
            Pocet++;
        }

        public Hrac this[int index]
        {
            get
            {
                if (index < Pocet)
                {
                    return poleHracu[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                poleHracu[index] = value;
            }
        }

        public void NajdiNejlepsiKluby(out FotbalovyKlub[] klubySNejviceGoly, out int pocet)
        {
            klubySNejviceGoly = new FotbalovyKlub[6];
            pocet = 0;
            var golyMapaKlubu = new Dictionary<FotbalovyKlub, int>();
            for (int i = 0; i < Pocet; i++)
            {
                FotbalovyKlub klub = poleHracu[i].Klub;
                if (!golyMapaKlubu.ContainsKey(klub))
                {
                    golyMapaKlubu.Add(klub, poleHracu[i].GolPocet);
                }
                else
                {
                    golyMapaKlubu[klub] += poleHracu[i].GolPocet;
                }
            }

            var golyKlubyList = golyMapaKlubu.ToList();
            golyKlubyList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            int nejvicGolu = golyKlubyList.Last().Value;

            for (int i = golyKlubyList.Capacity - 1; i >= 0; i--)
            {
                if (nejvicGolu <= golyKlubyList[i].Value)
                {
                    klubySNejviceGoly[pocet++] = golyKlubyList[i].Key;
                }
                else
                {
                    break;
                }
            }
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
