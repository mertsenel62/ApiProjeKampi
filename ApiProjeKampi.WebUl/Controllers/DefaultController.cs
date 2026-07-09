using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
