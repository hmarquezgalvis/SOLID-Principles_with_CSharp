using System;
using System.Collections.Generic;
using SOLID.Principles.GeometricSample.Interfaces;
using SOLID.Principles.GeometricSample.Shapes;

namespace SOLID.Principles.GeometricSample.Operations
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
