using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SemPraceMain
{
    class VykreslovaniObjektu
    {

        internal Ellipse NakresliNovyObjekt(HerniObjekt objekt)
        {
            // Create a red Ellipse.
            Ellipse novyObjekt = new Ellipse();

            // Create a SolidColorBrush with a red color to fill the 
            // Ellipse with.
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            // Describes the brush's color using RGB values. 
            // Each value has a range of 0-255.
            mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 0);
            novyObjekt.Fill = mySolidColorBrush;
            novyObjekt.StrokeThickness = 2;
            novyObjekt.Stroke = Brushes.Black;

            // Set the width and height of the Ellipse.
            novyObjekt.Width = objekt.Velikost;
            novyObjekt.Height = objekt.Velikost;

            return novyObjekt;
        }
    }
}
