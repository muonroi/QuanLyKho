using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoData.EF;
using QuanLyKhoViewModels.Catalog.Bank;
using QuanLyKhoViewModels.Catalog.Guest;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Controllers
{
    public class GuestController : BaseController
    {
        QuanLyKhoDbContext _context;
        private readonly IGuestApiServices _services;
        private readonly IConfiguration _configuration;
        public GuestController(IGuestApiServices services
            , IConfiguration configuration, QuanLyKhoDbContext context)
        {
            _services = services;
            _configuration = configuration;
            _context = context;
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
        public async Task<IActionResult> BankIndex(string keyword, int pageIndex = 1, int pageSize = 10)
        {

            var request = new GetManageBankPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _services.GetPagingsBank(request);
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
                TempData["result"] = "Thêm khách hàng thành công!";
                return RedirectToAction("Index");

            }
            TempData["err"] = result.Message;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BankCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BankCreate([FromForm] BankCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _services.CreateBank(request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Thêm thông tin thành công!";
                return RedirectToAction("BankIndex");

            }
            TempData["err"] = result.Message;
            return RedirectToAction("BankIndex");
        }
        [HttpPost]
        public IActionResult DeleteBankAll(IFormCollection formCollection)
        {
            bool count = false;
            if (!ModelState.IsValid)
                return View();
            string[] ids = formCollection["ID"].ToString().Split(new char[] { ',' });
            foreach (string id in ids)
            {

                count = true;
                TempData["result"] = "Xóa thành công";
                int idss = int.Parse(id);
                var employee = this._context.banks.Where(s => s.ID.Equals(idss)).FirstOrDefault();
                this._context.banks.Remove(employee);
                this._context.SaveChanges();
            }
            if (count == false)
                TempData["err"] = "Xóa thất bại!";
            return RedirectToAction("BankIndex");


        }
    }
}
