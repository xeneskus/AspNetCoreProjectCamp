using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        [Area("Admin")] //areadan geldiğini bildirdik
        public IActionResult Index()
        {
            var values = categoryManager.GetList();
            return View(values);
        }
    }
}
