using Microsoft.AspNetCore.Mvc;

namespace WebProjekt_Karamatic.Controllers {
    public class StartController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
