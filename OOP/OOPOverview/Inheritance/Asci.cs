namespace Inheritance
{
    public class Asci
    {
        public void Pisir(Yemek yemek)
        {
            yemek.Pisir();
            yemek.SunumYap();
        }
    }

    public class Yemek
    {
        public int PismeSuresi { get; set; }
        public List<string> Malzemeleri { get; set; }
        public double Price { get; set; }


        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name} yemeği {PismeSuresi} dakika sürede pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yemeği, yanında pilav ile sunuldu");

        }
    }

    public class ZeytinYagliYemek : Yemek
    {
        public bool SogukMu { get; set; }
        public bool LimonluMu { get; set; }

        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yemeği, yanında limon tabağı ile sunuldu");
        }
    }

    public class EtliYemek : Yemek
    {
        public string PismeDerecesi { get; set; }
        public bool SosVarMi { get; set; }

        public void SosHazirla()
        {

        }
    }

    public class Kofte : EtliYemek
    {

    }

    public class KuruKofte : Kofte
    {

    }


}

