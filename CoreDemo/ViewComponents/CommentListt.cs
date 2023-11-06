using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentListt : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
