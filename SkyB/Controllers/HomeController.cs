using Microsoft.AspNetCore.Mvc;
using SkyB.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SkyB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]        
        public ActionResult SendStuff(NameValuesModel nameValuesModel)
        {

            if(nameValuesModel == null)
            {
                //oh no! 
            }

            //regex #
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var name = nameValuesModel.Name.ToString() ?? String.Empty;

#pragma warning restore CS8602 // Dereference of a possibly null reference.

            var pattern = "^[a-zA-Z]\\S+$";

            var validCheck = (Regex.Match(name, pattern).Success); 

            if(validCheck)
            {
                //true
                Console.WriteLine("True");
            }
            else
            {
                //false
                Console.WriteLine("False");
                return View();
            } 

            Console.WriteLine(nameValuesModel.Name);
            Console.WriteLine(nameValuesModel.Password);
            Console.WriteLine(nameValuesModel.RetypePassword);
            Console.WriteLine(nameValuesModel.DOB);
            Console.WriteLine(nameValuesModel.Email);
            Console.WriteLine(nameValuesModel.Username); 

            //Do stuff! 
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}