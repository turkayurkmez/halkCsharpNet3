// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir şekil seçin (1. Kare, 2. Daire ya da 3. üçgen)");

Geometry selected = (Geometry)Convert.ToInt32(Console.ReadLine());

switch (selected)
{
    case Geometry.Square:
        Console.WriteLine("a kare...");
        break;
    case Geometry.Circle:
        Console.WriteLine("pi x r kare");
        break;
    case Geometry.Triangle:
        Console.WriteLine("(a x h) /2 ");
        break;
    default:
        break;
}

ErkekAkrabalikTipleri turkay = ErkekAkrabalikTipleri.Ogul | ErkekAkrabalikTipleri.Abi;
Console.WriteLine($"Türkay'ın akrabalık değeri: {turkay}");

//string geometry = Console.ReadLine();

//if (geometry == "Kare")
//{
//    Console.WriteLine("kare seçildi");
//}
//else if (geometry == "Daire")
//{
//    Console.WriteLine("daire seçildi");

//}
//else if (geometry == "Üçgen")
//{
//    Console.WriteLine("üçgen seçildi");

//}
//else
//{
//    Console.WriteLine("Yanlış seçim!");
//}

//switch (geometry)
//{
//    case "Kare":
//        Console.WriteLine("a kare...");
//        break;
//    case "Daire":
//        Console.WriteLine("pi x r kare");
//        break;
//    case "Üçgen":
//        Console.WriteLine("(a x h) / 2");
//        break;
//    default:
//        Console.WriteLine("Yanlış seçim!");
//        break;
//}

switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Sunday:
        break;
    case DayOfWeek.Monday:
        break;
    case DayOfWeek.Tuesday:
        break;
    case DayOfWeek.Wednesday:
        break;
    case DayOfWeek.Thursday:
        break;
    case DayOfWeek.Friday:
        break;
    case DayOfWeek.Saturday:
        break;
    default:
        break;
}



enum Geometry
{
    Square = 1,
    Circle = 2,
    Triangle = 3

}

enum ErkekAkrabalikTipleri
{
    Abi = 1,
    Ogul = 2,
    Baba = 4,
    Amca = 8,
    Dayı = 16,
    Dede = 32
}