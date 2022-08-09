using QuanLyKhoAppLication.System.Users;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Users;
using System;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Users
{
    public interface IPublicManageUsers
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<ApiResult<PagedResult<UserVm>>> GetUserPaging(GetUserPagingRequest request);
        Task<ApiResult<UserVm>> GetById(Guid id);
        Task<ApiResult<bool>> Delete(Guid id);
    }
}
