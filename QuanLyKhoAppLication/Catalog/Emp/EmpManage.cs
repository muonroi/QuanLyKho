using QuanLyKhoData.EF;
using QuanLyKhoViewModels.Catalog.Emp;
using QuanLyKhoViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QuanLyKhoAppLication.Catalog.Emp
{
    public class EmpManage : IEmpManage
    {
        private readonly QuanLyKhoDbContext _dbcontext;
        public EmpManage(QuanLyKhoDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Task<int> Create(EmpCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> Delete(int iddebt)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<EmpViewModel>> GetAllEmp(GetManageEmpPagingRequest request)
        {
            var querySearch = (from deb in _dbcontext.employees
                               join pro in _dbcontext.appusers on deb.username equals pro.UserName
                               select new { deb, pro });
            if (!string.IsNullOrEmpty(request.Keyword))
                querySearch = querySearch.Where(x => x.deb.username.Contains(request.Keyword));
            int totalRow = await querySearch.CountAsync();
            var data = await querySearch.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).
                Select(x => new EmpViewModel()
                {
                    FirtName = x.deb.FirtName,
                    LastName = x.deb.LastName,
                    Dob = x.deb.Dob,
                    PhoneNumber = x.deb.PhoneNumber,
                    Username = x.deb.username,
                    Email = x.deb.Email,
                    Salary = x.deb.Salary,
                    SumDayOff = x.deb.SumDayOff,
                    SumDayWorked = x.deb.SumDayWorked,

                }).ToListAsync();
            var pageResult = new PagedResult<EmpViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pageResult;
        }

        public Task<List<EmpCreateRequest>> GetDebtByEmpID(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
