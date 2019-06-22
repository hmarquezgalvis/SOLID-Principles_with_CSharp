using System;
using SOLID.Principles.ProductSample.Interfaces;

namespace SOLID.Principles.ProductSample.Operations
{
    public class ProductCanBuy
    {
        public static bool Check(int age, IProductAgeAware ageAware)
        {
            return age >= ageAware.RecommendedAge;
        }
    }
}
