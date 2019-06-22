using System;
using SOLID.Principles.ShoppingSample.Interfaces;

namespace SOLID.Principles.ShoppingSample.PaymentMethod
{
    public class Paypal
        : IPaymentMethod
    {
        public void Pay(Shopping shopping)
        {
            Console.WriteLine("Pay with Paypal");
        }
    }
}
