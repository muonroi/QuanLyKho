using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using QuanLyKhoAdminManage.Models;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoData.EF;
using QuanLyKhoViewModels.Catalog.Debt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        QuanLyKhoDbContext _context;
        private readonly IProductApiClient _ProductApiClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<HomeController> _logger;
        private readonly IDebtApiServices _DebtApiClient;
        public HomeController(IProductApiClient userApiClient,
            IConfiguration configuration, ILogger<HomeController> logger, QuanLyKhoDbContext context,
            IDebtApiServices debtApiClient)
        {
            _context = context;
            _ProductApiClient = userApiClient;
            _configuration = configuration;
            _logger = logger;
            _DebtApiClient = debtApiClient;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 2)
         {
            var sumdebts = _context.guests.AsNoTracking().Select(x => x).Count();
            var querySearch = _context.Exproducts.AsNoTracking().Select(x => x).Count();
            var querySearch34 = _context.Exproducts.AsNoTracking().Select(x => x);

            var querySearch2 = _context.debts.AsNoTracking().Select(x => x);
            var querySearch3 = _context.Improducts.AsNoTracking().Select(x => x);
            var totalFee = await querySearch34.AsNoTracking().SumAsync(x => x.SalesPrice);
            var totalFeeImport = await querySearch3.AsNoTracking().SumAsync(x => x.OriginPrice);
            var interest = totalFee - totalFeeImport;
            var totalDebt = await querySearch2.AsNoTracking().SumAsync(x => x.TotalDebt);
            ViewBag.Debt = sumdebts;
            ViewBag.TotalRow = querySearch;
            ViewBag.TotalFee = interest;
            ViewBag.TotalDebt = totalDebt;
            var request = new GetManageDebtPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _DebtApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            ViewBag.Info = info;
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
