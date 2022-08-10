using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhoAppLication.Catalog.Guests;
using QuanLyKhoViewModels.Catalog.Guest;
using System.Threading.Tasks;

namespace QuanLyKhoBackendapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestController : Controller
    {
        private readonly IPublicManageGuests _publicManageEmps;

        public GuestController(IPublicManageGuests publicManageEmps)
        {
            _publicManageEmps = publicManageEmps;
        }
        [HttpGet("paging")]
        public async Task<IActionResult> GetallEmp([FromQuery] GetManageGuestPagingRequest request)
        {
            var debt = await _publicManageEmps.GetAllEmp(request);
            return Ok(debt);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var DelProduct = await _publicManageEmps.Delete(id);
            return Ok(DelProduct);

        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ImportProduct([FromBody] GuestCreateRequest request)
        {
            var CreateProduct = await _publicManageEmps.Create(request);
            return Ok(CreateProduct);
        }
    }
}
