using Microsoft.AspNetCore.Mvc;

namespace ViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            // Views/Home/Index.cshtml
            return View();
            // abc.cshtml
            // return View("abc");
            // return new ViewResult() { ViewName = "abc" };
        }
    }
}
