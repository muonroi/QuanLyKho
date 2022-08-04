using QuanLyKhoData.Entities;
using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.Catalog.Products;
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
        Task<List<DebtByUserViewModels>> GetDebtByGuestID(string ID);
        Task<PagedResult<DebtVm>> GetAllDebt(GetManageDebtPagingRequest request);
        Task<ApiResult<bool>> Delete(int iddebt);
        Task<ApiResult<bool>> DeleteALL(string guestID);
    }
}
