// See https://aka.ms/new-console-template for more information

var products = new List<Product>()
{
    new Product{ Id=1, Name="TV", Price=5},
    new Product{ Id=2, Name="Monitör", Price =10},
    new Product{ Id=3, Name="Soundbar", Price=15},

};

var result = from product in products
             where product.Price > 10
             select new { Ad = product.Name };

foreach (var item in result)
{
    Console.WriteLine(item.Ad);
}




//object GetProducts()
//{
//    return new[]  {
//    new { Name = "Product X", Price = 8 },
//    new { Name = "Product Y", Price = 18 },
//    new { Name = "Product Z", Price = 28 },
//    new { Name = "Product A", Price = 38 }
//};
//}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}