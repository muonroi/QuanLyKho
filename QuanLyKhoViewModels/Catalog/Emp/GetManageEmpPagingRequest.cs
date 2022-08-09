using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Emp
{
    public class GetManageEmpPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

    }
}
