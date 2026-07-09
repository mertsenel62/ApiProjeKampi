using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.ViewComponents
{
    public class _NavbarDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
