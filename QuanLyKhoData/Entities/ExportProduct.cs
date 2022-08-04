using System;
using System.Collections.Generic;

namespace QuanLyKhoData.Entities
{
    public class ExportProduct
    {
        public int Id { get; set; }
        public DateTime ExDate { get; set; }
        public int Quantity { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal ToTalSum { get; set; }
        public decimal debttotal { get; set; }
        public string GuestID { get; set; }
        public string importID { get; set; }

    }
}
