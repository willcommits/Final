using Microsoft.AspNetCore.Mvc;

namespace Co_Mute.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     

        public ActionResult setLogins(String email, String password)
        {
            return Content(email,password);
        }
    }
}
