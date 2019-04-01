using System;
using System.Collections.Generic;
using System.Linq;

namespace LigaMistruSoloTask
{
    public class Hraci
    {
        private Hrac[] poleHracu;
        private int pocetHracu;
        private Hrac listHracu;
        
        public delegate void PocetZmenenEventHandler(object sender, PocetZmenenEventArgs e);

        public class PocetZmenenEventArgs : EventArgs
        {
            public int PuvodniPocet { get; set; }
        }

        public event PocetZmenenEventHandler PocetZmenen;

        public int Pocet
        {
            get => pocetHracu;
        }
        public Hrac[] PoleHracu { get => poleHracu; set => poleHracu = value; }

        public Hraci()
        {
            PoleHracu = new Hrac[100];
            pocetHracu = 0;
        }

        public void Vymaz(int index)
        {
            for (int i = index; i < Pocet; i++)
            {
                if ((i + 1) >= Pocet)
                {
                    break;
                }
                PoleHracu[i] = PoleHracu[i + 1];
            }
            PoleHracu[Pocet] = null;
            pocetHracu--;
            OnPocetZmenen(pocetHracu + 1);
        }

        public void Pridej(Hrac hracNovy)
        {
            PoleHracu[Pocet] = hracNovy;
            pocetHracu++;
            OnPocetZmenen(pocetHracu - 1);
        }

        internal void Uprav(Hrac hrac, int index)
        {
            PoleHracu[index] = null;
            PoleHracu[index] = hrac;
        }

        public Hrac this[int index]
        {
            get
            {
                if (index < Pocet)
                {
                    if (PoleHracu[index] != null)
                    {
                        return PoleHracu[index];
                    }
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                PoleHracu[index] = value;
            }
        }

        public void NajdiNejlepsiKluby(out FotbalovyKlub[] klubySNejviceGoly, out int pocet)
        {
            klubySNejviceGoly = new FotbalovyKlub[6];
            var golyMapaKlubu = new Dictionary<FotbalovyKlub, int>();
            for (int i = 0; i < Pocet; i++)
            {
                FotbalovyKlub klub = PoleHracu[i].Klub;
                if (!golyMapaKlubu.ContainsKey(klub))
                {
                    golyMapaKlubu.Add(klub, PoleHracu[i].GolPocet);
                }
                else
                {
                    golyMapaKlubu[klub] += PoleHracu[i].GolPocet;
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

            //  Emilova verze
            //  private IEnuremable<(FotbalovyKlub, uint)> NajdiNejKluby()  .......
            //  clubGoals.Where(item => item.Value == clubGoals.Max(pair => pair.Value)
            //           .Select(pair => (pair.Key, pair.Value));
        }

        private void OnPocetZmenen(int puvodniPocetHracu)
        {
            PocetZmenenEventHandler handler = PocetZmenen;
            if (handler != null)
                handler(this, new PocetZmenenEventArgs()
                {
                    PuvodniPocet = puvodniPocetHracu
                });
        }
    }
}
