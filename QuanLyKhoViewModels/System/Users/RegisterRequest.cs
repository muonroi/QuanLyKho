using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.System.Users
{
    public class RegisterRequest
    {
        [Display(Name = "Tên")]
        public string FirtName { get; set; }
        [Display(Name = "Họ")]
        public string LastName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Dob { get; set; }
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Tài khoản")]
        public string Username { get; set; }
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
