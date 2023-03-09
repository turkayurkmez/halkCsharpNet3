/*
 * Bir nesne,  ...Gelişime... AÇIK ...Değişime.... KAPALI olmalı.
 * 
 * Varolan bir nesneye yeni bir özellik kazandırmak istediğinizde; önceki kodları DEĞİŞTİRMEK zorunda kalıyorsanız, bu ilkeyi ihlal ediyorsunuz demektir.
 */
Customer customer = new Customer { Name = "Türkay", CartType = new Premium() };
OrderManager orderManager = new OrderManager { Customer = customer };
var price = orderManager.GetTotalPrice(1000);
Console.WriteLine(price);


public abstract class CartType
{
    public abstract double GetDiscountedPrice(double total);

}

public class Standart : CartType
{
    public override double GetDiscountedPrice(double total)
    {
        return total * .95;
    }

}

public class Silver : CartType
{
    public override double GetDiscountedPrice(double total)
    {
        return total * .9;
    }

}

public class Gold : CartType
{
    public override double GetDiscountedPrice(double total)
    {
        return total * .85;
    }

}

public class Premium : CartType
{
    public override double GetDiscountedPrice(double total)
    {
        return total * .8;
    }
}

public class Customer
{
    public string Name { get; set; }
    public CartType CartType { get; set; }
}

public class OrderManager
{
    public Customer Customer { get; set; }

    public double GetTotalPrice(double price)
    {
        double total = 0;
        total = Customer.CartType.GetDiscountedPrice(price);
        //switch (Customer.CartType)
        //{
        //    case CartType.Standard:
        //        total = price * 0.95;
        //        break;
        //    case CartType.Silver:
        //        total = price * .9;
        //        break;
        //    case CartType.Gold:
        //        total = price * .85;
        //        break;
        //    case CartType.Premium:
        //        break;
        //    default:
        //        break;
        //}

        return total;
    }
}
