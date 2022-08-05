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
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal OriginPrice { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalesPrice { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ToTalSum { get; set; }
    }
}
