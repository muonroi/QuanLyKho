using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Entities
{
    public class Bank
    {
        public int ID { get; set; }
        public string BankName { get; set; }
        public string GuestId { get; set; }
        public decimal TotalFee { get; set; }
        public string Detail { get; set; }
    }
}
