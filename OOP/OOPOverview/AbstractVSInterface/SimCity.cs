namespace AbstractVSInterface
{
    public class SimCity
    {
    }


    public class Oyuncu
    {
        public void Giy(IKiyafet kiyafet)
        {

        }
    }

    public interface IKiyafet
    {

    }
    public abstract class Kiyafet : IKiyafet
    {

    }
    public class Kazak : Kiyafet
    {

    }

    public class KirmiziKazak : Kazak
    {

    }
}
