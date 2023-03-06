try
{
	Console.WriteLine("Bir sayı girin");
	int number1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Bir sayı daha girin:");
	int number2 = Convert.ToInt32(Console.ReadLine());

	int result = number1 / number2;

	Console.WriteLine(result.ToString());
}
catch (FormatException)
{
	Console.WriteLine("Girdiğiniz değer, sayıya çevrilemedi");
}
catch (DivideByZeroException)
{
	Console.WriteLine("Sıfıra bölünemez!");
}
catch (Exception ex)
{
	Console.WriteLine($"Bir hata oluştu. Gelen mesaj:{ex.Message}");
}


