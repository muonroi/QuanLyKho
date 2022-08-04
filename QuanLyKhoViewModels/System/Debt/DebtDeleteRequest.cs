using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.System.Debt
{
    public class DebtDeleteRequest
    {
        [Display(Name = "Mã hóa đơn")]
        public string DebtID { get; set; }
    }
}
