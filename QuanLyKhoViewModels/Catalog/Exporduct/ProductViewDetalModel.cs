using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using QuanLyKhoData.Entities;

namespace QuanLyKhoViewModels.Catalog.Exporduct
{
    public class ProductViewDetalModel
    {
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Ngày bán")]
        [DataType(DataType.Date)]
        public DateTime ExDate { get; set; }
        [Display(Name = "Mã sản phẩm")]
        public string importID { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }
        [Display(Name = "Giá bán")]
        [DataType(DataType.Currency)]
        public decimal SalesPrice { get; set; }
        public decimal ToTalSum { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Số tiền nợ")]
        public decimal debttotal { get; set; }
        [Display(Name = "Mã khách hàng")]
        public string GuestID { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Số điện thoại")]
        public int PhoneNumber { get; set; }
        public string EmL { get; set; }
        public string EmF { get; set; }
        public bool status { get; set; }
        public decimal weight { get; set; }
        public decimal tongtien { get; set; }
    }
}
