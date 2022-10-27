using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            /*string html = "<form method ='post' action='/helloworld'>" +
                "<input type='text' name='name' />"+ 
                "<input type='submit' value='Greet Me!' />"
                "</form>";*/
            string html = "<form method='post' action='/helloworld>" +
                "<input type='text' name='name' />" +
                "<select name='language' />" +
                "<option value='english' selected>English</option>"+
                "<option value='french' >French</option></select>"+
                "<input type='submit' value='Greet Me!' />"+
                "</form>";
                
                
            return Content(html, "text/html");
        }

        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]

        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
