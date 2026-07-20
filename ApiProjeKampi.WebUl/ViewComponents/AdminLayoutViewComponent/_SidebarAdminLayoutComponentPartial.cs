using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.ViewComponents.AdminLayoutViewComponent
{
    public class _SidebarAdminLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
