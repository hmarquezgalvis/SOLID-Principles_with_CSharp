using System;
using SOLID.Principles.ProductSample.Interfaces;

namespace SOLID.Principles.ProductSample.Products
{
    public class CompactDisk
        : IProduct
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int NumberOfDisks { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
