using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        //[HttpPost]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer writer)
        {
            Context context = new Context();
            var datavalue = context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (datavalue != null)
            {
                HttpContext.Session.SetString("username", writer.WriterMail);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }

        }

    }
}
