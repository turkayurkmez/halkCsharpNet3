using eshop.Application;
using eshop.Entities;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            return View();
        }
    }
}
