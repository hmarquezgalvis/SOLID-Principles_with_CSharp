using System;
using SOLID.Principles.ShoppingSample.Interfaces;

namespace SOLID.Principles.ShoppingSample
{
    public class Basket
    {
        private IPersistence Persistence { get; set; }
        private IPaymentMethod PaymentMethod { get; set; }

        public Basket(IPersistence persistence, IPaymentMethod paymentMethod)
        {
            this.Persistence = persistence;
            this.PaymentMethod = paymentMethod;
        }

        public void Buy(Shopping shopping)
        {
            this.Persistence.Save(shopping);
            this.PaymentMethod.Pay(shopping);
        }
    }
}
