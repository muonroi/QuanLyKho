using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Bank
{
    public class BankCreateRequest
    {
        public int ID { get; set; }
        public string BankName { get; set; }
        public string GuestId { get; set; }
        public string Detail { get; set; }
        public decimal TotalFee { get; set; }
    }
}
