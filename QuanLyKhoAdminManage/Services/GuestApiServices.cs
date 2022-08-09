using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using QuanLyKhoViewModels.Catalog.Guest;
using QuanLyKhoViewModels.Common;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public class GuestApiServices : BaseApiClient, IGuestApiServices
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public GuestApiServices(IHttpContextAccessor httpContextAccessor, IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<PagedResult<GuestViewModels>> GetPagings(GetManageGuestPagingRequest request)
        {
            var data = await GetAsync<PagedResult<GuestViewModels>>(
               $"/api/Guest/paging?pageIndex={request.PageIndex}" +
               $"&pageSize={request.PageSize}" +
               $"&keyword={request.Keyword}");
            return data;
        }
    }
}
