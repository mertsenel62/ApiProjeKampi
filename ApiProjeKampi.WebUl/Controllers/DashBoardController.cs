using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
