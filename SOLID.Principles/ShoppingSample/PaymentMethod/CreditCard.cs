using System;
using SOLID.Principles.ShoppingSample.Interfaces;

namespace SOLID.Principles.ShoppingSample.PaymentMethod
{
    public class CreditCard
        : IPaymentMethod
    {
        public void Pay(Shopping shopping)
        {
            Console.WriteLine("Pay with CreditCard");
        }
    }
}
