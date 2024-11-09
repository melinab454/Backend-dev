using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class Blog2Controller : Controller
    {
        // GET: Blog2Controller
        public ActionResult Index()
        {
             List<Blog> blog = [
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
                 new Blog { Baslik =" İlk Resim" ,Ozet =" Özet", GorselUrl="https://picsum.photos/200/300?grayscale"},
             ];

            return View(blog);
        }

    }
}
