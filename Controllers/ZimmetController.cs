using Microsoft.AspNetCore.Mvc;

namespace ZimmetGo.Controllers
{
    public class ZimmetController : Controller
    {
        public IActionResult ZimmetListesi()
        {
            return View();
        }
    }
} 