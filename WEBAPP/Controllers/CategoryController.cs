using Microsoft.AspNetCore.Mvc;

namespace WEBAPP.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
