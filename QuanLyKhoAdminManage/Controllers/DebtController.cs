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
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
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
            if (TempData["err"] != null)
            {
                ViewBag.Err = TempData["err"];
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

            TempData["err"] = result.Message;
            return RedirectToAction("Index");


        }

        [HttpGet("deleteall")]
        public IActionResult DeleteAll(string id)
        {
            return View(new DebtDeleteRequest()
            {
                DebtID = id
            });
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

            TempData["err"] = result.Message;
            return RedirectToAction("Index");


        }

        [HttpPut]
        public async Task<IActionResult> Edit(DebtDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _ProductApiClient.DeleteDebtAll(request.DebtID);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Xóa tất cả hóa đơn thành công";
                return RedirectToAction("Index");
            }

            TempData["err"] = result.Message;
            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> Details(string keyword, string id, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetManageDebtPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var result = await _ProductApiClient.GetDebtByGuestID(request,id);
            return View(result);
        }
    }
}
