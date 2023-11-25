using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        [Area("Admin")] //areadan geldiğini bildirdik
        public IActionResult Index()
        {
            return View();
        }
    }
}
