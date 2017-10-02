using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizingToolkit
{
    /// <summary>
    /// Set of nodes for creating ductwork sizes.
    /// </summary>
    public class DuctSizer
    {
        public static double DuctEquivalentDiameter(double w, double h)
        {
            double equivalentDiameter = 1.3 * Math.Pow((w * h), 0.625) / Math.Pow((w + h), 0.25);
            return equivalentDiameter;
        }

        public static double DuctSecondRectangularDimension(double equivDiam, double firstSide)
        {
            double errorFactor = 1.5;

            double secondSide = Math.PI * Math.Pow((firstSide / 2), (2 / firstSide));
            double guessEquivDiam = DuctEquivalentDiameter(firstSide, secondSide);
            double error = guessEquivDiam - equivDiam;
            int numCalcs = 0;

            while (Math.Abs(error) > 0.1)
            {
                numCalcs++;
                if (error<0)
                {
                    secondSide = secondSide - error * errorFactor;
                }
                else if (error > 0 )
                {
                    secondSide = secondSide + error * errorFactor;
                }
                double newGuessEquivDiam = DuctEquivalentDiameter(firstSide, secondSide);
                error = newGuessEquivDiam - equivDiam;
                guessEquivDiam = newGuessEquivDiam;    
            }

            return secondSide;
        }

        public static double DuctDiameterFromPDandQ(double PD, double flow)
        {
            double diam = Math.Pow((0.109136*Math.Pow((flow), 1.9)) / PD, (1 / 5.02));
            return diam;
        }

        public static double EquivalendDiameterFromVandQ(double velocity, double flow)
        {
            double diamter = Math.Sqrt((flow / velocity)/Math.PI)*2;
            return diamter;
        }
    }
}
