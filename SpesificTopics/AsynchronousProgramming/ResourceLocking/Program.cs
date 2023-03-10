// See https://aka.ms/new-console-template for more information
using ResourceLocking;


CustomResource customResource = new CustomResource();
Thread t1 = new Thread(() => customResource.writeNumbersToConsole());
Thread t2 = new Thread(() => customResource.writeNumbersToConsole());
Thread t3 = new Thread(() => customResource.writeNumbersToConsole());
Thread t4 = new Thread(() => customResource.writeNumbersToConsole());

Thread[] threads = { t1, t2, t3, t4 };

foreach (var item in threads)
{
    item.Start();
}





