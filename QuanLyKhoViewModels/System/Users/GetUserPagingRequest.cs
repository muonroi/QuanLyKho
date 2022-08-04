using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoAppLication.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
