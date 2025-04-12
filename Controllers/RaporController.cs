using Microsoft.AspNetCore.Mvc;

namespace ZimmetGo.Controllers
{
    public class RaporController : Controller
    {
        public IActionResult RaporListesi()
        {
            return View();
        }
    }
} 