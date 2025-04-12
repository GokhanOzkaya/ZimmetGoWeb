using Microsoft.AspNetCore.Mvc;

namespace ZimmetGo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult KullaniciListesi()
        {
            return View();
        }

        public IActionResult Ayarlar()
        {
            return View();
        }

        public IActionResult Profil()
        {
            return View();
        }
    }
}
