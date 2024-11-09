using System.ComponentModel;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {
            About about = new About()
            {
                FullName = "Melina BALCI",
                OnSoz = "Merhabalar , Sizi Kendimi Tanıtmak İstiyorum",
                Alan = "Web Develepor",
                TanıtmaMetni = $"Tekradan merhabalar ben Melina BALCI acun medya akademide back-end developer eğitimi alıyorum aynı ",
                tel = "05319669419"

            };



            return View(about);
        }

    }
}
