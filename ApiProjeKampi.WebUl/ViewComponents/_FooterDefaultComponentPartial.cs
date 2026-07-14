using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.ViewComponents
{
    public class _FooterDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
