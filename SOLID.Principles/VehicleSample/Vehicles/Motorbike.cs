using System;
using SOLID.Principles.VehicleSample.Interfaces;

namespace SOLID.Principles.VehicleSample.Vehicles
{
    public class Motorbike
        : IVehicle
    {
        public int WheelCount { get; } = 2;

        public int MaxSpeed { get; } = 150;

        public void Draw()
        {
            Console.WriteLine($"Rendered => Motorbike{{Wheels: {WheelCount}, MaxSpeed: {MaxSpeed} }}");
        }
    }
}
