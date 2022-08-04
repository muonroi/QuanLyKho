using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.System.Debt
{
    public class DebtVm
    {
        public int ID { get; set; }
        [Display(Name = "Ngày tạo")]
        [DataType(DataType.Date)]
        public DateTime CreateDateDebt { get; set; }
        [Display(Name = "Số tiền")]
        public decimal TotalDebt { get; set; }
        [Display(Name = "Sản phẩm nợ")]
        public string ProductID { get; set; }
        [Display(Name = "Mã khách hàng")]
        public string GuestID { get; set; }
    }
}
