using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

    }
}
