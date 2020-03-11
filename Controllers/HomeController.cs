using Microsoft.AspNetCore.Mvc;

namespace SampleASPCore.Controllers {
    public class HomeController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult About(){
            return View();
        }
    }
}