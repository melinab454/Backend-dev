using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            ViewBag.YurtDısı = "Yurt Dışı Gezilerim";
            ViewBag.Yurtici = "Yurt İçi Gezilerim";
            ViewBag.UzaySeyahetim = "Uzay Seyahetim";
            return View();
        }

    }
}
