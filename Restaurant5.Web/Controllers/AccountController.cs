using Microsoft.AspNetCore.Mvc;

namespace Restaurant5.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
