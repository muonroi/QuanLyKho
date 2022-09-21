using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Bank
{
    public class GetManageBankPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
