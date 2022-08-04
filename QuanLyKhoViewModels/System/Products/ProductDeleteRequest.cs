using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.System.Products
{
    public class ProductDeleteRequest
    {
        [Display(Name = "Mã sản phẩm")]
        public string ProductID { get; set; }
    }
}
