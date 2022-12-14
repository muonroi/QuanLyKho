using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QuanLyKhoAppLication.System.Users;
using QuanLyKhoData.Entities;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Users;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Users
{
    public class PublicManageUsers : IPublicManageUsers
    {
        private readonly UserManager<AppUser> _user;
        private readonly SignInManager<AppUser> _sign;
        private readonly IConfiguration _configuration;
        public PublicManageUsers(UserManager<AppUser> user, SignInManager<AppUser> sign,
            IConfiguration configuration)
        {
            _user = user;
            _sign = sign;
            _configuration = configuration;
        }
        public async Task<ApiResult<bool>> Delete(Guid id)
        {
            var user = await _user.FindByIdAsync(id.ToString());

            if (user == null || user.UserName.Equals("muonroi"))
            {
                return new ApiErrorResult<bool>("User không tồn tại");
            }
            var reult = await _user.DeleteAsync(user);
            if (reult.Succeeded)
                return new ApiSuccessResult<bool>();

            return new ApiErrorResult<bool>("Xóa không thành công");
        }
        public async Task<ApiResult<UserVm>> GetById(Guid id)
        {
            var user = await _user.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<UserVm>("User không tồn tại");
            }
            var roles = await _user.GetRolesAsync(user);
            var userVm = new UserVm()
            {
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FirstName = user.FirstName,
                Dob = user.Dob,
                Id = user.Id,
                LastName = user.LastName,
                UserName = user.UserName,

                Roles = roles
            };
            return new ApiSuccessResult<UserVm>(userVm);
        }
        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            var user = await _user.FindByNameAsync(request.UserName);
            if (user == null) return new ApiErrorResult<string>("Tài khoản không tồn tại");

            var result = await _sign.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>("Đăng nhập không thành công");
            }
            var roles = await _user.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name, request.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Tokens:Issuer"],
                _configuration["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
        }

        public async Task<ApiResult<PagedResult<UserVm>>> GetUserPaging(GetUserPagingRequest request)
        {
            var query = _user.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword)
                 || x.PhoneNumber.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new UserVm()
                {
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    UserName = x.UserName,
                    FirstName = x.FirstName,
                    Id = x.Id,
                    LastName = x.LastName
                }).ToListAsync();
            var pagedResult = new PagedResult<UserVm>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            return new ApiSuccessResult<PagedResult<UserVm>>(pagedResult);
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var user = await _user.FindByNameAsync(request.Username);
            if (user != null)
            {
                return new ApiErrorResult<bool>("Tài khoản đã tồn tại");
            }
            if (await _user.FindByEmailAsync(request.Email) != null)
            {
                return new ApiErrorResult<bool>("Emai đã tồn tại");
            }

            user = new AppUser()
            {
                Dob = request.Dob,
                Email = request.Email,
                FirstName = request.FirtName,
                LastName = request.LastName,
                UserName = request.Username,
                PhoneNumber = request.PhoneNumber
            };
            var result = await _user.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Đăng ký không thành công");
        }
    }
}
