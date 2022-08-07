using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Products
{
    public class ProductViewBindingModel
    {
        public string Name { get; set; }
        public string importID { get; set; }
        public int Quantity { get; set; }
        public decimal ToTalSum { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal origin { get; set; }
        public DateTime ImportDate { get; set; }
}
}
