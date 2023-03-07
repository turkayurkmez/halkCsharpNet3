// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. Eleman sayısıni biliyoruz ama değerlerini bilmiyoruz:
string[] words = new string[5];
Console.WriteLine("5 kelime giriniz");
int index = 0;
words[index++] = Console.ReadLine();
words[index++] = Console.ReadLine();
words[index++] = Console.ReadLine();

//2. Yöntem: Hem eleman sayısı hem de elemanların değerleri:
//  0          1       2       3 
string[] seasons = new string[] { "İlkbahar", "Yaz", "Sonbahar", "Kış" };

Console.WriteLine(seasons[seasons.Length - 1]);

/*
 * Hedef: 
 * Kullanıcının girdiği 2 basamaklı bir sayıyı okunuşuna çevirmek istiyoruz
 * 42 : "Kırk iki"
 * 96 : "Doksan altı"
 */

//Console.WriteLine("iki basamaklı bir sayı girin..");
Console.WriteLine("Bir tuşa basınız");
Console.ReadLine();
//for (int i = 0; i < 100; i++)
//{
//    int sayi = i;
//    int onlarBasamagindakiDeger = sayi / 10;
//    int birlerBasamağindakiDeger = sayi % 10;
//    string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
//    string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
//    Console.WriteLine($"{onlar[onlarBasamagindakiDeger]} {birler[birlerBasamağindakiDeger]}");
//}

int sonDeger = 0;
while (sonDeger < 100)
{
    int sayi = sonDeger++;
    int onlarBasamagindakiDeger = sayi / 10;
    int birlerBasamağindakiDeger = sayi % 10;
    string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
    string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
    Console.WriteLine($"{onlar[onlarBasamagindakiDeger]} {birler[birlerBasamağindakiDeger]}");
}








