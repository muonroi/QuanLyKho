using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Debt
{
    public class GetManageDebtPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

    }
}
