using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SizingToolkit;

namespace MEP.Toolkit
{
    /// <summary>
    /// Duct Sizing Utilities
    /// </summary>
    public static class DuctSizing
    {
        /// <summary>
        /// Calculate the necessary duct diameter from 
        /// pressure drop (in/100ft) and flow  (CFM/s)
        /// </summary>
        /// <param name="PD"></param>
        /// <param name="flow"></param>
        /// <returns></returns>
        public static double EquivalentDiameter(double PD, double flow)
        {
            return SizingToolkit.DuctSizer.DuctDiameterFromPDandQ(PD, flow);
        }

        public static double EquivalentDiameterOfRectangle(double width, double height)
        {
            return SizingToolkit.DuctSizer.DuctEquivalentDiameter(width, height);
        }

    }
}
