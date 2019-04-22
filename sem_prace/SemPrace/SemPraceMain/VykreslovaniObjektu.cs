using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SemPraceMain
{
    class VykreslovaniObjektu
    {

        internal Ellipse NakresliVesmirnyObjekt(HerniObjekt objekt)
        {
            Ellipse novyObjekt = new Ellipse();

            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 0);
            novyObjekt.Fill = mySolidColorBrush;
            novyObjekt.StrokeThickness = 2;
            novyObjekt.Stroke = Brushes.DarkGray;

            novyObjekt.Width = objekt.VelikostPolomer * 2;
            novyObjekt.Height = objekt.VelikostPolomer * 2;

            return novyObjekt;
        }

        internal Ellipse NakresliPuntik(Point puntikKolem, Color barva)
        {
            Ellipse novyObjekt = new Ellipse();

            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            mySolidColorBrush.Color = barva;
            novyObjekt.Fill = mySolidColorBrush;
            //novyObjekt.StrokeThickness = 1;
            //novyObjekt.Stroke = Brushes.DarkGray;

            novyObjekt.Width = 5;
            novyObjekt.Height = 5;

            return novyObjekt;
        }
    }
}
