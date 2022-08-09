using QuanLyKhoAppLication.Catalog.Products;
using QuanLyKhoViewModels.Catalog.Exporduct;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);
        Task<ApiResult<ProductViewBindingModel>> GetById(string id);
        Task<ApiResult<bool>>CreateProduct(ProductCreateRequest request);
        Task<ApiResult<bool>> DeleteProduct (string request);
        Task<ApiResult<ProductCreateExRequest>> GetByIdEx(string id);
        Task<ApiResult<ProductEditRequest>> GetByIdim(string id);
        Task<ApiResult<bool>> CreateEXProduct(ProductCreateExRequest request);
        Task<ProductVm> GetById(int id, string languageId);
        Task<PagedResult<ProductViewDetalModel>> Report(string username);
        Task<decimal> SumToTal();
        Task<decimal> Sumdebt();
        Task<int> SetFalse();
        Task<ApiResult<bool>> Update(string ID, ProductEditRequest request);

        // Task<List<ProductVm>> GetFeaturedProducts(string languageId, int take);

        //Task<List<ProductVm>> GetLatestProducts(string languageId, int take);

        //Task<bool> DeleteProduct(int id);
    }
}
