using System;
namespace SOLID.Principles.ShoppingSample.Interfaces
{
    public interface IPaymentMethod
    {
        void Pay(Shopping shopping);
    }
}
