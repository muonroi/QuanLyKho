﻿using System;
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
}