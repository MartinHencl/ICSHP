using System;
using System.Collections.Generic;
using System.Windows;

namespace SemPraceMain
{
    internal class Planeta : HerniObjekt
    {
        internal const uint pocetHranicnichBodu = 32;
        internal const double nasobekPolomeruProKontaktniBody = 1.0;
        internal const double nasobekPolomeruProObletovouDrahu = 1.4;

        internal readonly List<Point> kontaktniBodyPlanety;
        internal readonly List<Point> obletoveBodyPlanety;
        internal uint pocetJednotek;
        private double maxVelikostHernihoPoleX;
        private double maxVelikostHernihoPoleY;

        public double MaxVelikostHernihoPoleX { get => maxVelikostHernihoPoleX; set => maxVelikostHernihoPoleX = value; }
        public double MaxVelikostHernihoPoleY { get => maxVelikostHernihoPoleY; set => maxVelikostHernihoPoleY = value; }

        public Planeta(double maxVelikostHernihoPoleX, double maxVelikostHernihoPoleY)
        {
            this.MaxVelikostHernihoPoleX = maxVelikostHernihoPoleX;
            this.MaxVelikostHernihoPoleY = maxVelikostHernihoPoleY;

            RandomProKazdouPrilezitost randomMuj = new RandomProKazdouPrilezitost();

            Velikost = randomMuj.GenerujVelikostPlanety();

            Point stred = randomMuj.GenerujStredPlanety(Velikost, MaxVelikostHernihoPoleX, MaxVelikostHernihoPoleY);
            this.PoziceX = Convert.ToInt32(stred.X);
            this.PoziceY = Convert.ToInt32(stred.Y);
        }
        internal override void Aktualizace(uint pocetNovychMilisekund)
        {
            base.Aktualizace(pocetNovychMilisekund);
            //Pokud je planeta neutrální – nedělej nic
            //▪ Pokud je počet jednotek roven maximu(velikost planety *3)
            //▪ Pokud uplynul stanovený čas – zvyš počet jednotek o jedna
            //• ts = velikost <= 32 ? velikost – 8 : velikost
            //• aktualizační čas v ms = (Log10(50 – ts) * 10) / 20
        }

        internal void PriletVesmirneLode(VesmirnaLod vesmirnaLod)
        {
            //Pokud majitel vesmírné lodě je stejný jako majitel planety – zvyšte počet jednotek na
            //planetě o počet jednotek na lodi
            //▪ Jinak snižte počet jednotek o počet jednotek na lodi
            //• Pokud je počet záporný – planeta mění majitele na majitele lodi
        }

    }
}
