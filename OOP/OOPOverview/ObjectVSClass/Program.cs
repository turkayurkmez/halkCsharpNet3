// See https://aka.ms/new-console-template for more information
using ObjectVSClass;

Console.WriteLine("Hello, World!");

Personel p1 = new Personel
{
    Ad = "Descartes"
};

Personel p2 = p1;

p2.Ad = "John";
p2.Soyad = "Locke";
p2.Maas = 15000;
p2.Yas = 45;

Console.WriteLine(p1.Ad);

