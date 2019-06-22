using System;
using SOLID.Principles.ShoppingSample.Interfaces;

namespace SOLID.Principles.ShoppingSample.Persistences
{
    public class Server
        : IPersistence
    {
        public void Save(Shopping shopping)
        {
            Console.WriteLine("Saved on Remote Server");
        }
    }
}
