using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalDebt { get; set; }
        [Display(Name = "Sản phẩm nợ")]
        public string ProductID { get; set; }
        [Display(Name = "Mã khách hàng")]
        public string GuestID { get; set; }
        public string GuestFName { get; set; }
        public string GuestLName { get; set; }

    }
}
