using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.System.Users
{
    public class UserDeleteRequest
    {
        [Display(Name = "Mã người dùng")]
        public Guid Id { get; set; }
    }
}
