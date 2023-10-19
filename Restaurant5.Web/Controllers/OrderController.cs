using Microsoft.AspNetCore.Mvc;

namespace Restaurant5.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
