using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Debt;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public class DebtApiServices:BaseApiClient,IDebtApiServices
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public DebtApiServices(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<bool>> DeleteDebt(string request)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddr"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.DeleteAsync($"/api/debt/{request}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(body);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(body);
        }

        public async Task<ApiResult<bool>> DeleteDebtAll(string request)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddr"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.DeleteAsync($"/api/debt/deleteall/{request}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(body);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(body);
        }

        public async Task<PagedResult<DebtVm>> GetDebtByGuestID(GetManageDebtPagingRequest request,string ID)
        {
            var data = await GetAsync<PagedResult<DebtVm>>($"/api/debt/detail/{ID}?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}");
            return data;
        }

        public async Task<PagedResult<DebtVm>> GetPagings(GetManageDebtPagingRequest request)
        {
            var data = await GetAsync<PagedResult<DebtVm>>(
                $"/api/debt/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}");
            return data;
        }

        public async Task<PagedResult<DebtVm>> GetPagingsHis(GetManageDebtPagingRequest request)
        {
            var data = await GetAsync<PagedResult<DebtVm>>(
               $"/api/debt/pagings?pageIndex={request.PageIndex}" +
               $"&pageSize={request.PageSize}" +
               $"&keyword={request.Keyword}");
            return data;
        }
        public async Task<PagedResult<DebtVm>> GetPagingsHisById(GetManageDebtPagingRequest request,string Id)
        {
            var data = await GetAsync<PagedResult<DebtVm>>(
               $"/api/debt/pagings/{Id}?pageIndex={request.PageIndex}" +
               $"&pageSize={request.PageSize}" +
               $"&keyword={request.Keyword}");
            return data;
        }
    }
}
