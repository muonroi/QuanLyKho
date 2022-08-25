using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoAppLication.Catalog.Products;
using QuanLyKhoData.EF;
using QuanLyKhoData.Entities;
using QuanLyKhoViewModels.Catalog.Exporduct;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.System.Debt;
using QuanLyKhoViewModels.System.Products;
using System;
using System.Collections.Generic;
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
            return (SelectList)(ViewData["Guest"] = new SelectList(_context.guests.Select(x => x.ID).ToList(), "Id"));
        }
        [HttpPost]
        public async Task<IActionResult> AjaxMethod(string sessionName)
        {
            var querySearch = (from deb in _context.debts
                               join pro in _context.Improducts on deb.ProductID equals pro.Id
                               join guest in _context.guests on deb.GuestID equals guest.ID
                               select new { deb, guest });
            var data = await querySearch.GroupBy(c => new { c.deb.GuestID, c.guest.FirtName, c.guest.LastName })
                .Select(c => new DebtVm()
                {
                    GuestID = c.Key.GuestID,
                    GuestFName = c.Key.FirtName,
                    GuestLName = c.Key.LastName,
                    TotalDebt = c.Sum((x => x.deb.TotalDebt)),
                }).ToListAsync();
            var moviesById = data.ToDictionary(keySelector: m => m.GuestID, elementSelector: m => m.TotalDebt);
            foreach (var item in moviesById)
            {
                if (item.Key.Equals(sessionName))
                {
                    HttpContext.Session.SetString(sessionName, item.Value.ToString());
                }
            }

            return Json(HttpContext.Session.GetString(sessionName));
        }

        [HttpPost]
        public IActionResult AutoComplete2(string prefix)
        {
            var customers = (from product in _context.Improducts
                             where product.Id.Equals(prefix)
                             select product).ToList();

            return Json(customers);
        }

        [HttpGet]
        public async Task<IActionResult> Sales(string id)
        {
            var result = await _ProductApiClient.GetByIdEx(id);
            ViewBag.IDS = id;
            
            GetGuestID(_context);
            return View(result.ResultObj);
        }
        [HttpGet]
        public IActionResult Saless()
        {
            // This is only for show by default one row for insert data to the database
            List<ProductCreateExRequest> ci = new List<ProductCreateExRequest>
            { new ProductCreateExRequest
                {
                    
                    importID = default,
                    ToTalSum = default,
                    Quantity = default,
                    weight = default,
                    SalesPrice = default,
                    tongtien = default,
                    GuestID=default,
                    debttotal = default,
                    StatusDebt = default
                }
            };
            return View(ci);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> BulkData(List<ProductCreateExRequest> ci)
       {

            if (ModelState.IsValid)
            {
                foreach (var item in ci)
                {
                    var result = await _ProductApiClient.CreateEXProduct(item);
                    if (result.IsSuccessed)
                    {
                        TempData["result"] = "Lập hóa đơn thành công!";

                    }
                }
            }
            else if(!(ModelState.IsValid))
            {
                TempData["err"] = "Vui lòng nhập đúng thông tin!";

            }
            ModelState.Clear();
            return RedirectToAction("Index");
        }
        [Obsolete]
        public JsonResult InsertCustomers(List<ExportProduct> customers)
        {
            
                //Truncate Table to delete all old records.  
                _context.Database.ExecuteSqlCommand("TRUNCATE TABLE exportproduct");

                //Check for NULL.  
                if (customers == null)
                {
                    customers = new List<ExportProduct>();
                }

                //Loop and insert records.  
                foreach (ExportProduct customer in customers)
                {
                _context.Exproducts.Add(customer);
                }
                int insertedRecords = _context.SaveChanges();
           return Json(insertedRecords);
            
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
            ViewBag.Issucess = sumdebts > 0 ? true : false;
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

        [HttpGet]
        public async Task<IActionResult> Search(string term)
        {
            if (!string.IsNullOrEmpty(term))
            {
                var states = await _context.guests.ToListAsync();
                var data = states.Where(a => a.ID.Contains(term, StringComparison.OrdinalIgnoreCase)
                || a.LastName.Contains(term, StringComparison.OrdinalIgnoreCase)
                || a.PhoneNumber.ToString().Contains(term, StringComparison.OrdinalIgnoreCase
                )).ToList().AsReadOnly();
                return Ok(data);
            }
            else
            {
                return Ok();
            }
        }
        [HttpGet]
        public async Task<IActionResult> Search2(string term)
        {
            if (!string.IsNullOrEmpty(term))
            {
                var states = await _context.Improducts.ToListAsync();
                var data = states.Where(a => a.Id.Contains(term, StringComparison.OrdinalIgnoreCase)
                || a.Name.Contains(term, StringComparison.OrdinalIgnoreCase)
                ).ToList().AsReadOnly();
                return Ok(data);
            }
            else
            {
                return Ok();
            }
        }
    }
}
