using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Entities
{
    public class Debt
    {
        public int ID { get; set; }
        public DateTime CreateDateDebt{ get; set; }
        public decimal TotalDebt { get; set; }
        public string ProductID { get; set; }
        public string GuestID { get; set; }
        public Guest guest { get; set; }
    }
    public class HistoryDebt2
    {

        public int ID { get; set; }
        public string GuestIDS { get; set; }
        public decimal DebtFee { get; set; }
        public DateTime PayDay { get; set; }
        public string BankName { get; set; }
    }
    public class ViewModel
    {
        public IEnumerable<Debt> Teachers { get; set; }
        public IEnumerable<HistoryDebt2> Students { get; set; }
    }
}
