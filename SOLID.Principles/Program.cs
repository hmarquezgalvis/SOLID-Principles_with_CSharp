using System;
using System.Collections.Generic;
using System.Linq;
using SOLID.Principles.GeometricSample;
using SOLID.Principles.GeometricSample.Interfaces;
using SOLID.Principles.GeometricSample.Operations;
using SOLID.Principles.GeometricSample.Shapes;
using SOLID.Principles.MessengerSample;
using SOLID.Principles.VehicleSample;
using SOLID.Principles.VehicleSample.Vehicles;
using SOLID.Principles.VehicleSample.Renders;
using SOLID.Principles.ProductSample.Interfaces;
using SOLID.Principles.ProductSample.Products;
using SOLID.Principles.ProductSample.Operations;

namespace SOLID.Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            // SHAPE SAMPLES

            var shapes = new List<IGeometricShape>
            {
                new Rectangle { Width= 10, Height = 5 },
                new EquilateralTriangle { SideLength = 10 },
                new Rectangle { Width = 4, Height = 6 },
                new Square { SideLength = 10 },
                new Rectangle { Width = 8, Height = 9 },
                new Square { SideLength = 8 },
                new EquilateralTriangle { SideLength = 5 }
            };

            var calculator = new Calculator();
            calculator.Calculate(shapes);

            Console.WriteLine($"Total Area: {calculator.TotalAreas}\nTotal Perimeter: {calculator.TotalPerimeters}");

            // MESSENGER SAMPLE

            var messageEmail = new Message { To = "hector@dominio.com", Subject = "Waiting News", Body = "Hi! I'm waiting for your response, dude!" };
            var messageSMS = new Message { To = "80010203040", Body = "Let me know if you want a coffee" };
            var messageChat = new Message { To = "user1234", Body = "Hi =)" };

            var messenger = new Messenger();
            messenger.Send(messageEmail, MessengerSample.Operations.MessageSendTypeEnum.Email);
            messenger.Send(messageSMS, MessengerSample.Operations.MessageSendTypeEnum.SMS);
            messenger.Send(messageChat, MessengerSample.Operations.MessageSendTypeEnum.Chat);


            // VEHICLE SAMPLE

            var vehicle = new Truck();
            VehicleRender.Draw(vehicle);

            // PRODUCT SAMPLE

            var products = new List<IProduct>
            {
                new CompactDisk { Name = "Movie 1", NumberOfDisks = 2, ReleaseDate = new DateTime(2010, 08, 01), Stock = 5 },
                new CompactDisk { Name = "Movie 2", NumberOfDisks = 1, ReleaseDate = new DateTime(2000, 03, 01), Stock = 4 },
                new CompactDisk { Name = "Movie 3", NumberOfDisks = 1, ReleaseDate = new DateTime(2012, 02, 01), Stock = 2 },
                new DVD { Name = "Movie A", NumberOfDisks = 1, ReleaseDate = new DateTime(2017, 12, 01), Stock = 11, RecommendedAge = 18 },
                new DVD { Name = "Movie B", NumberOfDisks = 1, ReleaseDate = new DateTime(2018, 11, 01), Stock = 3, RecommendedAge = 15 }
            };

            var filtered = products.Where(x => x is IProductAgeAware)
                .Where(x => ProductCanBuy.Check(16, x as IProductAgeAware)).ToList();

            foreach(var item in filtered)
            {
                Console.WriteLine($"{item.Name}");
            }

            Console.ReadKey();
        }
    }
}