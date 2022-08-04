using QuanLyKhoAppLication.System.Users;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Users;
using System;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request);
        Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest);
        Task<ApiResult<UserVm>> GetById(Guid id);
        Task<ApiResult<bool>> Delete(Guid id);
        //Task<<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request);

        //Task<<bool>> RegisterUser(RegisterRequest registerRequest);

        //Task<<bool>> UpdateUser(Guid id, UserUpdateRequest request);

        //

        //Task<<bool>> Delete(Guid id);

        //Task<<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}
