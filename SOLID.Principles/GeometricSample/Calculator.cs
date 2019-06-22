using System;
using System.Collections.Generic;
using SOLID.Principles.GeometricSample.Interfaces;
using SOLID.Principles.GeometricSample.Operations;
using SOLID.Principles.GeometricSample.Shapes;

namespace SOLID.Principles.GeometricSample
{
    public class Calculator
    {
        public double TotalAreas { get; private set; }
        public double TotalPerimeters { get; private set; }

        public void Calculate(IEnumerable<IGeometricShape> shapes)
        {
            TotalAreas = AreaOperations.Sum(shapes);
            TotalPerimeters= PerimeterOperations.Sum(shapes);
        }
    }
}
