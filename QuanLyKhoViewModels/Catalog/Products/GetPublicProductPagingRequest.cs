using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoApplication.Catalog.Products
{
    public class GetPublicProductPagingRequest:PagingRequestBase
    {
        public string Keyword { get; set; }

    }
}
