using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
