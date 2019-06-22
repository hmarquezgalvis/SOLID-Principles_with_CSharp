using System;
using System.Collections.Generic;
using SOLID.Principles.Interfaces;
using SOLID.Principles.Shapes;

namespace SOLID.Principles.Operations
{
    public class PerimeterOperations
    {
        public static double Sum(IEnumerable<IGeometricShape> shapes)
        {
            double perimeter = 0;
            foreach (var shape in shapes)
            {
                perimeter += shape.Perimeter();
            }

            return perimeter;
        }
    }
}
