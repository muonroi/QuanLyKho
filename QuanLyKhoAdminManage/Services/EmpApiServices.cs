using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using QuanLyKhoViewModels.Catalog.Emp;
using QuanLyKhoViewModels.Common;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public class EmpApiServices : BaseApiClient, IEmpApiServices
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public EmpApiServices(IHttpClientFactory httpClientFactory,
                  IHttpContextAccessor httpContextAccessor,
                   IConfiguration configuration)
           : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<PagedResult<EmpViewModel>> GetPagings(GetManageEmpPagingRequest request)
        {
            var data = await GetAsync<PagedResult<EmpViewModel>>(
                $"/api/Employee/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}");
            return data;
        }
    }
}
