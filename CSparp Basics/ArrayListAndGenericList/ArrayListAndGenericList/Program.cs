using System.Collections;

namespace ArrayListAndGenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //bir object tipine değer atamak: Boxing -> kutulamadır!
            object value = "Selam";
            //object tipindeki bir değerle çalışabilmek için; kutudan çıkararak kendi değerine dönüştürmeniz gerek:
            //unboxing -> kutudan çıkarma!
            int test = (int)value;


            string response = string.Empty;
            //int[] numbers = new int[0];
            //ArrayList numbers = new ArrayList();
            List<T> numbers = new List<T>();
            List<object> objectList = new List<object>();

            ArrayList list = new ArrayList
            {
                "Türkay",
                43,
                false
            };

            do
            {
                Console.WriteLine("Bir sayı giriniz");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
                //Array.Resize(ref numbers, numbers.Length + 1);
                //numbers[numbers.Length - 1] = number;
                Console.WriteLine("Bir sayı daha eklemek ister misiniz (E/H)?");
                response = Console.ReadLine();
            } while (response == "E");

            //Console.WriteLine($"Numbers arrayi içindeki toplam eleman: {numbers.Length} ");
            Console.WriteLine($"Numbers arrayi içindeki toplam eleman: {numbers.Count} ");

            var total = 0;
            //foreach (var number in numbers)
            //{
            //    total += number;
            //}

            foreach (var number in numbers)
            {
                total += number;
            }

            Console.WriteLine($"Numbers arrayi içindeki elemanların toplamı: {total} ");
            Console.WriteLine($"Numbers arrayi içindeki elemanların ortalaması: {total / numbers.Count} ");


        }
    }
}