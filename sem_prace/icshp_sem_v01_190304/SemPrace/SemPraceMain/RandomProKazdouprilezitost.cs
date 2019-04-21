using System;
using System.Windows;

namespace SemPraceMain
{
    class RandomProKazdouPrilezitost
    {
        Random randomBase = new Random();

        internal Point GenerujStredPlanety(int velikostPlanety, double maxX, double maxY)
        {
            int minimum = velikostPlanety / 2 + 1;
            double maximumX = maxX - velikostPlanety / 2 + 1;
            double maximumY = maxY - velikostPlanety / 2 + 1;
            Point novyStred = new Point(randomBase.Next(minimum, (int)maximumX), randomBase.Next(minimum, (int)maximumY));
            return novyStred;
        }

        internal int GenerujVelikostPlanety()
        {
            return randomBase.Next(16, 49);
        }
    }
}
