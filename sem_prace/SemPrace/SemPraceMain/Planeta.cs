using System;
using System.Collections.Generic;
using System.Windows;

namespace SemPraceMain
{
    internal class Planeta : HerniObjekt
    {
        internal const int pocetHranicnichBodu = 32;
        internal const double nasobekPolomeruProKontaktniBody = 1.0;
        internal const double nasobekPolomeruProObletovouDrahu = 1.4;
        internal const int minimalniVelikost = 16;
        internal const int maximalniVelikost = 48;

        internal readonly List<Point> kontaktniBodyPlanety;
        internal readonly List<Point> obletoveBodyPlanety;
        internal uint pocetJednotek;
        private double maxVelikostHernihoPoleX;
        private double maxVelikostHernihoPoleY;

        public double MaxVelikostHernihoPoleX { get => maxVelikostHernihoPoleX; set => maxVelikostHernihoPoleX = value; }
        public double MaxVelikostHernihoPoleY { get => maxVelikostHernihoPoleY; set => maxVelikostHernihoPoleY = value; }

        public Planeta(double maxVelikostHernihoPoleX, double maxVelikostHernihoPoleY)
        {
            throw new NotImplementedException();
        }

        public Planeta(double maxVelikostHernihoPoleX, double maxVelikostHernihoPoleY, List<HerniObjekt> seznamHernichObjektu)
        {
            this.MaxVelikostHernihoPoleX = maxVelikostHernihoPoleX;
            this.MaxVelikostHernihoPoleY = maxVelikostHernihoPoleY;

            RandomProKazdouPrilezitost randomMuj = new RandomProKazdouPrilezitost();

            VelikostPolomer = randomMuj.GenerujPolomerPlanety(minimalniVelikost, maximalniVelikost);

            Point stred = new Point();
            bool jeSpravneUmistena = false;
            while (!jeSpravneUmistena)
            {
                stred = randomMuj.GenerujStredPlanety((int)(VelikostPolomer * nasobekPolomeruProObletovouDrahu), MaxVelikostHernihoPoleX, MaxVelikostHernihoPoleY);
                jeSpravneUmistena = KontrolaPoziceVzhledemKOstatnimPlanetam(stred, VelikostPolomer, seznamHernichObjektu);
            }
            this.PoziceX = Convert.ToInt32(stred.X);
            this.PoziceY = Convert.ToInt32(stred.Y);
            this.kontaktniBodyPlanety = PohybPoKruznici(stred, (int)(VelikostPolomer * nasobekPolomeruProKontaktniBody), pocetHranicnichBodu);
            this.obletoveBodyPlanety = PohybPoKruznici(stred, (int)(VelikostPolomer * nasobekPolomeruProObletovouDrahu), pocetHranicnichBodu);
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

        private bool KontrolaPoziceVzhledemKOstatnimPlanetam(Point planetka1Stred, int planetka1VelikostPolomer, List<HerniObjekt> seznamHernichObjektu)
        {
            if (seznamHernichObjektu != null)
            {
                if (seznamHernichObjektu.Count == 0)
                {
                    return true;
                }
                foreach (var teleso in seznamHernichObjektu)
                {
                    if (teleso is Planeta)
                    {
                        int vysledekPocetPruniku = FindCircleCircleIntersections(
                                planetka1Stred.X, planetka1Stred.Y, planetka1VelikostPolomer * nasobekPolomeruProObletovouDrahu,
                                teleso.PoziceX, teleso.PoziceY, teleso.VelikostPolomer * nasobekPolomeruProObletovouDrahu,
                                out Point prunik1, out Point prunik2);
                        if (vysledekPocetPruniku != 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            throw new NullReferenceException($"seznamHernichObjektu je null");
        }

        // Find the points where the two circles intersect.
        private int FindCircleCircleIntersections(
            double cx0, double cy0, double radius0,
            double cx1, double cy1, double radius1,
            out Point intersection1, out Point intersection2)
        {
            // Find the distance between the centers.
            double dx = cx0 - cx1;
            double dy = cy0 - cy1;
            double dist = Math.Sqrt(dx * dx + dy * dy);

            // See how many solutions there are.
            if (dist > radius0 + radius1)
            {
                // No solutions, the circles are too far apart.
                intersection1 = new Point(double.NaN, double.NaN);
                intersection2 = new Point(double.NaN, double.NaN);
                return 0;
            }
            else if (dist < Math.Abs(radius0 - radius1))
            {
                // No solutions, one circle contains the other.
                intersection1 = new Point(double.NaN, double.NaN);
                intersection2 = new Point(double.NaN, double.NaN);
                return 0;
            }
            else if ((dist == 0) && (radius0 == radius1))
            {
                // No solutions, the circles coincide.
                intersection1 = new Point(double.NaN, double.NaN);
                intersection2 = new Point(double.NaN, double.NaN);
                return 0;
            }
            else
            {
                // Find a and h.
                double a = (radius0 * radius0 -
                    radius1 * radius1 + dist * dist) / (2 * dist);
                double h = Math.Sqrt(radius0 * radius0 - a * a);

                // Find P2.
                double cx2 = cx0 + a * (cx1 - cx0) / dist;
                double cy2 = cy0 + a * (cy1 - cy0) / dist;

                // Get the points P3.
                intersection1 = new Point(
                    (double)(cx2 + h * (cy1 - cy0) / dist),
                    (double)(cy2 - h * (cx1 - cx0) / dist));
                intersection2 = new Point(
                    (double)(cx2 - h * (cy1 - cy0) / dist),
                    (double)(cy2 + h * (cx1 - cx0) / dist));

                // See if we have 1 or 2 solutions.
                if (dist == radius0 + radius1) return 1;
                return 2;
            }
        }

        private List<Point> PohybPoKruznici(Point stredPlanety, int polomerPlanety, int pocetBodu)
        {
            double uhel = 0;
            double px, py;
            var bodyKruhu = new List<Point>();

            while (uhel <= 2 * Math.PI)
            {
                px = Math.Round(stredPlanety.X + Math.Cos(uhel) * polomerPlanety);
                py = Math.Round(stredPlanety.Y + Math.Sin(uhel) * polomerPlanety);
                bodyKruhu.Add(new Point((int)px, (int)py));
                uhel += 0.0175 * 360 / pocetBodu;
            }

            return bodyKruhu;
        }
    }
}
