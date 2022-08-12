using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyKhoData.EF;
using QuanLyKhoData.Entities;
using QuanLyKhoApplication.Catalog.Products;
using QuanLyKhoViewModels.Common;
using QuanLyKhoViewModels.Catalog.Products;
using QuanLyKhoViewModels.System.Products;
using QuanLyKhoViewModels.Catalog.Exporduct;

namespace QuanLyKhoAppLication.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly QuanLyKhoDbContext _dbcontext;
        public ManageProductService(QuanLyKhoDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<ApiResult<bool>> CreateEx(ProductCreateExRequest request, int total)
        {
            ExportProduct products = null;
            Debt debt = null;
            var guest = await _dbcontext.guests.FindAsync(request.GuestID);
            var productsExID = await _dbcontext.Exproducts.Where(x =>x.importID.Equals(request.importID)).Where(x =>x.status.Equals(true)).FirstOrDefaultAsync();
            var no = request.StatusDebt.Equals("false") ? request.SalesPrice : 0;
            if (guest != null)
            {
                if (request.Quantity <= total)
                {
                    if (total > 0)
                    {
                        var productim = await _dbcontext.Improducts.FindAsync(request.importID);
                        var productupdate = await _dbcontext.Improducts.FirstOrDefaultAsync(x => x.Id.Equals(request.importID));
                        productupdate.Quantity = total - request.Quantity;
                    }
                    else
                    {
                        var productim = _dbcontext.Improducts.FindAsync(request.importID);
                        var productupdate = await _dbcontext.Improducts.FirstOrDefaultAsync(x => x.Id.Equals(request.importID));
                        productupdate.Quantity = 0;

                    }
                    if (productsExID != null)
                    {
                        productsExID.Quantity += request.Quantity;
                        productsExID.weight += request.Quantity * request.ToTalSum;
                        productsExID.debttotal += request.debttotal;
                    }
                  
                    else if(productsExID == null)
                    {
                        products = new ExportProduct()
                        {
                            importID = request.importID,
                            Quantity = request.Quantity,
                            SalesPrice = request.SalesPrice,
                            ToTalSum = request.ToTalSum,
                            ExDate = request.ExDate,
                            debttotal = no,
                            GuestID = request.GuestID,
                            weight = request.ToTalSum * request.Quantity,
                            status = true
                        };
                        var expro = await _dbcontext.Exproducts.AddAsync(products);
                    }
                    if (request.StatusDebt.Equals("false"))
                    {
                        debt = new Debt()
                        {
                            GuestID = request.GuestID,
                            ProductID = request.importID,
                            CreateDateDebt = request.ExDate,
                            TotalDebt = request.SalesPrice
                        };
                        var adddebt = await _dbcontext.debts.AddAsync(debt);
                        if (adddebt != null)
                        {
                            await _dbcontext.SaveChangesAsync();
                            return new ApiSuccessResult<bool>();
                        }
                    }
                    else if (request.StatusDebt.Equals("true") && productsExID != null)
                    {
                        await _dbcontext.SaveChangesAsync();
                        return new ApiSuccessResult<bool>();
                    }
                    else if (request.StatusDebt.Equals("true") && productsExID == null)
                    {
                        var ExproAnDebt = await _dbcontext.Exproducts.AddAsync(products);

                        if (ExproAnDebt != null)
                        {
                            await _dbcontext.SaveChangesAsync();
                            return new ApiSuccessResult<bool>();
                        }
                    }
                }
                else
                {
                    return new ApiErrorResult<bool>("Số lượng trong kho không đủ");

                }
            }
            else
            {
                return new ApiErrorResult<bool>("Mã khách hàng không tồn tại");
            } 
                
            return new ApiErrorResult<bool>("Bán sản phẩm không thành công");
        }
        public async Task<ApiResult<bool>> Delete(string idProduct)
        {
            var product = await _dbcontext.Improducts.FindAsync(idProduct);

            if (product == null)
            {
                return new ApiErrorResult<bool>("Sản phẩm không tồn tại");
            }
            var reult = _dbcontext.Improducts.Remove(product);

            if (reult != null)
            {
               await _dbcontext.SaveChangesAsync();
                return new ApiSuccessResult<bool>();

            }

            return new ApiErrorResult<bool>("Xóa không thành công");
        }

        public int GetTotal(string idProduct)
        {
            var Total = (from s in _dbcontext.Improducts
                        where s.Id.Equals(idProduct)
                        select s.Quantity).FirstOrDefault();
            return Total;
        }

        public async Task<ApiResult<bool>> Update(string ID,ProductEditRequest request)
        {
            var productim = await _dbcontext.Improducts.FindAsync(ID);
            if (productim != null)
            {
                productim.Name = request.Name;
                productim.SalesPrice = request.SalesPrice;
                productim.Quantity = request.Quantity;
                productim.ToTalSum = request.ToTalSum;
                var result = _dbcontext.Improducts.Update(productim);
                if (result != null)
                {
                    await _dbcontext.SaveChangesAsync();
                    return new ApiSuccessResult<bool>();
                }
            }

            return new ApiErrorResult<bool>("Thêm sản phẩm không thành công");
        }

        public int CountEx()
        {
            var count = (from product in _dbcontext.Exproducts
                         where product.status.Equals(false)
                         select product).Count();
            return count;
        }
        public async Task<List<ExportProduct>> GetAllExport()
        {
            var querySearch = from product in _dbcontext.Exproducts
                              where product.status.Equals(false)
                              select product;
            var data = await querySearch.
               Select(x => new ExportProduct()
               {
                   importID = x.importID,
                   SalesPrice = x.SalesPrice,
                   ToTalSum = x.ToTalSum,
                   ExDate = x.ExDate,
                   Quantity = x.Quantity,
                   weight = x.weight,
                   debttotal = x.debttotal,

               }).ToListAsync();
            return data;
        }

        public PagedResult<ProductViewModel> GetAllByCategoryID(GetPublicProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
        public async Task<List<ProductViewModel>> GetAllImport()
        {
            var querySearch = from product in _dbcontext.Improducts
                              join ex in _dbcontext.Exproducts on product.Id equals ex.importID
                              join de in _dbcontext.guests on ex.GuestID equals de.ID
                              select new {product, de};

            var data = await querySearch.
               Select(x => new ProductViewModel()
               {
                   Id = x.product.Id,
                   Name = x.product.Name,
                   Quantity = x.product.Quantity,
                   OriginPrice = x.product.OriginPrice,
                   SalesPrice = x.product.SalesPrice,
                   ToTalSum = x.product.ToTalSum,
                   ImportDate = x.product.ImportDate,
                  
               }).ToListAsync();
            return data;
        }

        public async Task<ApiResult<ProductViewBindingModel>> GetImportByID(string ID)
        {
            var querySearch = await _dbcontext.Improducts.Where(x => x.Id.StartsWith(ID)).FirstOrDefaultAsync();
            var data = new ProductViewBindingModel()
            {
                Name = querySearch.Name,
                importID = querySearch.Id,
                Quantity = querySearch.Quantity,
                SalesPrice = querySearch.SalesPrice,
                origin = querySearch.OriginPrice,
                ToTalSum = querySearch.ToTalSum,
                ImportDate = querySearch.ImportDate,
                
            };

            return new ApiSuccessResult<ProductViewBindingModel>(data);
        }

        public async Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request)
        {
            var querySearch = from product in _dbcontext.Improducts
                              select new { product };
            if (!string.IsNullOrEmpty(request.Keyword))
                querySearch = querySearch.Where(x => x.product.Id.Contains(request.Keyword));
            int totalRow = await querySearch.CountAsync();
            var data = await querySearch.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).
                Select(x => new ProductVm()
                {
                    Id = x.product.Id,
                    Quantity = x.product.Quantity,
                    SalesPrice = x.product.SalesPrice,
                    OriginPrice =x.product.OriginPrice,
                    ToTalSum = x.product.ToTalSum,
                    ImportDate = x.product.ImportDate,
                    Name = x.product.Name
                }).ToListAsync();
            var pageResult = new PagedResult<ProductVm>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pageResult;
        }

        public async Task<ApiResult<bool>> Create(ProductCreateRequest request)
        {
            var productim = await _dbcontext.Improducts.FindAsync(request.Id);
            if (productim == null)
            {
                var products = new ImportProduct()
                {
                    Id = request.Id,
                    Name = request.Name,
                    Quantity = request.Quantity,
                    OriginPrice = request.OriginPrice,
                    SalesPrice = request.SalesPrice,
                    ToTalSum = request.ToTalSum,
                    ImportDate = request.ImportDate
                };
                var result = await _dbcontext.Improducts.AddAsync(products);
                if (result != null)
                {
                    await _dbcontext.SaveChangesAsync();
                    return new ApiSuccessResult<bool>();
                }
            }
            return new ApiErrorResult<bool>("Thêm sản phẩm không thành công");
        }
        public async Task<PagedResult<ProductViewDetalModel>> Report(string username)
        {
            var querySearch = from debt in _dbcontext.Exproducts
                              from em in _dbcontext.appusers
                              join pro in _dbcontext.Improducts on debt.importID equals pro.Id
                              join guest in _dbcontext.guests on debt.GuestID equals guest.ID
                              where em.UserName.Equals(username)
                              where debt.status.Equals(true)
                              select new { debt, pro,guest,em};
            var data = await querySearch.Distinct().
                 Select(x => new ProductViewDetalModel()
                 {
                     EmL = x.em.LastName,
                     EmF = x.em.FirstName,
                     FirtName = x.guest.FirtName,
                     LastName = x.guest.LastName,
                     PhoneNumber = x.guest.PhoneNumber,
                     importID = x.debt.importID,
                     Name = x.pro.Name,
                     GuestID = x.debt.GuestID,
                     ExDate = x.debt.ExDate,
                     Quantity = x.debt.Quantity,
                     SalesPrice = x.debt.SalesPrice,
                     debttotal = x.debt.debttotal,
                     weight = x.debt.weight,
                     ToTalSum = x.debt.ToTalSum
                 }).ToListAsync();
            int totalRow = await querySearch.CountAsync();
            var pageResult = new PagedResult<ProductViewDetalModel>()
            {
                TotalRecords = totalRow,
                PageSize = 2,
                PageIndex = 1,
                Items = data
            };
            return pageResult;
        }

        public async Task<decimal> SumToTal()
        {
            var querySearch = from debt in _dbcontext.Exproducts
                              join pro in _dbcontext.Improducts on debt.importID equals pro.Id
                              join guest in _dbcontext.guests on debt.GuestID equals guest.ID
                              where debt.status.Equals(true)
                              select new { debt, pro, guest };
            var totalRow = await querySearch.SumAsync(x => x.debt.SalesPrice);
            return totalRow;
        }
        public async Task<decimal> Sumdebt(bool check)
        {
            var querySearch = from debt in _dbcontext.Exproducts
                              join pro in _dbcontext.Improducts on debt.importID equals pro.Id
                              join guest in _dbcontext.guests on debt.GuestID equals guest.ID
                              where debt.status.Equals(check) 
                              select new { debt, pro, guest };
            var totalRow = await querySearch.SumAsync(x => x.debt.debttotal);
            return totalRow;
        }
        [Obsolete]
        public async Task<int> SetFalse()
        {
            var result = _dbcontext.Database.ExecuteSqlCommand("update exportproduct set status = 0 where status = 1");

            if (result > 0)
            {
                await _dbcontext.SaveChangesAsync();
                return 1;
            }
            return -1;
        }

        public async Task<ApiResult<ProductEditRequest>> GetByIdim(string id)
        {
            var querySearch = await _dbcontext.Improducts.Where(x => x.Id.StartsWith(id)).FirstOrDefaultAsync();
            var data = new ProductEditRequest()
            {
                Name = querySearch.Name,
                Quantity = querySearch.Quantity,
                SalesPrice = querySearch.SalesPrice,
                ToTalSum = querySearch.ToTalSum,
            };

            return new ApiSuccessResult<ProductEditRequest>(data);
        }
    }
}
