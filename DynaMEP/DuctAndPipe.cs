using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Geometry;
using Autodesk.DesignScript.Runtime;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Mechanical;


namespace DynaMEP
{
    /// <summary>
    /// Duct and Pipe Creation tools
    /// </summary>
    public static class DuctAndPipe
    {
        /// <summary>
        /// Create a Duct Placeholder
        /// </summary>
        /// <param name="document"></param>
        /// <param name="SystemTypeId"></param>
        /// <param name="DuctTypeId"></param>
        /// <param name="LevelId"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Duct DrawDuctPlaceholder(Document document, ElementId SystemTypeId, ElementId DuctTypeId, ElementId LevelId, Autodesk.DesignScript.Geometry.Point p1, Autodesk.DesignScript.Geometry.Point p2)
        {
            XYZ xyz1 = new XYZ(p1.X, p1.Y, p1.Z);
            XYZ xyz2 = new XYZ(p2.X, p2.Y, p2.Z);
            Duct newDuctPlaceholder = Duct.CreatePlaceholder(document, SystemTypeId, DuctTypeId, LevelId, xyz1, xyz2);
            return newDuctPlaceholder;
        }


    }
}
