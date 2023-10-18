using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant5.Web.Controllers
{
    [Authorize]
    public class Menu : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
