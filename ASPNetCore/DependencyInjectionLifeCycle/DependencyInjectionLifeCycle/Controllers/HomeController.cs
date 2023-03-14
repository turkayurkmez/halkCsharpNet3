using DependencyInjectionLifeCycle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionLifeCycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonGuidGenerator singleton;
        private readonly IScopedGuidGenerator scoped;
        private readonly ITransientGuidGenerator transient;
        private readonly GuidService guidService;

        public HomeController(ILogger<HomeController> logger, ISingletonGuidGenerator singleton, IScopedGuidGenerator scoped, ITransientGuidGenerator transient, GuidService guidService)
        {
            _logger = logger;
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
            this.guidService = guidService;
        }

        public IActionResult Index()
        {
            ViewBag.SingleGuid = singleton.Guid.ToString();
            ViewBag.ScopedGuid = scoped.Guid.ToString();
            ViewBag.TransientGuid = transient.Guid.ToString();

            ViewBag.SingleService = guidService.SingletonGuid.Guid.ToString();
            ViewBag.ScopedService = guidService.ScopedGuidGenerator.Guid.ToString();
            ViewBag.TransientService = guidService.TransientGuidGenerator.Guid.ToString();

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