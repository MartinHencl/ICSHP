using System;
using System.Windows;

namespace SemPraceMain
{
    class RandomProKazdouPrilezitost
    {
        // statick aby se ti negenoroval neustále nový random generátor pak negeneruje příliš náhodná čísla
        // DateTime.Now.Millisecond pro náhodnější generování násada
        private static Random randomBase = new Random(DateTime.Now.Millisecond);

        internal Point GenerujStredPlanety(int velikostPlanetyPolomer, double maxX, double maxY)
        {
            int minimum = velikostPlanetyPolomer + 1;
            double maximumX = maxX - velikostPlanetyPolomer + 1;
            double maximumY = maxY - velikostPlanetyPolomer + 1;
            Point novyStred = new Point(randomBase.Next(minimum, (int)maximumX), randomBase.Next(minimum, (int)maximumY));
            return novyStred;
        }

        internal int GenerujPolomerPlanety(int minimalniVelikost, int maximalniVelikost)
        {
            return randomBase.Next(minimalniVelikost, maximalniVelikost + 1);
        }
    }
}
