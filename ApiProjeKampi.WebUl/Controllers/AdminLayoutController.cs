using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
