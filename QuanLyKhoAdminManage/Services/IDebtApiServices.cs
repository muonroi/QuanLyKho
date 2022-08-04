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
        Task<ApiResult<bool>> DeleteDebt(string request);
        Task<ApiResult<bool>> DeleteDebtAll(string request);
    }
}
