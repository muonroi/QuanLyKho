using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyKhoData.Entities
{
    public partial class ContactInfo
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Contact Name required!", AllowEmptyStrings = false)]
        public string ContactName { get; set; }
        [Required(ErrorMessage = "Contact No required!", AllowEmptyStrings = false)]
        public string ContactNo { get; set; }
    }

}
