﻿using QuanLyKhoViewModels.Catalog.Guest;
using QuanLyKhoViewModels.Common;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public interface IGuestApiServices
    {
        Task<PagedResult<GuestViewModels>> GetPagings(GetManageGuestPagingRequest request);

    }
}
