using QuanLyKhoApplication.Catalog.Products;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.System.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoAppLication.Catalog.Products
{
    public interface IManageProductService
    {
        Task<ApiResult<bool>> Create(ProductCreateRequest request);
        Task<bool> Update(ProductEditRequest request);
        Task<bool> UpdatePrice(int productID, decimal price);
        Task<ApiResult<bool>> Delete(string idProduct);
        int GetTotal(string idProduct);
        public Task<ApiResult<bool>> CreateEx(ProductCreateExRequest request, int total);
        Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request);
        PagedResult<ProductViewModel> GetAllByCategoryID(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAllExport();
        Task<List<ProductViewModel>> GetAllImport();
        Task<ApiResult<ProductViewBindingModel>> GetImportByID(string ID);
        Task<PagedResult<ProductViewDetalModel>> Report();
        Task<decimal> SumToTal();
        Task<decimal> Sumdebt();
    }
}
