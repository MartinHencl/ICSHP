using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SemPraceMain
{
    abstract class HerniObjekt
    {
        private int poziceX;
        private int poziceY;
        private int velikostPolomer;
        private Color barvaMajitele;
        private bool dokonceno;

        internal int VelikostPolomer { get => velikostPolomer; set => velikostPolomer = value; }
        internal int PoziceX { get => poziceX; set => poziceX = value; }
        internal int PoziceY { get => poziceY; set => poziceY = value; }
        internal bool Dokonceno { get => dokonceno; set => dokonceno = value; }
        internal Color BarvaMajitele { get => barvaMajitele; set => barvaMajitele = value; }

        internal virtual void Aktualizace(uint pocetNovychMilisekund)
        {

        }
    }
}
