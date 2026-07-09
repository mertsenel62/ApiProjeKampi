using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.ViewComponents
{
    public class _HeadDafaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
