using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ProductDetails
    {
        public int  ProductId { get; set; }
        public string  ProductName { get; set; }
        public decimal  UnitPrice { get; set; }
        public string CategoryName { get; set; }
    }
}
