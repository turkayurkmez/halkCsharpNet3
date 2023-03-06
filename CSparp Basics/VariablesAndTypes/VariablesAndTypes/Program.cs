// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 *  1. Primitive Types:
 *     - Sayısal
 *       -- Tam sayı
 *       -- Ondalıklı sayı
 *     - Sözel
 *     - Mantıksal
 *  2. Complex Types:
 *      Primitive tipileri bir araya getiren tiplerdir.
 */
//Sayısal:
//8 bitlik: Sadece pozitif
byte mini = 255;
//Signed Byte: eksi olabilen 8 bitlik veri tipi
sbyte minusMini = -12;

//16 - 32 - 64
//short, int, long
//ushort, uint, ulong

byte max = 255;
byte min = 2;
byte test = (byte)(max + min);
Console.WriteLine(test);

//Ondalıklı sayılar:
double pi = 3.14;
float fPi = 3.14f;
decimal dPi = 3.1459021654256521664668865851445666464659465494965165894489M;

char justOneCharacter = '!';
string name = "Türkay!";

string participant1 = "Sena";
String participant2 = "Sena";

Console.WriteLine(participant1);
Console.WriteLine(participant2);

//mantıksal
bool isOk = false;

byte cMax = 255;
byte cMin = 2;
checked
{
    byte cTest = (byte)(cMax + cMin);
}

Console.WriteLine(test);




