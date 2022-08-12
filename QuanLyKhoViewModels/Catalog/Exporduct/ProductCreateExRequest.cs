using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Exporduct
{
    public class ProductCreateExRequest
    {
        [Display(Name = "Ngày bán")]
        [DataType(DataType.Date)]
        public DateTime ExDate { get; set; }
        public string importID { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public decimal SalesPrice { get; set; }
        public decimal ToTalSum { get; set; }
        [DataType(DataType.Currency)]
        [DefaultValue(true)]
        public decimal debttotal { get; set; }
        [Display(Name = "Mã khách hàng")]
        public string GuestID { get; set; }
        public bool status { get; set; }
        public decimal weight { get; set; }
        public string StatusDebt { get; set; }

    }
}
