using System;

namespace LigaMistruSoloTask
{
    class FotbalovyKlubInfo
    {
        public readonly int Pocet = Enum.GetNames(typeof(FotbalovyKlub)).Length;

        public string DejNazev(FotbalovyKlub fk)
        {
            return fk.ToDescriptionString();
        }
    }
}
