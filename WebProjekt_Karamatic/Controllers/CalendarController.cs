using Microsoft.AspNetCore.Mvc;

namespace WebProjekt_Karamatic.Controllers {
    public class CalendarController : Controller {
        public IActionResult Month() {
            // Hier wird die Logik für die Monatsansicht implementiert
            return View();
        }

        public IActionResult Week() {
            // Hier wird die Logik für die Wochenansicht implementiert
            return View();
        }

        public IActionResult Day() {
            // Hier wird die Logik für die Tagesansicht implementiert
            return View();
        }
    }
}