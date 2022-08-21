using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Configuration;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoData.EF;
using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.System.Debt;
using System.Linq;
using System.Threading.Tasks;
using QuanLyKhoData.Entities;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> History(string keyword, int pageIndex = 1, int pageSize = 10)
        {

            var request = new GetManageDebtPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _ProductApiClient.GetPagingsHis(request);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(IFormCollection formCollection)
        {
            bool count = false;
            if (!ModelState.IsValid)
                return View();

            string[] ids = formCollection["ID"].ToString().Split(new char[] { ',' });
            string[] id2 = formCollection["cars"].ToString().Split(new char[] { ',' });

            for (int i = 0; i < ids.Length; i++)
            {
                if (!id2[i].Equals("null"))
                {
                    var DebtHistory = new HistoryDebt()
                    {
                        GuestIDS = this._context.debts.Find(int.Parse(ids[i])).GuestID,
                        BankName = id2[i],
                        DebtFee = this._context.debts.Find(int.Parse(ids[i])).TotalDebt,
                        PayDay = DateTime.Now
                    };
                    this._context.Add(DebtHistory);
                    this._context.SaveChanges();
                }
              
               
            }
            foreach (string id in ids)
            {
                count = true;
                TempData["result"] = "Xóa thành công";
                var employee = this._context.debts.Find(int.Parse(id));
                this._context.debts.Remove(employee);
                this._context.SaveChanges();
            }
            if (count == false)
                TempData["err"] = "Xóa thất bại!";
            return RedirectToAction("Index");


        }
        [HttpPost("deleteall")]
        public IActionResult DeleteAll(IFormCollection formCollection)
        {
            bool count = false;
            if (!ModelState.IsValid)
                return View();
            string[] ids = formCollection["ID"].ToString().Split(new char[] { ',' });
            foreach (string id in ids)
            {
                count = true;
                TempData["result"] = "Xóa thành công";
                var employee = this._context.debts.Where(s => s.GuestID.Equals(id)).FirstOrDefault();
                this._context.debts.Remove(employee);
                this._context.SaveChanges();
            }
            if (count == false)
                TempData["err"] = "Xóa thất bại!";
             return  RedirectToAction("Index");


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
        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> Pay(string GuestID,decimal fee,string bankname)
        {
            var DebtHistory = new HistoryDebt()
            {
                GuestIDS = GuestID,
                BankName = bankname,
                DebtFee = fee,
                PayDay = DateTime.Now
            };
            _context.historyDebts.Add(DebtHistory);
             _context.SaveChanges();
            int result = await _context.debts.Where(x => x.GuestID.Equals(GuestID)).CountAsync();
            decimal total = fee / result;
            var rs = _context.Database.ExecuteSqlCommand($"UPDATE DEBT SET TOTALDEBT = TOTALDEBT - {total} WHERE GUESTID = {GuestID}");
            if (rs > 0)
            {
                TempData["result"] = "Thanh toán thành công!";
                
            }
            else
                TempData["err"] = "Thanh toán thất bại!";
            return Json(new { redirectToUrl = Url.Action("Index", "debt") });
        }
    }
}
