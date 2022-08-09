using QuanLyKhoViewModels.Catalog.Emp;
using QuanLyKhoViewModels.Common;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public interface IEmpApiServices
    {
        Task<PagedResult<EmpViewModel>> GetPagings(GetManageEmpPagingRequest request);
    }
}
