using eshop.Application;
using eshop.MVC.Extensions;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.Controllers
{
    public class ShoppingCardController : Controller
    {
        public IActionResult Index()
        {
            var cardCollection = getCollectionFromSession();
            return View(cardCollection);
        }

        private readonly IProductService productService;

        public ShoppingCardController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult AddProduct(int? id)
        {
            if (id == null)
            {
                return BadRequest(new { message = "id değeri verilmek zorunda!" });
            }

            var product = productService.GetProduct(id.Value);

            if (product == null)
            {
                return NotFound(new { message = $"veritabanında {id} id'li değer bulunamadı! " });
            }


            //her seferinde instance almayacak!
            //eğer session daha önce oluşmuş ise (bu daha önce sepete ürün eklendiği anlamına gelir) 
            //O session içindeki instance'i kullanmalı. 
            //Session yok ise o zaman yeni instance almalı.
            ShoppingCardCollection cardCollection = getCollectionFromSession();
            cardCollection.AddProduct(product);
            saveToSession(cardCollection);

            return Json(new { message = $"{id} id'li ürün ajax ile gönderildi" });
        }

        private ShoppingCardCollection getCollectionFromSession()
        {
            //if (HttpContext.Session.GetString("card") == null)
            //{
            //    return new ShoppingCardCollection();
            //}
            //return JsonSerializer.Deserialize<ShoppingCardCollection>(HttpContext.Session.GetString("card"));

            return HttpContext.Session.GetJson<ShoppingCardCollection>("card") ?? new ShoppingCardCollection();
            //return shoppingCard;


        }

        private void saveToSession(ShoppingCardCollection cardCollection)
        {
            //HttpContext.Session.SetString("card", JsonSerializer.Serialize(cardCollection));
            HttpContext.Session.SetJson("card", cardCollection);

        }
    }
}
