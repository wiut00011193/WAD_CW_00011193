using Microsoft.AspNetCore.Mvc;

namespace WebApp_00011193.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Employee")]
        public IActionResult Employee()
        {
            return View();
        }

        [Route("Department")]
        public IActionResult Department()
        {
            return View();
        }
    }
}
