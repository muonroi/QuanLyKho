using QuanLyKhoViewModels.Catalog.Bank;
using QuanLyKhoViewModels.Catalog.Guest;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Bank;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Guests
{
    public interface IPublicManageGuests
    {
        Task<ApiResult<bool>> Create(GuestCreateRequest request);
        Task<List<GuestCreateRequest>> GetDebtByEmpID(string ID);
        Task<PagedResult<GuestViewModels>> GetAllEmp(GetManageGuestPagingRequest request);
        Task<ApiResult<bool>> Delete(string ID);
        Task<ApiResult<bool>> CreateBank(BankCreateRequest request);
        Task<PagedResult<BankVM>> GetAllBank(GetManageBankPagingRequest request);
    }
}
