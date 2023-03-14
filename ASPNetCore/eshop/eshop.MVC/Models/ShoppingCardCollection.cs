using eshop.Entities;

namespace eshop.MVC.Models
{
    public class ProductInCard
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    //Bu koleksiyonu; Session'da tutacaksınız!
    public class ShoppingCardCollection
    {
        public List<ProductInCard> Products { get; set; } = new List<ProductInCard>();

        public void AddProduct(Product product, int quantity = 1)
        {
            var existingProduct = Products.FirstOrDefault(p => p.Product.Id == product.Id);

            if (existingProduct != null)
            {
                existingProduct.Quantity += quantity;
            }
            else
            {
                Products.Add(new ProductInCard { Product = product, Quantity = quantity });
            }



        }

        public void Clear() => Products.Clear();
        public double GetTotalPrice() => Products.Sum(p => p.Quantity * (double)p.Product.Price);
        public void RemoveProductInCard(int id) => Products.RemoveAll(p => p.Product.Id == id);
    }
}
