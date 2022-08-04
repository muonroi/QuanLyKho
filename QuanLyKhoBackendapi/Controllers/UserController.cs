

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhoAppLication.Catalog.Users;
using QuanLyKhoAppLication.System.Users;
using QuanLyKhoViewModels.System.Users;
using System;
using System.Threading.Tasks;

namespace QuanLyKhoBackendapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : Controller
    {
        private readonly IPublicManageUsers _user;
        public UserController(IPublicManageUsers user)
        {
            _user = user;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var resultToken = await _user.Authenticate(request);
            if (string.IsNullOrEmpty(resultToken.ResultObj))
            {
                return BadRequest(resultToken);
            }
            return Ok(resultToken);
        }
        [HttpPost("authenticates")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var resultToken = await _user.Register(request);
            if (!resultToken.ResultObj)
            {
                return BadRequest(resultToken);
            }
            return Ok(resultToken);
        }
        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetUserPagingRequest request)
        {
            var user = await _user.GetUserPaging(request);
            return Ok(user);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _user.GetById(id);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _user.Delete(id);
            return Ok(result);
        }
    }
}
