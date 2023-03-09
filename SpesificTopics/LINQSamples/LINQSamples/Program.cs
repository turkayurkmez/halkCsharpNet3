// See https://aka.ms/new-console-template for more information
using LINQSamples;

Console.WriteLine("Hello, World!");

List<Product> products = new()
{
    new(){ Id=1, Name="Telefon A ", Description="Android", Rating=4.2, IsStock=true, Price=2000 },
    new(){ Id=2, Name="Telefon W ", Description="IOS", Rating=4.2, IsStock=true, Price=5000 },
    new(){ Id=3, Name="Telefon Q ", Description="Android", Rating=4.2, IsStock=true, Price = 7500 },
    new(){ Id=4, Name="Telefon P ", Description="Android", Rating=4.2, IsStock=true, Price = 5500 },
    new(){ Id=5, Name="Giyim Y ", Description="Giyim", Rating=4.2, IsStock=true, Price=3000 },
    new(){ Id=6, Name="Elektronik X ", Description="Ses sistemi", Rating=4.2, IsStock=true, Price = 500 },

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




Console.WriteLine();
