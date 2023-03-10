namespace ResourceLocking
{
    public class CustomResource
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private object _lock = new object();
        public void writeNumbersToConsole()
        {
            //lock (_lock)
            //{
            Monitor.Enter(_lock);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId}: Yazılan sayı:  {numbers[i]}");
            }
            Monitor.Exit(_lock);
            //}
        }
    }
}
