using System;
using System.Collections.Generic;
using SOLID.Principles.Interfaces;
using SOLID.Principles.Shapes;

namespace SOLID.Principles.Operations
{
    public class AreaOperations
    {
        public static double Sum(IEnumerable<IGeometricShape> shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
