// See https://aka.ms/new-console-template for more information

using Serialization;
using System.Text.Json;

Console.WriteLine("Hello, World!");
/*
 * Serialization:
 * Birbiriyle konuşan iki ugulama olsun. A ugulaması Java ile yazılmış ve veri üretmektedir. B uygulaması C# uygulamasıdır ve bu veriyle çalışır. Bu durumda A uygulaması veriyi ORTAK BİR FORMAT'A serialize eder. Ve B uygulaması bu ortak formattan deserialize eder.
 * 
 * 
 */
List<Product> products = new List<Product>()
{
    new Product(){ Id=1, Name="Product A", Description="Desc of Product A"},
    new Product(){ Id=2, Name="Product B", Description="Desc of Product A"},
    new Product(){ Id=3, Name="Product C", Description="Desc of Product A"},
    new Product(){ Id=4, Name="Product D", Description="Desc of Product A"},

};

var result = JsonSerializer.Serialize(products);
//File.WriteAllText("products.json", result.ToString());

var readingJson = File.ReadAllText("products.json");
var products2 = JsonSerializer.Deserialize<List<Product>>(readingJson);


Console.WriteLine("----------------");
products2.ForEach(p => Console.WriteLine(p.Name));


HttpClient httpClient = new HttpClient();
var response = await httpClient.GetStringAsync("https://swapi.dev/api/films/1/");
var movie = JsonSerializer.Deserialize<SWFilm>(response);

Console.WriteLine($"{movie.title} {movie.opening_crawl}");


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

}

