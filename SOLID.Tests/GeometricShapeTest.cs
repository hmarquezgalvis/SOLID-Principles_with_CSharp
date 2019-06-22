using System;
using SOLID.Principles.GeometricSample.Shapes;
using Xunit;

namespace SOLID.Tests
{
    public class GeometricShapeTest
    {
        [Fact]
        public void EquilateralTriangleTest()
        {
            EquilateralTriangle triangle = new EquilateralTriangle();
            triangle.SideLength = 10;

            double areaExpected = 43.30;
            double area = Math.Round(triangle.Area(), 2);
            Assert.Equal(areaExpected, area);

            double perimeterExpected = 30;
            double perimeter = triangle.Perimeter();
            Assert.Equal(perimeterExpected, perimeter);
        }

        [Fact]
        public void RectangleTest()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 3;
            rectangle.Height = 6;

            double areaExpected = 18;
            double area = rectangle.Area();
            Assert.Equal(areaExpected, area);

            double perimeterExpected = 18;
            double perimeter = rectangle.Perimeter();
            Assert.Equal(perimeterExpected, perimeter);
        }

        [Fact]
        public void SquareTest()
        {
            Square square = new Square();
            square.SideLength = 4;

            double areaExpected = 16;
            double area = square.Area();
            Assert.Equal(areaExpected, area);

            double perimeterExpected = 16;
            double perimeter = square.Perimeter();
            Assert.Equal(perimeterExpected, perimeter);

        }
    }
}
