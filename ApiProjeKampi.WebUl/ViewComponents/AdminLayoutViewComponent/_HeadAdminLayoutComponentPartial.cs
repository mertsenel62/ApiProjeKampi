using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.ViewComponents.AdminLayoutWiewComponent
{
    public class _HeadAdminLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
