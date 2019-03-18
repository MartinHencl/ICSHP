namespace LigaMistruSoloTask
{
    class FotbalovyKlubInfo
    {
        public readonly int Pocet;

        public string DejNazev(FotbalovyKlub fk)
        {
            return fk.ToDescriptionString();
        }
    }
}
