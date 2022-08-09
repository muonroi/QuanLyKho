using Microsoft.EntityFrameworkCore;
using QuanLyKhoData.EF;
using QuanLyKhoViewModels.Catalog.Emp;
using QuanLyKhoViewModels.Catalog.Guest;
using QuanLyKhoViewModels.Common;
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
        public Task<int> Create(GuestCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<bool>> Delete(int iddebt)
        {
            throw new NotImplementedException();
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
