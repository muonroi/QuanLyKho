using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhoAppLication.Catalog.Debts;
using QuanLyKhoAppLication.Catalog.Products;
using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.System.Debt;
using QuanLyKhoViewModels.System.Products;
using System.Threading.Tasks;

namespace QuanLyKhoBackendapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DebtController : Controller
    {
        private readonly IPublicManageDebts _publicManageDebts;

        public DebtController(IPublicManageDebts publicManageDebts)
        {
            _publicManageDebts = publicManageDebts;
        }
        [HttpGet("detail/{ID}")]
        public async Task<IActionResult> GetDebByIdGuest(string ID, [FromQuery] GetManageDebtPagingRequest request)
        {
            var debt  = await _publicManageDebts.GetDebtByGuestID(request,ID);
            return Ok(debt);
        }
        [HttpGet("paging")]
        public async Task<IActionResult> GetallDebts([FromQuery] GetManageDebtPagingRequest request)
        {
            var debt = await _publicManageDebts.GetAllDebt(request);
            return Ok(debt);
        }
        [HttpGet("pagingss")]
        public async Task<IActionResult> GetallDebt([FromQuery] GetManageDebtPagingRequest request)
        {
            var debt = await _publicManageDebts.GetImportDebt(request);
            return Ok(debt);
        }
        [HttpGet("pagings")]
        public async Task<IActionResult> GetallDebtHis([FromQuery] GetManageDebtPagingRequest request)
        {
            var debt = await _publicManageDebts.GetAllDebtHis(request);
            return Ok(debt);
        }
        [HttpGet("pagings/{Id}")]
        public async Task<IActionResult> GetallDebtHisById([FromQuery] GetManageDebtPagingRequest request,string Id)
        {
            var debt = await _publicManageDebts.GetAllDebtHisById(request,Id);
            return Ok(debt);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var DelProduct = await _publicManageDebts.Delete(id);
            return Ok(DelProduct);

        }
        [HttpDelete("deleteall/{id}")]
        public async Task<IActionResult> DeleteAll(string id)
        {
            var DelProduct = await _publicManageDebts.DeleteALL(id);
            return Ok(DelProduct);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateImport([FromBody] DebtCreateRequest request)
        {
            var CreateProduct = await _publicManageDebts.CreateDebtImport(request);
            return Ok(CreateProduct);
        }
    }
}
