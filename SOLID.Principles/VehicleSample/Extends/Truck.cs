using System;
using SOLID.Principles.VehicleSample.Interfaces;

namespace SOLID.Principles.VehicleSample.Extends
{
    public class Truck
        : IVehicle
    {

        public int WheelCount { get; } = 6;

        public int MaxSpeed { get; } = 120;

        public void Draw()
        {
            Console.WriteLine($"Rendered => Truck{{Wheels: {WheelCount}, MaxSpeed: {MaxSpeed} }}");
        }
    }
}
