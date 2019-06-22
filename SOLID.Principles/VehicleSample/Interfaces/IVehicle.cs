using System;
namespace SOLID.Principles.VehicleSample.Interfaces
{
    public interface IVehicle
    {
        int WheelCount { get; }
        int MaxSpeed { get; }

        void Draw();
    }
}
