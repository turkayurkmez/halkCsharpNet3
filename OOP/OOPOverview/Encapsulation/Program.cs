// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");
Personel personel = new Personel();
int yas = Convert.ToInt32(Console.ReadLine());
personel.SetYas(yas);
personel.Ad = "Cüneyt";

Console.WriteLine(personel.GetYas());


