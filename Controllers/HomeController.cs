using Microsoft.AspNetCore.Mvc;

namespace ZimmetGo.Controllers
{        
   
    public class HomeController : Controller
    { [HttpGet]
        public IActionResult Home()
        {
            return View(); // Home sayfasını render et
        }
    }
}