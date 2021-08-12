using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 3.75;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 5.99;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.Fiyati);        
            }

            //encapsulation
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            
            sepetManager.Ekle(urun2);
            
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 1000);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 1000);
            sepetManager.Ekle2("Kavun", "Sarı siyah", 12, 1000);
        }
    }
}
