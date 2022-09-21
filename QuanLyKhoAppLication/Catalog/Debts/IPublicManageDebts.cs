using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Debt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Debts
{
    public interface IPublicManageDebts
    {
        Task<int> Create(DebtCreateRequest request);
        Task<PagedResult<DebtVm>> GetDebtByGuestID(GetManageDebtPagingRequest request, string ID);
        Task<PagedResult<DebtVm>> GetAllDebt(GetManageDebtPagingRequest request);
        Task<ApiResult<bool>> Delete(int iddebt);
        Task<ApiResult<bool>> DeleteALL(string guestID);
        Task<PagedResult<DebtVm>> GetAllDebtHis(GetManageDebtPagingRequest request);
       Task<PagedResult<DebtVm>> GetAllDebtHisById(GetManageDebtPagingRequest request, string Id);
        Task<PagedResult<DebtVm>> GetImportDebt(GetManageDebtPagingRequest request);
        Task<ApiResult<bool>> CreateDebtImport(DebtCreateRequest request);
    }
}
