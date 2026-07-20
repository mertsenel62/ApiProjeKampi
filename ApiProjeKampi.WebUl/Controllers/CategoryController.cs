using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUl.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryList()
        {
            return View();
        }
    }
}
