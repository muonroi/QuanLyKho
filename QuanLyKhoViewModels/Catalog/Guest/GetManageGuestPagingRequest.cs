﻿using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Guest
{
    public class GetManageGuestPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

    }
}
