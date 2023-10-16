using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
