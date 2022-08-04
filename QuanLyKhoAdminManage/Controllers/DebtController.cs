using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoData.EF;
using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.System.Debt;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Controllers
{
    public class DebtController : BaseController
    {
        QuanLyKhoDbContext _context;
        private readonly IDebtApiServices _ProductApiClient;
        private readonly IConfiguration _configuration;
        public DebtController(IDebtApiServices userApiClient,
            IConfiguration configuration, QuanLyKhoDbContext context)
        {
            _context = context;
            _ProductApiClient = userApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 2)
        {

            var request = new GetManageDebtPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _ProductApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            ViewBag.Info = info;
            return View(data);
        }
        [HttpPost]
        public IActionResult AutoComplete(string prefix)
        {
            var customers = (from product in _context.debts
                             where product.GuestID.StartsWith(prefix) 
                             group product by product.GuestID into g
                             select new
                             {
                                 label = g.Key,
                                 val = g.Key
                                 
                             }).ToList();

            return Json(customers);
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            return View(new DebtDeleteRequest()
            {
                DebtID = id
            });
        }
        public SelectList GetGuestID(QuanLyKhoDbContext _context)
        {
            return (SelectList)(ViewData["Guest"] = new SelectList(_context.guests.Select(x => x.ID).ToList(), "Id"));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(DebtDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _ProductApiClient.DeleteDebt(request.DebtID);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Xóa hóa đơn thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);


        }

        [HttpGet("deleteall")]
        public IActionResult DeleteAll()
        {
            GetGuestID(_context);
            return View();
        }
        [HttpPost("deleteall")]
        public async Task<IActionResult> DeleteAll(DebtDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _ProductApiClient.DeleteDebtAll(request.DebtID);
            
            if (result.IsSuccessed)
            {
                TempData["result"] = "Xóa tất cả hóa đơn thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);


        }

    }
}
