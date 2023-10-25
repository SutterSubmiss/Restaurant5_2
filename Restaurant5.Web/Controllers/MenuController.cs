using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant5.Web.Models;

namespace Restaurant5.Web.Controllers
{
    
    public class Menu : Controller
    {
        
        public IActionResult Index()
        {

            var model = new Dishes();
            return View(model);
        }
        public IActionResult Index(Dishes model)
        {

            
            return View(model);
        }

    }
}
