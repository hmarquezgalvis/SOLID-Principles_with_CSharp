using System;
using SOLID.Principles.VehicleSample.Interfaces;

namespace SOLID.Principles.VehicleSample.Vehicles
{
    public class Car
        : IVehicle
    {
        public int WheelCount { get; } = 4;
        public int MaxSpeed { get; } = 200;

        public void Draw()
        {
            Console.WriteLine($"Rendered => Car{{Wheels: {WheelCount}, MaxSpeed: {MaxSpeed} }}");
        }
    }
}
