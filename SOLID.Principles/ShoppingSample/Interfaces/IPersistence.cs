using System;
namespace SOLID.Principles.ShoppingSample.Interfaces
{
    public interface IPersistence
    {
        void Save(Shopping shopping);
    }
}
