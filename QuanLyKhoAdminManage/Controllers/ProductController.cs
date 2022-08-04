using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using QuanLyKhoAdminManage.Services;
using QuanLyKhoData.EF;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.System.Products;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Controllers
{
    public class ProductController : BaseController
    {
        QuanLyKhoDbContext _context;
        private readonly IProductApiClient _ProductApiClient;
        private readonly IConfiguration _configuration;
        public ProductController(IProductApiClient userApiClient,
            IConfiguration configuration, QuanLyKhoDbContext context)
        {
            _context = context;
            _ProductApiClient = userApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 2)
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

                ModelState.AddModelError("", result.Message);
                return View(request);

           
        }
        public SelectList GetGuestID(QuanLyKhoDbContext _context)
        {
            return (SelectList)(ViewData["Guest"] = new SelectList(_context.guests.Select(x =>x.ID).ToList(), "Id"));
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
        public IActionResult PDF (ProductCreateExRequest request)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Document document = new Document(PageSize.A4, 25, 25, 15, 15);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, ms);
                document.Open();
                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(@"C:\Users\muonroi\AppData\Local\Microsoft\Windows\Fonts\ARIALUNI.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font f = new Font(bf, 12, Font.NORMAL);
                var image = iTextSharp.text.Image.GetInstance("wwwroot/images/d876f2461797d5c98c86.jpg");
                image.Alignment = Element.ALIGN_LEFT;
                image.SetAbsolutePosition(500, 750);
                image.ScaleAbsoluteHeight(100);
                image.ScaleAbsoluteWidth(100);
                document.Add(image);

                Paragraph para0 = new Paragraph(@"HÓA ĐƠN BÁN HÀNG", f);
                para0.Alignment = Element.ALIGN_CENTER;
                para0.Alignment = Element.ALIGN_TOP;
                document.Add(para0);

                Paragraph para4 = new Paragraph(@$"Mã khách hàng: {request.GuestID}", f);
                para4.Alignment = Element.ALIGN_TOP;
                para4.Alignment = Element.ALIGN_CENTER;
                document.Add(para4);

                Paragraph para2 = new Paragraph("Địa chỉ: 1053 Quốc Lộ 1A, Phường Tân Khánh,\n TP Tân An, Long An", f);
                para2.Alignment = Element.ALIGN_TOP;
                para2.Alignment = Element.ALIGN_CENTER;
                document.Add(para2);


                Paragraph para29 = new Paragraph(@$"{request.ExDate}", f);
                para29.Alignment = Element.ALIGN_LEFT;
                document.Add(para29);
                for (int i = 0; i < 2; i++)
                {
                    Paragraph para91 = new Paragraph(@$" ", f);
                    para91.Alignment = Element.ALIGN_LEFT;
                    para91.Alignment = Element.ALIGN_BOTTOM;
                    document.Add(para91);
                }


                PdfPTable table = new PdfPTable(3);
                table.PaddingTop = 500f;
                PdfPCell cell2 = new PdfPCell(new Phrase("Mã sản phẩm", f));
                cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell2.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER |
                    Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                cell2.BorderWidthBottom = 1f;
                cell2.BorderWidthTop = 1f;
                cell2.BorderWidthLeft = 1f;
                cell2.BorderWidthRight = 1f;

                cell2.Padding = 2f;
                cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                cell2.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell2);

                PdfPCell cell5 = new PdfPCell(new Phrase("Số lượng bán", f));
                cell5.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell5.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER |
                    Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                cell5.BorderWidthBottom = 1f;
                cell5.BorderWidthTop = 1f;
                cell5.BorderWidthLeft = 1f;
                cell5.BorderWidthRight = 1f;
                cell5.Padding = 2f;
                cell5.HorizontalAlignment = Element.ALIGN_CENTER;
                cell5.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell5);

                PdfPCell cell7 = new PdfPCell(new Phrase("Số tiền nợ", f));
                cell7.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell7.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER |
                    Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                cell7.BorderWidthBottom = 1f;
                cell7.BorderWidthTop = 1f;
                cell7.BorderWidthLeft = 1f;
                cell7.BorderWidthRight = 1f;
                cell7.Padding = 2f;
                cell7.HorizontalAlignment = Element.ALIGN_CENTER;
                cell7.VerticalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell7);

                PdfPCell cell_2 = new PdfPCell(new Phrase(request.importID.ToString()));
                PdfPCell cell_3 = new PdfPCell(new Phrase(request.Quantity.ToString()));
                PdfPCell cell_4 = new PdfPCell(new Phrase(request.debttotal.ToString() + " Vnd"));
                cell_2.HorizontalAlignment = Element.ALIGN_CENTER;
                cell_2.Padding = 5f;
                cell_3.HorizontalAlignment = Element.ALIGN_CENTER;
                cell_3.Padding = 5f;
                cell_4.HorizontalAlignment = Element.ALIGN_CENTER;
                cell_4.Padding = 5f;

                table.AddCell(cell_2);
                table.AddCell(cell_3);
                table.AddCell(cell_4);
                document.Add(table);

                for (int i = 0; i < 2; i++)
                {
                    Paragraph para92 = new Paragraph(@$" ", f);
                    para92.Alignment = Element.ALIGN_LEFT;
                    para92.Alignment = Element.ALIGN_BOTTOM;
                    document.Add(para92);
                }
                Paragraph para9 = new Paragraph(@$"Giá Tiền: {request.SalesPrice} Vnđ", f);
                para9.Alignment = Element.ALIGN_RIGHT;
                document.Add(para9);

                document.Close();
                pdfWriter.Close();
                var constant = ms.ToArray();
                return File(constant, "application/vnd", "hoadonban.pdf");
            }
           
        }
        [HttpPost]
        public async Task<IActionResult> Sales([FromForm] ProductCreateExRequest request, string btn = "")
        {

            if (btn.Equals("Xuất hóa đơn"))
            {
               return RedirectToAction("Report");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var result = await _ProductApiClient.CreateEXProduct(request);
            if (result.IsSuccessed)
            {
                PDF(request);
                TempData["result"] = "Bán sản phẩm thành công!";
                return RedirectToAction("Index");

            }
            ModelState.AddModelError($"", result.Message);
            return View(request);
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
            ModelState.AddModelError("", result.Message);
            return View(request);
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
        public async Task<IActionResult> Report()
        {
           var data = await _ProductApiClient.Report();
            decimal sumtt = await _ProductApiClient.SumToTal();
            decimal sumdebts = await _ProductApiClient.Sumdebt();
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            ViewBag.Info = info;
            ViewBag.TotalSum = sumtt;
            ViewBag.TotalDebt = sumdebts;

            return View(data);
        }
    }
}
