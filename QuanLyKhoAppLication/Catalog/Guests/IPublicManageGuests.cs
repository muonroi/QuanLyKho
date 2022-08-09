using QuanLyKhoViewModels.Catalog.Guest;
using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Guests
{
    public interface IPublicManageGuests
    {
        Task<int> Create(GuestCreateRequest request);
        Task<List<GuestCreateRequest>> GetDebtByEmpID(string ID);
        Task<PagedResult<GuestViewModels>> GetAllEmp(GetManageGuestPagingRequest request);
        Task<ApiResult<bool>> Delete(int iddebt);
    }
}
