using System;
using System.Collections.Generic;
using System.Linq;
using SOLID.Principles.GeometricSample;
using SOLID.Principles.GeometricSample.Interfaces;
using SOLID.Principles.GeometricSample.Operations;
using SOLID.Principles.GeometricSample.Shapes;
using SOLID.Principles.MessengerSample;
using SOLID.Principles.VehicleSample;
using SOLID.Principles.VehicleSample.Extends;
using SOLID.Principles.VehicleSample.Renders;

namespace SOLID.Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IGeometricShape>
            {
                //new Rectangle { Width= 10, Height = 5 },
                new EquilateralTriangle { SideLength = 10 },
                //new Rectangle { Width = 4, Height = 6 },
                //new Square { SideLength = 10 },
                //new Rectangle { Width = 8, Height = 9 },
                //new Square { SideLength = 8 },
                //new EquilateralTriangle { SideLength = 5 }
            };

            var calculator = new Calculator();
            calculator.Calculate(shapes);

            Console.WriteLine($"Total Area: {calculator.TotalAreas}" +
                $"\nTotal Perimeter: {calculator.TotalPerimeters}");

            var messageEmail = new Message { To = "hector@dominio.com", Subject = "Waiting News", Body = "Hi! I'm waiting for your response, dude!" };
            var messageSMS = new Message { To = "80010203040", Body = "Let me know if you want a coffee" };
            var messageChat = new Message { To = "user1234", Body = "Hi =)" };

            var messenger = new Messenger();
            messenger.Send(messageEmail, MessengerSample.Operations.MessageSendTypeEnum.Email);
            messenger.Send(messageSMS, MessengerSample.Operations.MessageSendTypeEnum.SMS);
            messenger.Send(messageChat, MessengerSample.Operations.MessageSendTypeEnum.Chat);

            var vehicle = new Truck();
            VehicleRender.Draw(vehicle);

            Console.ReadKey();
        }
    }
}