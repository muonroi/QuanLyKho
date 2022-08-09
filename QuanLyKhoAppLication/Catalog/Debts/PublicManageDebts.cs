using Microsoft.EntityFrameworkCore;
using QuanLyKhoData.EF;
using QuanLyKhoData.Entities;
using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Debt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Debts
{
    public class PublicManageDebts : IPublicManageDebts
    {
        private readonly QuanLyKhoDbContext _dbcontext;
        public PublicManageDebts(QuanLyKhoDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> Create(DebtCreateRequest request)
        {
            var data = new Debt()
            {
                CreateDateDebt = request.CreateDateDebt,
                TotalDebt = request.TotalDebt,
                ProductID = request.ProductID,
                GuestID = request.GuestID,
            };
            _dbcontext.debts.Add(data);
            return await _dbcontext.SaveChangesAsync();
        }

        public async Task<ApiResult<bool>> Delete(int iddebt)
        {
            var product = await _dbcontext.debts.FindAsync(iddebt);

            if (product == null)
            {
                return new ApiErrorResult<bool>("Hóa đơn không tồn tại");
            }
            var reult = _dbcontext.debts.Remove(product);

            if (reult != null)
            {
                await _dbcontext.SaveChangesAsync();
                return new ApiSuccessResult<bool>();

            }
            return new ApiErrorResult<bool>("Xóa không thành công");
        }

        [Obsolete]
        public async Task<ApiResult<bool>> DeleteALL(string guestID)
        {
            var product = await _dbcontext.debts.Where(x =>x.GuestID.Equals(guestID)).FirstOrDefaultAsync();

            if (product == null)
            {
                return new ApiErrorResult<bool>("Mã khách hàng không tồn tại");
            }
            var reult =  _dbcontext.Database.ExecuteSqlCommand($"Delete debt where guestID = {guestID}");

            if (reult > 0)
            {
                await _dbcontext.SaveChangesAsync();
                return new ApiSuccessResult<bool>();

            }
            return new ApiErrorResult<bool>("Xóa không thành công");
        }

        public async Task<PagedResult<DebtVm>> GetAllDebt(GetManageDebtPagingRequest request)
        {
            var querySearch = (from deb in _dbcontext.debts
                               join pro in _dbcontext.Improducts on deb.ProductID equals pro.Id
                               join guest in _dbcontext.guests on deb.GuestID equals guest.ID
                               select new { deb, guest});
           
            if (!string.IsNullOrEmpty(request.Keyword))
                querySearch = querySearch.Where(x => x.deb.GuestID.Contains(request.Keyword));
            
            var data = await querySearch.GroupBy(c => new { c.deb.GuestID, c.guest.FirtName, c.guest.LastName })
                .Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(c => new DebtVm()
                {
                    GuestID = c.Key.GuestID,
                    GuestFName = c.Key.FirtName,
                    GuestLName = c.Key.LastName,
                    TotalDebt = c.Sum((x => x.deb.TotalDebt)),
                }).ToListAsync();
            int totalRow = data.Count();
            var pageResult = new PagedResult<DebtVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pageResult;
            //var querySearch = (from deb in _dbcontext.debts
            //                   join pro in _dbcontext.Improducts on deb.ProductID equals pro.Id
            //                   select new { deb, pro });
            //if (!string.IsNullOrEmpty(request.Keyword))
            //    querySearch = querySearch.Where(x => x.deb.GuestID.Contains(request.Keyword));
            //int totalRow = await querySearch.CountAsync();
            //var data = await querySearch.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).
            //    Select(x => new DebtVm()
            //    {
            //        ID = x.deb.ID,
            //        GuestID = x.deb.GuestID,
            //        ProductID = x.deb.ProductID,
            //        CreateDateDebt = x.deb.CreateDateDebt,
            //        TotalDebt = x.deb.TotalDebt
            //    }).ToListAsync();

        }

        public async Task<PagedResult<DebtVm>> GetDebtByGuestID(GetManageDebtPagingRequest request,string ID)
        {
            var querySearch = from debt in _dbcontext.debts
                              join gu in _dbcontext.guests on debt.GuestID equals gu.ID
                              where debt.GuestID.Equals(ID)
                              select new { gu, debt };
          var data = await querySearch.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).
               Select(x => new DebtVm()
               {
                   ID = x.debt.ID,
                   GuestID = x.debt.GuestID,
                   ProductID = x.debt.ProductID,
                   CreateDateDebt = x.debt.CreateDateDebt,
                   GuestFName = x.gu.FirtName,
                   GuestLName = x.gu.LastName,
                   TotalDebt = x.debt.TotalDebt
               }).ToListAsync();
            int totalRow = querySearch.Count();
            var pageResult = new PagedResult<DebtVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pageResult;
        }

       
    }
}
