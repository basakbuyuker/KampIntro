using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("azalış");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("sabit");
            }


            if (sistemeGirisYapmisMi!) // true değilse
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else 
            {
                Console.WriteLine("giris yap butonu"); 
            }

            Console.WriteLine(kategorEtiketi);


        }
    }
}
