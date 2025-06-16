using System.Linq;
using System.Web.Mvc;
using TravelTripMVCProject.Models.Classes;

namespace TravelTripWebProject.Controllers
{

    public class AdminController : Controller
    {
        Context c =new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler =c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var b1 = c.Blogs.Find(id);
            return View("BlogGetir",b1);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.Tarih = b.Tarih;
            blg.BlogImage = blg.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Comments.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Comments.Find(id);
            c.Comments.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Comments.Find(id);
            return View("YorumGetir",yr);
        }
        public ActionResult YorumGuncelle(Comments y)
        {
            var yrm = c.Comments.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OneriListesi()
        {
            var oneriler = c.Oneris.ToList();
            return View(oneriler);
        }

        public ActionResult OneriSil(int id)
        {
            var oneri = c.Oneris.Find(id);
            c.Oneris.Remove(oneri);
            c.SaveChanges();
            return RedirectToAction("OneriListesi");
        }

        public ActionResult OneriGetir(int id)
        {
            var oneri = c.Oneris.Find(id);
            return View("OneriGetir", oneri);
        }

        public ActionResult OneriGuncelle(Oneri o)
        {
            var onr = c.Oneris.Find(o.ID);
            onr.AdSoyad = o.AdSoyad;
            onr.Mail = o.Mail;
            onr.Konu = o.Konu;
            onr.Mesaj = o.Mesaj;
            c.SaveChanges();
            return RedirectToAction("OneriListesi");
        }

    }
}
