using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhoAppLication.Catalog.Debts;
using QuanLyKhoAppLication.Catalog.Products;
using QuanLyKhoViewModels.Catalog.Debt;
using QuanLyKhoViewModels.Catalog.Products;
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
        public async Task<IActionResult> GetallDebt([FromQuery] GetManageDebtPagingRequest request)
        {
            var debt = await _publicManageDebts.GetAllDebt(request);
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
    }
}
