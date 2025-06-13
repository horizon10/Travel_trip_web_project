using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TravelTripMVCProject.Models.Classes;

namespace TravelTripWebProject.Controllers
{
    public class DefaultController : Controller
    {
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.ID == 2)
                .ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.Take(10)
                .ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = c.Blogs.Take(3)
                .ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).
                Take(3).ToList();
            return PartialView(degerler);
        }

    }
}
