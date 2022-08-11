using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyKhoViewModels.System.Products
{
    public class ProductVm
    {
        [Display(Name = "Mã sản phẩm")]
        public string importID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name  = "Ngày tạo")]
        public DateTime ImportDate { get; set; }
        [Display(Name = "Mã sản phẩm")]
        public string Id { get; set; }
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Số lượng nhập")]
        public int Quantity { get; set; }
     
        public decimal OriginPrice { get; set; }
        
        public decimal SalesPrice { get; set; }
        public decimal ToTalSum { get; set; }
    }
}
