using System.Collections.Generic;
using System.Windows;

namespace SemPraceMain
{
    class VesmirnaLod : HerniObjekt
    {
        internal Planeta vychoziPlaneta;
        internal Planeta cilovaPlaneta;
        internal uint pocetJednotekNaLodi;
        internal List<Point> cestaVesmirneLodi;
        internal uint odletnutaVzdalenost;

        internal override void Aktualizace(uint pocetNovychMilisekund)
        {
            base.Aktualizace(pocetNovychMilisekund);
            //Loď se posune o uplynulý čas[ms] / 8
            //▪ Pokud dosáhne cíle, vyvolá metodu „při příletu na planetu“ nad cílovou planetou a označí
            //příznak „dokončení“ v aktuálním obj
        }

        internal void PoziceLodi()
        {
            //  Vypočítá souřadnice lodi v prostoru na základě odlétnuté vzdálenosti a vypočítané cesty lodi
        }
    }
}
