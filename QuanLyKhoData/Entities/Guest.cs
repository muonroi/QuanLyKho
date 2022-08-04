using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Entities
{
    public class Guest
    {
        public string ID { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Debt> Debts { get; set; }


    }
}
