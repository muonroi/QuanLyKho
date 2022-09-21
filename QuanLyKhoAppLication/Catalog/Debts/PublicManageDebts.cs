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
                CreateDateDebt = DateTime.Now,
                TotalDebt = request.TotalDebt,
                ProductID = request.ProductID,
                GuestID = request.GuestID,
            };
            _dbcontext.debts.Add(data);
            return await _dbcontext.SaveChangesAsync();
        }   

        public async Task<ApiResult<bool>> CreateDebtImport(DebtCreateRequest request)
        {
            var data = new DebtImports()
            {
                CreateDateDebt = DateTime.Now,
                TotalDebt = request.TotalDebt,
                ProductID = request.ProductID,
                GuestID = request.GuestID,
            };
            _dbcontext.debtImports.Add(data);
            var rs = await _dbcontext.SaveChangesAsync();
            if (rs <= 0)
            {
                return new ApiErrorResult<bool>("Vui lòng thử lại");
            }
            else if (rs > 0)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Vui lòng thử lại");
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
                              // from debthist in _dbcontext.historyDebts
                               join pro in _dbcontext.Improducts on deb.ProductID equals pro.Id
                               join guest in _dbcontext.guests on deb.GuestID equals guest.ID
                               select new { deb, guest });
           
            if (!string.IsNullOrEmpty(request.Keyword))
                querySearch = querySearch.Where(x => x.deb.GuestID.Contains(request.Keyword));
            
            var data = await querySearch.GroupBy(c => new { c.deb.GuestID, c.guest.FirtName, c.guest.LastName })
                .Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(c => new DebtVm()
                {
                    //BankName = c.Key.BankName,
                    //DebtFee = c.Key.DebtFee,
                    //PayDay = c.Key.PayDay,
                    //GuestIDs = c.Key.GuestIDS,
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
          

        }

        public async Task<PagedResult<DebtVm>> GetAllDebtHis(GetManageDebtPagingRequest request)
        {
            var querySearch = (from debthist in _dbcontext.historyDebts
                               join pro in _dbcontext.Exproducts on debthist.GuestIDS equals pro.GuestID
                               join guest in _dbcontext.guests on debthist.GuestIDS equals guest.ID
                               select new { debthist, pro, guest });

            if (!string.IsNullOrEmpty(request.Keyword))
                querySearch = querySearch.Where(x => x.debthist.GuestIDS.Contains(request.Keyword));

            var data = await querySearch.GroupBy(c => new { c.debthist.GuestIDS, c.guest.FirtName, c.guest.LastName })
                .Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(c => new DebtVm()
                {
                    GuestID = c.Key.GuestIDS,
                    GuestFName = c.Key.FirtName,
                    GuestLName = c.Key.LastName,
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
        }

        public async Task<PagedResult<DebtVm>> GetAllDebtHisById(GetManageDebtPagingRequest request,string Id)
        {
            var querySearch = from hist in _dbcontext.historyDebts
                              where hist.GuestIDS.Equals(Id)
                              select hist;
            var data = await querySearch.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).
                 Select(x => new DebtVm()
                 {
                     GuestID = x.GuestIDS,
                     BankName = x.BankName,
                     DebtFee = x.DebtFee,
                     PayDay = x.PayDay
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

        public async Task<PagedResult<DebtVm>> GetImportDebt(GetManageDebtPagingRequest request)
        {
            var querySearch = from deb in _dbcontext.debtImports
                              select deb;
            if (!string.IsNullOrEmpty(request.Keyword))
                querySearch = querySearch.Where(x => x.GuestID.Contains(request.Keyword));
            var data = await querySearch.Select(x =>x)
                .Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(c => new DebtVm()
                {
                    GuestID = c.GuestID,
                    ProductID = c.ProductID,
                    CreateDateDebt = c.CreateDateDebt,
                    TotalDebt = c.TotalDebt
                }).ToListAsync();
            int totalRow = data.Count();
            //var querySearch = (from deb in _dbcontext.debtImports
            //                   join pro in _dbcontext.importPros on deb.ProductID equals pro.Id
            //                   join guest in _dbcontext.guests on deb.GuestID equals guest.ID
            //                   select new { deb, guest });

            //if (!string.IsNullOrEmpty(request.Keyword))
            //    querySearch = querySearch.Where(x => x.deb.GuestID.Contains(request.Keyword));

            //var data = await querySearch.GroupBy(c => new { c.deb.GuestID, c.guest.FirtName, c.guest.LastName })
            //    .Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            //    .Select(c => new DebtVm()
            //    {
            //        GuestID = c.Key.GuestID,
            //        GuestFName = c.Key.FirtName,
            //        GuestLName = c.Key.LastName,
            //        TotalDebt = c.Sum((x => x.deb.TotalDebt)),
            //    }).ToListAsync();
            //int totalRow = data.Count();
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
