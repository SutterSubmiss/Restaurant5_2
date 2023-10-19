using Microsoft.AspNetCore.Mvc;

namespace Restaurant5.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
