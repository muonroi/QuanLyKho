using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyKhoData.Entities
{
    public class HistoryDebt
    {
       
        public int ID { get; set; }
        public string GuestIDS { get; set; }
        public decimal DebtFee { get; set; }
        public DateTime PayDay { get; set; }
        public string BankName { get; set; }
    }
}
