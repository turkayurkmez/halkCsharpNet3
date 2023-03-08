// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

Asci asci = new Asci();
ZeytinYagliYemek pirasa = new ZeytinYagliYemek { PismeSuresi = 35 };
KuruKofte kofte = new KuruKofte { PismeSuresi = 40 };

asci.Pisir(kofte);
asci.Pisir(pirasa);

