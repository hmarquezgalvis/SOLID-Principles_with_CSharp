﻿using System;
using System.Collections.Generic;
using SOLID.Principles.GeometricSample.Interfaces;

namespace SOLID.Principles.GeometricSample.Shapes
{
    public class Rectangle : IGeometricShape
    {
        public double Sides { get; } = 4;
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return Height * 2 + Width * 2;
        }
    }
}
