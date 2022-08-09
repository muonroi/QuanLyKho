using QuanLyKhoViewModels.Catalog.Emp;
using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Emp
{
    public interface IEmpManage
    {
        Task<int> Create(EmpCreateRequest request);
        Task<List<EmpCreateRequest>> GetDebtByEmpID(string ID);
        Task<PagedResult<EmpViewModel>> GetAllEmp(GetManageEmpPagingRequest request);
        Task<ApiResult<bool>> Delete(int iddebt);
    }
}
