using Microsoft.AspNetCore.Mvc;

namespace PizzaSteve.Controllers
{
    [Route("[controller]")]

    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
