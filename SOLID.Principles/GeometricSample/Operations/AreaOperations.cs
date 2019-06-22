using System;
using System.Collections.Generic;
using SOLID.Principles.GeometricSample.Interfaces;
using SOLID.Principles.GeometricSample.Shapes;

namespace SOLID.Principles.GeometricSample.Operations
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
