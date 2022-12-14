using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Debt
{
    public class DebtCreateRequest
    {
        public int ID { get; set; }
        public DateTime CreateDateDebt { get; set; }
        public decimal TotalDebt { get; set; }
        public string ProductID { get; set; }
        public string GuestID { get; set; }
    }
}
