using Microsoft.AspNetCore.Mvc;

namespace BlogApp
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public ActionResult Index()
        {
            return View();
        }

    }
}
