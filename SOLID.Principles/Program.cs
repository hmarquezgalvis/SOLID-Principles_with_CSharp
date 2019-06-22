using System;
using SOLID.Principles.Interfaces;
using SOLID.Principles.Operations;
using SOLID.Principles.Shapes;

namespace SOLID.Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new IGeometricShape[]
            {
                new Rectangle { Width= 10, Height = 5 },
                new EquilateralTriangle { SideLength = 5 },
                new Rectangle { Width = 4, Height = 6 },
                new Square { SideLength = 10 },
                new Rectangle { Width = 8, Height = 9 },
                new Square { SideLength = 8 },
                new EquilateralTriangle { SideLength = 5 }
            };

            var calculator = new Calculator();
            calculator.Calculate(shapes);

            Console.WriteLine($"Total Area: {calculator.TotalAreas}" +
                $"\nTotal Perimeter: {calculator.TotalPerimeters}");

            Console.ReadKey();
        }
    }
}