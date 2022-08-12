﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoAppLication.Catalog.Products;
using QuanLyKhoData.EF;
using QuanLyKhoViewModels.Catalog.Exporduct;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.System.Products;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Controllers
{
    public class ProductController : BaseController
    {
        private string strings { get; set; }
        private string vh_tr { get; set; }
        private string vh_take { get; set; }
        QuanLyKhoDbContext _context;
        private readonly IProductApiClient _ProductApiClient;
        private readonly IConfiguration _configuration;
        public ProductController(IProductApiClient userApiClient,
            IConfiguration configuration, QuanLyKhoDbContext context)
        {
            _context = context;
            _ProductApiClient = userApiClient;
            _configuration = configuration;
            var httpContext = new HttpContextAccessor().HttpContext;
            strings = httpContext.User.Identity.Name;
           
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            
            var request = new GetManageProductPagingRequest()
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
            else if (TempData["err"] != null)
            {
                ViewBag.Err = TempData["err"];
            }
            return View(data);
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            return View(new ProductDeleteRequest()
            {
                ProductID = id
            });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(ProductDeleteRequest request)
        {
                if (!ModelState.IsValid)
                    return View();

                var result = await _ProductApiClient.DeleteProduct(request.ProductID);
                if (result.IsSuccessed)
                {
                    TempData["result"] = "Xóa sản phẩm thành công";
                    return RedirectToAction("Index");
                }

            TempData["err"] = result.Message;
            return RedirectToAction("Index");


        }
        public SelectList GetGuestID(QuanLyKhoDbContext _context)
        {
            return (SelectList)(ViewData["Guest"] = new SelectList(_context.guests.Select(x =>x.ID).ToList(), "Id"));
        }
        [HttpGet]
        public async Task<IActionResult> GetSales(string guID)
        {
            TempData["guest"] = "100";
            var totaldeb = await _context.debts.Where(x => x.GuestID.Equals(guID)).SumAsync(x => x.TotalDebt);
            TempData["guest"] = totaldeb.ToString();
            return Ok(totaldeb.ToString());
        }
       
        [HttpGet]
        public async Task<IActionResult> Sales(string id)
        {
            var result = await _ProductApiClient.GetByIdEx(id);
            ViewBag.IDS = id;
            
            GetGuestID(_context);
            return View(result.ResultObj);
        }
      
        [HttpPost]
        public async Task<IActionResult> Sales([FromForm] ProductCreateExRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _ProductApiClient.CreateEXProduct(request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Bán sản phẩm thành công!";
                return RedirectToAction("Index");

            }
            TempData["err"] = result.Message;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var result = await _ProductApiClient.GetById(id);
            return View(result.ResultObj);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _ProductApiClient.CreateProduct(request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Thêm sản phẩm thành công!";
                return RedirectToAction("Index");

            }
            TempData["err"] = result.Message;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            var result = await _ProductApiClient.GetByIdim(ID);
            TempData["ID"] = ID;
            return View(result.ResultObj);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromForm] ProductEditRequest request)
        {
            string ID = TempData["ID"].ToString();
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _ProductApiClient.Update(ID, request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Sửa sản phẩm thành công!";
                return RedirectToAction("Index");

            }
            TempData["err"] = result.Message;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult AutoComplete(string prefix)
        {
            var customers = (from product in _context.Improducts
                             where product.Id.StartsWith(prefix)
                             group product by product.Id into g
                             select new
                             {
                                 label = g.Key,
                                 val = g.Key
                             }).ToList();

            return Json(customers);
        }
        [HttpGet]
        public IActionResult Getdata(string vehicle_trs)
        {
            var a = Json(vehicle_trs);
            return a;
        }
        [HttpPost]
        public async Task<IActionResult> Report(string vehicle_tr, string vehicle_take)
        {
            var data = await _ProductApiClient.Report(strings);
            if (data.TotalRecords == 0)
            {
                TempData["err"] = "Không có sản phẩm bán";
                return RedirectToAction("Index");  
            }
            decimal sumtt = await _ProductApiClient.SumToTal();
            decimal sumdebts = await _ProductApiClient.Sumdebt(true);
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            Random res = new Random();
            String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int size = 4;
            String ran = "";
            for (int i = 0; i < size; i++)
            {
                int x = res.Next(26);
                ran = ran + str[x];
            }
            ViewBag.Issucess = sumdebts > 0?true:false;
            ViewBag.IDBILL = ran;
            ViewBag.Info = info;
            ViewBag.TotalSum = sumtt;
            ViewBag.TotalDebt = sumdebts;
            ViewBag.vehicle_tr = vehicle_tr;
            ViewBag.vehicle_take = vehicle_take;
            await SetFalse();
            return View(data);
        }
        public async Task<IActionResult> SetFalse()
        {
            var data = await _ProductApiClient.SetFalse();
            if (data > 0)
            {
                RedirectToAction("Index");
            }
            return View(data);
        }


    }
}
