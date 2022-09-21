using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Debt;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public interface IDebtApiServices
    {
        Task<PagedResult<DebtVm>> GetPagings(GetManageDebtPagingRequest request);
        Task<PagedResult<DebtVm>> GetPagingsHis(GetManageDebtPagingRequest request);
        Task<ApiResult<bool>> DeleteDebt(string request);
        Task<ApiResult<bool>> DeleteDebtAll(string request);
        Task<PagedResult<DebtVm>> GetDebtByGuestID(GetManageDebtPagingRequest request,string ID);
        Task<PagedResult<DebtVm>> GetPagingsHisById(GetManageDebtPagingRequest request, string Id);
        Task<PagedResult<DebtVm>>  GetImportPagings(GetManageDebtPagingRequest request);
        Task<ApiResult<bool>> CreateDebtImport(DebtCreateRequest request);

    }
}
