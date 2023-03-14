using eshop.Application;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public MenuViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetCategories().ToList();
            return View(categories);
        }
    }
}
