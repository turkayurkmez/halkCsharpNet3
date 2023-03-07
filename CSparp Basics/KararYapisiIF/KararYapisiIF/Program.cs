// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir sayı girin");
int number = int.Parse(Console.ReadLine());
string message = string.Empty;
if (number % 2 == 0) //|| number <5)
{
    message = "Çift";
}
else
{
    message = "Tek";
}

string ternaryMessage = number % 2 == 0 ? "Çift" : "Tek";


Console.WriteLine(ternaryMessage);
