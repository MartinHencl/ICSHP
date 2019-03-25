using System;
using System.Collections.Generic;
using System.Linq;

namespace LigaMistruSoloTask
{
    public class Hraci
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
            for (int i = index; i < Pocet; i++)
            {
                if ((i + 1) >= Pocet)
                {
                    break;
                }
                poleHracu[i] = poleHracu[i + 1];
            }
            poleHracu[Pocet] = null;
            Pocet--;
        }

        public void Pridej(Hrac hracNovy)
        {
            poleHracu[Pocet] = hracNovy;
            Pocet++;
        }

        internal void Uprav(Hrac hrac, int index)
        {
            poleHracu[index] = null;
            poleHracu[index] = hrac;
        }

        public Hrac this[int index]
        {
            get
            {
                if (index < Pocet)
                {
                    if (poleHracu[index] != null)
                    {
                        return poleHracu[index];
                    }
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                poleHracu[index] = value;
            }
        }

        public void NajdiNejlepsiKluby(out FotbalovyKlub[] klubySNejviceGoly, out int pocet)
        {
            klubySNejviceGoly = new FotbalovyKlub[6];
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
            pocet = golyKlubyList.Last().Value;
            int indexKlubuSNejGoly = 0;
            for (int i = golyKlubyList.Capacity - 1; i >= 0; i--)
            {
                if (pocet <= golyKlubyList[i].Value)
                {
                    klubySNejviceGoly[indexKlubuSNejGoly++] = golyKlubyList[i].Key;
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
