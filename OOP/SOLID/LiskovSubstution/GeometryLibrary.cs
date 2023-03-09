namespace LiskovSubstution
{
    public class GeometryLibrary
    {
        public IAreaCalcutable RectangleFactory(int unit1, int? unit2 = null)
        {
            //Burada başka bir işlem yapılıyor ve Kare nesnesi döndürülüyor. 
            return unit2 != null ? new Rectangle { Width = unit1, Height = unit2.Value } :
                                new Square { UnitLength = unit1 };
        }

    }

    public interface IAreaCalcutable
    {
        int GetArea();
    }

    public class Rectangle : IAreaCalcutable
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea() => Width * Height;
    }

    public class Square : IAreaCalcutable //: Rectangle
    {
        public int UnitLength { get; set; }

        public int GetArea()
        {
            return (int)Math.Pow(UnitLength, 2);
        }
    }
}
