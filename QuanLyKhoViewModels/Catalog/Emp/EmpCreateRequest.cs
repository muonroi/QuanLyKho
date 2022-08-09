using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Emp
{
    public class EmpCreateRequest
    {
        [Display(Name = "Họ")]
        public string FirtName { get; set; }
        [Display(Name = "Tên")]
        public string LastName { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Display(Name = "Số điện thoại")]
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        [Display(Name = "Lương")]
        public decimal Salary { get; set; }
        [Display(Name = "Số ngày nghỉ")]
        public int SumDayOff { get; set; }
        [Display(Name = "Số ngày làm việc")]
        public int SumDayWorked { get; set; }
        [Display(Name = "Tài khoản")]
        public string Username { get; set; }
    }
}
