using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant5.Web.Controllers
{
    public class OpinionController : Controller
    {
        [Authorize]
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
