using Microsoft.AspNetCore.Mvc;
using ZimmetGo.Data;
using ZimmetGo.Models;
using System.Linq;

namespace ZimmetGo.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly ZimmetDbContext _dbContext;

        public KullaniciController(ZimmetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Edit(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                var existingKullanici = _dbContext.Kullanicilar.Find(kullanici.KullaniciID);
                if (existingKullanici != null)
                {
                    existingKullanici.KullaniciAdi = kullanici.KullaniciAdi;
                    existingKullanici.Adı = kullanici.Adı;
                    existingKullanici.Soyadı = kullanici.Soyadı;
                    existingKullanici.Email = kullanici.Email;
                    existingKullanici.Telefon = kullanici.Telefon;

                    _dbContext.SaveChanges();
                    TempData["Message"] = "Kullanıcı başarıyla güncellendi.";
                }
            }
            return RedirectToAction("KullaniciListesi", "Home");
        }

        [HttpPost]
        public IActionResult Delete(int kullaniciID)
        {
            var kullanici = _dbContext.Kullanicilar.Find(kullaniciID);
            if (kullanici != null)
            {
                _dbContext.Kullanicilar.Remove(kullanici);
                _dbContext.SaveChanges();
                TempData["Message"] = "Kullanıcı başarıyla silindi.";
            }
            return RedirectToAction("KullaniciListesi", "Home");
        }
    }
} 