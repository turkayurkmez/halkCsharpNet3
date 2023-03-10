// See https://aka.ms/new-console-template for more information
using LINQSamples;

Console.WriteLine("Hello, World!");


Category phone = new Category { Id = 1, Name = "Phone" };
Category wearing = new Category { Id = 2, Name = "Wearing" };
Category electronic = new Category { Id = 2, Name = "Electronic" };

List<Category> categories = new() { phone, wearing, electronic };

List<Product> products = new()
{
    new(){ Id=1, Name="Telefon A ", Description="Android", Rating=4.2, IsStock=true, Price=2000, Category=phone },
    new(){ Id=2, Name="Telefon W ", Description="IOS", Rating=4.5, IsStock=true, Price=5000, Category = phone },
    new(){ Id=3, Name="Telefon Q ", Description="Android", Rating=3.0, IsStock=true, Price = 7500, Category = phone },
    new(){ Id=4, Name="Telefon P ", Description="Android", Rating=3.6, IsStock=true, Price = 5500, Category=phone },
    new(){ Id=5, Name="Giyim Y ", Description="Giyim", Rating=4.8, IsStock=true, Price=3000, Category = wearing },
    new(){ Id=6, Name="Elektronik X ", Description="Ses sistemi", Rating=4.2, IsStock=true, Price = 500, Category=electronic },

};

//
//List<Product> result = new List<Product>();
//foreach (var item in products)
//{

//    if (item.Price< 5000)
//    {
//        result.Add(item);
//    }
//}

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


var result = from product in products
             where product.Price < 5000
             select product;

var result2 = products.Where(product => product.Price < 5000)
                      .ToList();
Console.WriteLine("5000'den az ürünler");
Console.WriteLine("-------------------------------------------");
result2.ForEach(r => Console.WriteLine($"{r.Name} - {r.Price}"));

//var product5 = products.SingleOrDefault(p => p.Description == "Android");
var product5 = products.FirstOrDefault(p => p.Description == "Android");

Console.WriteLine($"Açıklaması Android olan ilk ürün: {product5.Name}");


Console.WriteLine("Adında 'Telefon' kelimesi geçen ürünler");
Console.WriteLine("-------------------------------------------");
var phoneProducts = products.Where(p => p.Name.Contains("Telefon")).ToList();
phoneProducts.ForEach(p => Console.WriteLine(p.Name + " " + p.Description));

Console.WriteLine("Tüm ürünleri fiyata göre sırala");
Console.WriteLine("----------------------------------------");
products.OrderBy(p => p.Price)
        .ToList()
        .ForEach(p => Console.WriteLine($"{p.Name} {p.Price}"));

Console.WriteLine("Tüm ürünleri fiyata göre pahalıdan ucuza sırala");
Console.WriteLine("----------------------------------------");

products.OrderByDescending(p => p.Description)
        .ThenBy(p => p.Price)
        .ToList()
        .ForEach(p => Console.WriteLine($"{p.Description} {p.Name} {p.Price}"));


var totalPrice = products.Sum(p => p.Price);
var max = products.Max(p => p.Price);
var avg = products.Average(p => p.Price);

/*
 *  Products
 *  Id     Name      CategoryId  <----- FK
 *  ------------------------------------
 *  1      TV         1
 *  
 *  
 *  Categories
 *  Id     Name
 *  ------------------------------------
 *  1.    Elektronik
 *  2.    Giyim
 */

Console.WriteLine();
//Ürün adı, fiyatı ve kategori adı
var joinQuery = categories.Join(products,
                                category => category,
                                product => product.Category,
                                (category, product) => new { KategoriAdi = category.Name, UrunAdi = product.Name })
                          .ToList();

foreach (var item in joinQuery)
{
    Console.WriteLine($"{item.UrunAdi} {item.KategoriAdi}");
}

var alternativeJoin = products.Select(pr => new { ProductName = pr.Name, CategoryName = pr.Category.Name }).ToList();

Console.WriteLine("--------------- Alternatif ----------------------");
foreach (var item in alternativeJoin)
{
    Console.WriteLine($"{item.ProductName} {item.CategoryName}");
}

/*
 * Key                 Count     Total     Average  
 * ------------------------------------------------------
 * Android              3
 * Ios                  1
 * Giyim                1 
 * Ses Sistemi          1
 */

//var androidCount = products.Where(p => p.Description.StartsWith("Android")).Count();

var groupBy = products.GroupBy(p => p.Description,
                               result => new { result.Name, result.Price },
                               (desc, products) => new
                               {
                                   Key = desc,
                                   Count = products.Count(),
                                   Total = products.Sum(x => x.Price),
                                   Average = products.Average(x => x.Price)

                               }
                              );
Console.WriteLine(" Key                 Count     Total     Average  ");
Console.WriteLine("--------------------------------------------------");
foreach (var item in groupBy)
{
    Console.WriteLine($"{item.Key}              {item.Count}   {item.Total}    {item.Average}");
}

