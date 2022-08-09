using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoAppLication.Catalog.Products
{
    public class ProductEditRequest
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal ToTalSum { get; set; }
    }
}
