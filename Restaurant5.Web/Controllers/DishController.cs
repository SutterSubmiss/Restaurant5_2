using Microsoft.AspNetCore.Mvc;
using Restaurant5.Web.Models;

namespace Restaurant5.Web.Controllers
{
    public class DishController : Controller
    {
        public IActionResult Index()
        {
       
            return View();
        }
    }
}
