using System;
namespace SOLID.Principles.ProductSample.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        int Stock { get; set; }
        int NumberOfDisks { get; set; }
        DateTime ReleaseDate { get; set; }
    }
}
