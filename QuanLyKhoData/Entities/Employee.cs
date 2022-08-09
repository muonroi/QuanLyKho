using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public int SumDayOff { get; set; }
        public int SumDayWorked { get; set; }
        public virtual string username { get; set; }
        public string appUser { get; set; }
    }
}
