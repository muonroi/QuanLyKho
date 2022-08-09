using Microsoft.AspNetCore.Mvc;
using QuanLyKhoAppLication.Catalog.Emp;
using QuanLyKhoViewModels.Catalog.Emp;
using System.Threading.Tasks;

namespace QuanLyKhoBackendapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmpManage _publicManageEmps;

        public EmployeeController(IEmpManage publicManageEmps)
        {
            _publicManageEmps = publicManageEmps;
        }
        [HttpGet("paging")]
        public async Task<IActionResult> GetallEmp([FromQuery] GetManageEmpPagingRequest request)
        {
            var debt = await _publicManageEmps.GetAllEmp(request);
            return Ok(debt);
        }
    }
}
