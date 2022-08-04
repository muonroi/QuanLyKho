using System;
using System.Collections.Generic;

namespace QuanLyKhoData.Entities
{
    public class ImportProduct
    {
        public DateTime ImportDate { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal ToTalSum { get; set; }
    }
}
