using introduceToDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace introduceToDotNetCore.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Türkay";
            ViewBag.Hour = DateTime.Now.Hour;

            return View();
        }

        public IActionResult UserResponse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserResponse(User user)
        {
            if (ModelState.IsValid)
            {
                ThanksViewModel thanksViewModel = new ThanksViewModel
                {
                    User = user,
                    Services = new List<Service>()
                    {
                        new() { Name = "Mobil Uygulama Geliştirme" },
                        new() { Name = "Mobil backend geliştirme" },
                        new() { Name = "Oyun Programlama" }
                    }
                };

                return View("Thanks", thanksViewModel);
            }
            return View();
        }
    }
}
