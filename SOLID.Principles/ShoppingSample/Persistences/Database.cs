using System;
using SOLID.Principles.ShoppingSample.Interfaces;

namespace SOLID.Principles.ShoppingSample.Persistences
{
    public class Database
        : IPersistence
    {
        public void Save(Shopping shopping)
        {
            Console.WriteLine("Saved on Local Database");
        }
    }
}
