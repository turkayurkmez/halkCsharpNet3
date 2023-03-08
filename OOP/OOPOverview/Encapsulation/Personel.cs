namespace Encapsulation
{
    public class Personel
    {
        //public void YillikIzinIste()
        //{

        //}

        private int yas;
        public void SetYas(int yas)
        {
            if (yas >= 18)
            {
                this.yas = yas;
            }
            throw new ArgumentException("yaş değeri en az 18 olmalı");
        }

        public int GetYas()
        {
            return yas;
        }

        private string ad;
        public string Ad
        {
            get { return ad; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Ad alanı boş olamaz");
                }
                ad = value;
            }
        }


        public double Maas { get; set; }

        public int IzinGunleri { get; private set; }






    }
}
