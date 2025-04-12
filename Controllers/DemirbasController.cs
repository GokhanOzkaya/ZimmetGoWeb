using Microsoft.AspNetCore.Mvc;

namespace ZimmetGo.Controllers
{
    public class DemirbasController : Controller
    {
        public IActionResult DemirbasListesi()
        {
            return View();
        }
    }
} 