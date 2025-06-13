using System.Linq;
using System.Web.Mvc;
using TravelTripMVCProject.Models.Classes;

namespace TravelTripWebProject.Controllers
{
    public class BlogController : Controller
    {
        Context c=new Context();
        BlogComment by=new BlogComment();
        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3);
            //var bloglar = _context.Blogs.ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Comments.Where(x => x.Blogid == id).ToList();
            //var blogbul = _context.Blogs.Where(x => x.ID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Comments y)
        {
            c.Comments.Add(y);
            c.SaveChanges();
            return PartialView();
        }

    }
}

    

