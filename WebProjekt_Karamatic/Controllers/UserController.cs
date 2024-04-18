using Microsoft.AspNetCore.Mvc;

namespace WebProjekt_Karamatic.Controllers {
    public class UserController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
