using System.Linq;
using System.Web.Mvc;
using TravelTripMVCProject.Models.Classes;

namespace TravelTripMVCProject.Controllers
{
    public class AboutController : Controller
    {

        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.AboutMes.ToList();
            return View(degerler);
        }
    }
}