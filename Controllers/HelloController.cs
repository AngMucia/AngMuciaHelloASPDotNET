using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    //[Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]

        /*[HttpGet("welcome/{name?}")]*/

        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;
            return View();
            
            
            //return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
