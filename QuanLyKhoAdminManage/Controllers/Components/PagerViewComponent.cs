using Microsoft.AspNetCore.Mvc;
using QuanLyKhoViewModels.Common;
using System.Threading.Tasks;

namespace QuanLyKhoAdminManage.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagingRequestBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
