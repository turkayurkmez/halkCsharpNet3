// See https://aka.ms/new-console-template for more information
using Delegations;

Console.WriteLine("Hello, World!");


List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var list = FilterHelper.Filter(numbers, isEven);
var odds = FilterHelper.Filter(numbers, delegate (int n) { return n % 2 == 1; });
var bigThanEight = FilterHelper.Filter(numbers, n => n >= 8);
var result = numbers.Where(n => n % 3 == 0).ToList();





//showNumbers(odds);
alternativeShow(result);

void showNumbers(List<int> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

void alternativeShow(List<int> list)
{
    list.ForEach(x => Console.WriteLine(x));
}

bool isEven(int item)
{
    return item % 2 == 0;
}


