// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");
int number = 8;
Console.WriteLine(number.GetSquare());
/*
 * Order Details
 * OrderDetails
 */
string tableName = "Order Details";
Console.WriteLine(tableName.RemoveMiddleEmpty());

Random random = new Random();

Console.WriteLine(random.NextWord(5));