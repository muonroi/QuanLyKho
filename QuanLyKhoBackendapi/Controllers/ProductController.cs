using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuanLyKhoAppLication.Catalog.Products;
using QuanLyKhoViewModels.Catalog.Exporduct;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.System.Products;
using System;
using System.Threading.Tasks;

namespace QuanLyKhoBackendapi.Controllers
{
    //"api/product"
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IManageProductService _manageProductService;

        public ProductController(IManageProductService manageProductService)
        {
            _manageProductService = manageProductService;
        }
        [HttpGet("GetExport")]
        public async Task<IActionResult> GetExportProducts()
        {
            var products = await _manageProductService.GetAllExport();
            return Ok(products);
        }
        [HttpGet("GetImport")]
        public async Task<IActionResult> GetImportProducts()
        {
            var products = await _manageProductService.GetAllImport();
            return Ok(products);
        }
        [HttpGet ("{id}")]
        public async Task<IActionResult> GetImportProductsByID(string id)
        {
            var products = await _manageProductService.GetImportByID(id);

            if (products == null)
                BadRequest("Cannot find product");
            return Ok(products);
        }

        [HttpGet("getimport/{id}")]
        public async Task<IActionResult> BindingsImportByID(string id)
        {
            var products = await _manageProductService.GetImportByID(id);
            
            if (products == null)
                BadRequest("Cannot find product");
            return Ok(products);
        }
        [HttpGet("getim/{id}")]
        public async Task<IActionResult> BindingsImport(string id)
        {
            var products = await _manageProductService.GetByIdim(id);

            if (products == null)
                BadRequest("Cannot find product");
            return Ok(products);
        }
        [HttpPost("ExportProduct")]
        public async Task<IActionResult> CreateEX(ProductCreateExRequest request)
        {
            var total =  _manageProductService.GetTotal(request.importID);
            var CreateProduct = await _manageProductService.CreateEx(request, total);
            if (!CreateProduct.IsSuccessed)
            {
                return BadRequest(request);
            }
            return Ok(CreateProduct);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var DelProduct = await _manageProductService.Delete(id);
            return Ok(DelProduct);
            
        }
        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageProductPagingRequest request)
        {
            var products = await _manageProductService.GetAllPaging(request);
            return Ok(products);
        }
        [HttpGet]
        public IActionResult ImportProduct()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ImportProduct([FromBody] ProductCreateRequest request)
        {
            var CreateProduct = await _manageProductService.Create(request);
            if (!CreateProduct.IsSuccessed)
            {
                return BadRequest(request);
            }
            return Ok(CreateProduct);
        }
        [HttpGet("report/{username}")]
        public async Task<IActionResult> Report(string username)
        {
            var DelProduct = await _manageProductService.Report(username);
            return Ok(DelProduct);

        }
        [HttpGet("sum")]
        public async Task<IActionResult> Sumtotal()
        {
            var DelProduct = await _manageProductService.SumToTal();
            return Ok(DelProduct);

        }
        [HttpGet("debtotal")]
        public async Task<IActionResult> debttotal()
        {
            var DelProduct = await _manageProductService.Sumdebt();
            return Ok(DelProduct);

        }
        [HttpGet("deleteexport")]
        public async Task<IActionResult> deleteexport()
        {
            var DelProduct = await _manageProductService.SetFalse();
            return Ok(DelProduct);

        }
        [HttpPost("Update/{ID}")]
        public async Task<IActionResult> Update(string ID, [FromBody] ProductEditRequest request)
        {
            var DelProduct = await _manageProductService.Update(ID, request);
            return Ok(DelProduct);

        }
    }
}
