using System;
using SOLID.Principles.VehicleSample.Interfaces;

namespace SOLID.Principles.VehicleSample.Renders
{
    public class VehicleRender
    {
        public static void Draw(IVehicle vehicle)
        {
            vehicle.Draw();
        }
    }
}
