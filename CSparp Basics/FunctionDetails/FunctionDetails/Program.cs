// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string abc = "";
Area area = new Area();
area.GetArea(3, Geometry.Square);
area.GetArea(3, 5, Geometry.Rectangle);

Console.WriteLine($"Kare: {area.OptionalGetArea(5)}");
Console.WriteLine($"Daire: {area.OptionalGetArea(5, geometry: Geometry.Circle)}");
Console.WriteLine($"Dikdörtgen: {area.OptionalGetArea(5, 3, geometry: Geometry.Rectangle)}");
Console.WriteLine($"Üçgen: {area.OptionalGetArea(5, unit2: 6, geometry: Geometry.Triangle)}");


Console.WriteLine($"Dikdörtgen: {area.OptionalNullGetArea(5, geometry: Geometry.Rectangle)}");

Random? random = getRandomInstance();
int? randomNumber = random?.Next(0, 10);
Console.WriteLine(randomNumber ?? 0);




Random? getRandomInstance()
{
    return new Random();
}









public class Area
{
    public double GetArea(double unitLength, Geometry geometry)
    {
        double area = 0;
        switch (geometry)
        {
            case Geometry.Square:
                area = Math.Pow(unitLength, 2);
                break;
            case Geometry.Circle:
                area = Math.Pow(unitLength, 2) * Math.PI;
                break;

            default:
                break;
        }
        return area;
    }

    public double GetArea(double unit1, double unit2, Geometry geometry)
    {
        double area = 0;
        switch (geometry)
        {
            case Geometry.Rectangle:
                area = unit1 * unit2;
                break;
            case Geometry.Triangle:
                area = unit1 * unit2 / 2;
                break;
        }

        return area;
    }

    public double GetArea(Geometry geometry, double unitLength)
    {
        double area = 0;
        switch (geometry)
        {
            case Geometry.Square:
                area = Math.Pow(unitLength, 2);
                break;
            case Geometry.Circle:
                area = Math.Pow(unitLength, 2) * Math.PI;
                break;

            default:
                break;
        }
        return area;
    }

    public double OptionalGetArea(double unit1, double unit2 = 1, Geometry geometry = Geometry.Square)
    {
        switch (geometry)
        {
            case Geometry.Square:
                return Math.Pow(unit1, 2);
            case Geometry.Rectangle:
                return unit1 * unit2;


            case Geometry.Circle:
                return Math.Pow(unit1, 2) * 3.14;
            case Geometry.Triangle:
                return unit1 * unit2 / 2;
            default:
                return 0;

        }
    }

    public double OptionalNullGetArea(double unit1, double? unit2 = null, Geometry geometry = Geometry.Square)
    {
        switch (geometry)
        {
            case Geometry.Square:
                return Math.Pow(unit1, 2);
            case Geometry.Rectangle:
                //if (unit2.HasValue)
                //{
                //    return unit1 * unit2.Value;
                //}
                //else
                //{
                //    throw new ArgumentNullException(nameof(unit2));
                //}

                //return unit2.HasValue ? unit1 * unit2.Value : 0;
                return unit1 * (unit2 ?? 1);


            case Geometry.Circle:
                return Math.Pow(unit1, 2) * 3.14;
            case Geometry.Triangle:
                //return unit2.HasValue ? (unit1 * unit2.Value) / 2 : throw new ArgumentNullException(nameof(unit2));
                return unit1 * (unit2 ?? 0) / 2;
            default:
                return 0;

        }
    }

}



public enum Geometry
{
    Square,
    Rectangle,
    Circle,
    Triangle
}

