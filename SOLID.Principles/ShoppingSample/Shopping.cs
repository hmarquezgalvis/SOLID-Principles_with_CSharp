using System;
using System.Collections.Generic;

namespace SOLID.Principles.ShoppingSample
{
    public class Shopping
    {
        public string Title { get; set; }
        public IEnumerable<string> Products { get; set; }
    }
}
