using System;
using System.Collections.Generic;
using SOLID.Principles.Interfaces;
using SOLID.Principles.Operations;
using SOLID.Principles.Shapes;

namespace SOLID.Principles
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
