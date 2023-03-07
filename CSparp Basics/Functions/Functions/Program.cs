// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Adam asmaca fonksiyonları.
 * 1. Bir kelime listesi içinden rastgele bir kelime seç (örnek: test).
 * 2. Bu kelimeyi **** şeklinde bulmacaya çevir.
 * 3. Bulmacayı ekranda göster.,
 * 4. Kullanıcıdan harf iste
 * 5. Seçilen kelimede harf var mı diye bak.
 * 6. A. Eğer harf varsa, harfin bulunduğu yerdeki *'ları harf ile değiştir (t-> t**t)
 * 6. B. Harf yoksa, "Harf bulunamadı" de ve hakkı azalt.
 * 7. Yeni bir harf tahmini yapıp yapmayacağıno sor; yapacaksa 4. Adıma dön.
 * 8. Kelimeyi tahmin etmesini iste...

 */
var word = selectRandomWord(new List<string> { });
string puzzled = convertToPuzzle(word);
show(puzzled);
string letter = choosingLetter();
if (isWordContainLetter(word, letter))
{
    puzzled = replaceStarWithLetter(word, letter);
    show(puzzled);
}
else
{
    Console.WriteLine("Harf bulunamadı. Hakkınız azaldı!");
}


string answer = "test";
if (comparePuzzleAndAnswer(word, answer))
{
    Console.WriteLine("Bildiniz!");
}



string selectRandomWord(List<string> words)
{
    return "test";
}

string convertToPuzzle(string word)
{
    return "****";
}

void show(string text)
{
    Console.WriteLine(text);
}

string choosingLetter()
{
    return "t";
}

bool isWordContainLetter(string word, string letter)
{
    return true;
}

string replaceStarWithLetter(string word, string letter)
{
    return "t**t";
}

bool comparePuzzleAndAnswer(string word, string answer)
{
    return word == answer;
}

