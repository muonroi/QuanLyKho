using Microsoft.EntityFrameworkCore;
using QuanLyKhoData.EF;
using QuanLyKhoData.Entities;
using QuanLyKhoViewModels.Catalog.Bank;
using QuanLyKhoViewModels.Catalog.Emp;
using QuanLyKhoViewModels.Catalog.Guest;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Guests
{
    public class PublicManageGuests : IPublicManageGuests
    {
        private readonly QuanLyKhoDbContext _dbcontext;
        public PublicManageGuests(QuanLyKhoDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<ApiResult<bool>> Create(GuestCreateRequest request)
        {
                var productim = await _dbcontext.guests.FindAsync(request.ID);
                //var Email = await 
                if (productim == null)
                {
                    var products = new Guest()
                    {
                        ID = request.ID,
                        LastName = request.LastName,
                        FirtName = request.FirtName,
                        Dob = request.Dob,
                        PhoneNumber = request.PhoneNumber,
                        Email = request.Email,
                    };
                    var result = await _dbcontext.guests.AddAsync(products);
                    if (result != null)
                    {
                        await _dbcontext.SaveChangesAsync();
                        return new ApiSuccessResult<bool>();
                    }
                    
                }
            return new ApiErrorResult<bool>("Thêm thất bại");
        }

        public async Task<ApiResult<bool>> CreateBank(BankCreateRequest request)
        {
            var products = new Bank()
            {
                BankName = request.BankName,
                GuestId = request.GuestId,
                Detail = request.GuestId,
                TotalFee = request.TotalFee,
            };
            var result = await _dbcontext.banks.AddAsync(products);
            if (result != null)
            {
                await _dbcontext.SaveChangesAsync();
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Thêm thất bại");
        }

        public async Task<ApiResult<bool>> Delete(string ID)
        {
            var product = await _dbcontext.guests.FindAsync(ID);
            var checkdebt = await _dbcontext.debts.Where(x => x.GuestID.Equals(ID)).FirstOrDefaultAsync();
            if (product == null)
            {
                return new ApiErrorResult<bool>("Khách hàng không tồn tại");
            }
            if (checkdebt != null)
            {
                return new ApiErrorResult<bool>("Khách hàng đang còn nợ không thể xóa");
            }
            var reult = _dbcontext.guests.Remove(product);
            if (reult != null)
            {
                await _dbcontext.SaveChangesAsync();
                return new ApiSuccessResult<bool>();

            }

            return new ApiErrorResult<bool>("Xóa không thành công");
        }
        public async Task<PagedResult<BankVM>> GetAllBank(GetManageBankPagingRequest request)
        {
            var querySearch = (from bank in _dbcontext.banks
                               select bank);
            if (!string.IsNullOrEmpty(request.Keyword))
                querySearch = querySearch.Where(x => x.BankName.Contains(request.Keyword));
            int totalRow = await querySearch.CountAsync();
            var data = await querySearch.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).
                Select(x => new BankVM()
                {
                    ID = x.ID,
                    BankName = x.BankName,
                    GuestId = x.GuestId,
                    TotalFee = x.TotalFee,
                    Detail = x.Detail
                }).ToListAsync();
            var pageResult = new PagedResult<BankVM>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pageResult;
        }
        public async Task<PagedResult<GuestViewModels>> GetAllEmp(GetManageGuestPagingRequest request)
        {
            var querySearch = (from deb in _dbcontext.guests
                               select deb);
            if (!string.IsNullOrEmpty(request.Keyword))
                querySearch = querySearch.Where(x => x.ID.Contains(request.Keyword));
            int totalRow = await querySearch.CountAsync();
            var data = await querySearch.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).
                Select(x => new GuestViewModels()
                {
                    ID = x.ID,
                    FirtName = x.FirtName,
                    LastName = x.LastName,
                    Dob = x.Dob,
                    PhoneNumber = x.PhoneNumber,
                    Email = x.Email,
                }).ToListAsync();
            var pageResult = new PagedResult<GuestViewModels>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pageResult;
        }

        public Task<List<GuestCreateRequest>> GetDebtByEmpID(string ID)
        {
            throw new NotImplementedException();
        }

       
    }
}
