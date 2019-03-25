namespace LigaMistruSoloTask
{
    public class Hrac
    {
        public string Jmeno { get; set; }
        public FotbalovyKlub Klub { get; set; }
        public int GolPocet { get; set; }

        public Hrac()
        {

        }
        public Hrac(string jmeno, FotbalovyKlub klub, int goly)
        {
            this.Jmeno = jmeno;
            this.Klub = klub;
            this.GolPocet = goly;
        }
    }
}
