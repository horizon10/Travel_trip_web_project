using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripMVCProject.Models.Classes;

namespace TravelTripMVCProject.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult OneriYap()
        {
            return PartialView();
        }


        [HttpPost]
public ActionResult OneriYap(Oneri y)
{
    if (ModelState.IsValid)
    {
        // Burada veritabanına kayıt vs. işlemlerini yap
        c.Oneris.Add(y);
        c.SaveChanges();

        // Başarılı işlem sonrası tekrar Index'e yönlendir:
        return RedirectToAction("Index");
    }

    // Hata varsa aynı sayfaya geri dön, form dolu şekilde kalsın
    return View("Index", y);
}

    }
}
