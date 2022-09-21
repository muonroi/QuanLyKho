using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Entities
{
    public class ImportPro
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal ToTalSum { get; set; }
    }
}
