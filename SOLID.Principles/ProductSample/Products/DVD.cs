using System;
using SOLID.Principles.ProductSample.Interfaces;

namespace SOLID.Principles.ProductSample.Products
{
    public class DVD
        : IProduct, IProductAgeAware
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int NumberOfDisks { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RecommendedAge { get; set; }
    }
}
