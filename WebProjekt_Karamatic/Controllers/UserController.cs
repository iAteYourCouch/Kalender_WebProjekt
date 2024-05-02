using Microsoft.AspNetCore.Mvc;

namespace WebProjekt_Karamatic.Controllers {
    public class UserController : Controller {
        public IActionResult Profile() {
            // Hier wird die Logik für die Anzeige/Bearbeitung des Profils implementiert
            return View();
        }

        public IActionResult Settings() {
            // Hier wird die Logik für die Einstellungen implementiert
            return View();
        }

        public IActionResult Logout() {
            // Hier wird die Logik für die Abmeldung implementiert
            return RedirectToAction("Home"); // Beispiel: Startseite nach Abmeldung anzeigen
        }
    }
}