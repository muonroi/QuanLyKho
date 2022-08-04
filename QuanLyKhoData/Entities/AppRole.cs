﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoData.Entities
{
    public class AppRole:IdentityRole<Guid>
    {
        public string Des { get; set; }
    }
}
