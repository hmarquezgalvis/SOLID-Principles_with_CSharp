using System;
namespace SOLID.Principles.VehicleSample
{
    public class VehicleGenerator
    {
        public int WheelCount { get; };
        public int MaxSpeed { get; };

        public abstract void Draw();
    }
}
