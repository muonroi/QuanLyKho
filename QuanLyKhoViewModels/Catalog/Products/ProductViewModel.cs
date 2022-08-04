using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Products
{
    public class ProductViewModel
    {
        public string Id { get; set; }
        public DateTime ImportDate { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal ToTalSum { get; set; }
        public string UnitName { get; set; }
    }
}
