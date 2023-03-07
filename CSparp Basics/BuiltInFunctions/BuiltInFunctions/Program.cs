// See https://ak .ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string word = "adana";
int index = word.IndexOf('i', 2);
int startIndex = 0;
while (word.IndexOf('a', startIndex) != -1)
{
    int findingIndex = word.IndexOf('a', startIndex);
    Console.WriteLine($" a harfinin indexi = {findingIndex} ");
    startIndex = findingIndex + 1;

}

//Console.WriteLine(index);
string.IsNullOrEmpty(null);

int x = 5;
int? y = null;

