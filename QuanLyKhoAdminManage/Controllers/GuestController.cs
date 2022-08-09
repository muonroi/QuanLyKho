using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoViewModels.Catalog.Guest;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Controllers
{
    public class GuestController : BaseController
    {
        private readonly IGuestApiServices _services;
        private readonly IConfiguration _configuration;
        public GuestController(IGuestApiServices services, IConfiguration configuration)
        {
            _services = services;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 2)
        {

            var request = new GetManageGuestPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _services.GetPagings(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            ViewBag.Info = info;
            return View(data);
        }

    }
}
