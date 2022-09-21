using QuanLyKhoViewModels.Catalog.Bank;
using QuanLyKhoViewModels.Catalog.Guest;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Bank;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public interface IGuestApiServices
    {
        Task<PagedResult<GuestViewModels>> GetPagings(GetManageGuestPagingRequest request);
        Task<PagedResult<BankVM>> GetPagingsBank(GetManageBankPagingRequest request);

        Task<ApiResult<bool>> DeleteGuest(string request);
        Task<ApiResult<bool>> CreateGuest(GuestCreateRequest request);
        Task<ApiResult<bool>> CreateBank(BankCreateRequest request);
    }
}
