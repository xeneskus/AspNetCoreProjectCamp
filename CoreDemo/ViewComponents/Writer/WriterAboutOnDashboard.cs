using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());



        Context c = new Context(); 
        public  IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            ViewBag.veri = userName;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == userName).Select(y => y.WriterID).FirstOrDefault();
            var values = writerManager.GetWriterById(writerID);
            return View(values);
        }

    }
}
