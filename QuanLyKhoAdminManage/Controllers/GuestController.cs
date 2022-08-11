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
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
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
            if (TempData["err"] != null)
            {
                ViewBag.Err = TempData["err"];
            }
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            ViewBag.Info = info;
            return View(data);
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            return View(new GuestDelRequest()
            {
                GuestID = id
            });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(GuestDelRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _services.DeleteGuest(request.GuestID);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Xóa khách hàng thành công";
                return RedirectToAction("Index");
            }
            TempData["err"] = result.Message;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] GuestCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _services.CreateGuest(request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Thêm khách thành công!";
                return RedirectToAction("Index");

            }
            TempData["err"] = result.Message;
            return RedirectToAction("Index");
        }
    }
}
