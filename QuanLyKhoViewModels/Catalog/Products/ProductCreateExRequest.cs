using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Products
{
    public class ProductCreateExRequest
    {
        [Display(Name ="Ngày bán")]
        [DataType(DataType.Date)]
        public DateTime ExDate { get; set; }
        public string importID { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public decimal SalesPrice { get; set; }
        public decimal ToTalSum { get; set; }
        [DataType(DataType.Currency)]
        public decimal debttotal { get; set; }
        public string GuestID { get; set; }
    }
}
