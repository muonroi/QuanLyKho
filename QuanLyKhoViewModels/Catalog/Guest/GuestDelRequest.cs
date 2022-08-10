using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Guest
{
    public class GuestDelRequest
    {
        [Display(Name = "Mã khách hàng")]
        public string GuestID { get; set; }
    }
}
