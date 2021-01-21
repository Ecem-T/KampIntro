using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;   //or true

            double dolarDun = 7.35;    //7.55
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun< dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişme butonu");
            }
            
            if(sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
                     

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
