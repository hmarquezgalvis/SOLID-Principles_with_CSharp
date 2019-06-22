using System;
using SOLID.Principles.Shapes;
using Xunit;

namespace SOLID.Tests
{
    public class GeometricShapeTest
    {
        [Fact]
        public void RectangleAreaTest()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 3;
            rectangle.Height = 6;

            double expected = 18;
            double actual = rectangle.Area();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SquareAreaTest()
        {
            Square square = new Square();
            square.SideLength = 4;

            double expected = 16;
            double actual = square.Area();

            Assert.Equal(expected, actual);
        }
    }
}
