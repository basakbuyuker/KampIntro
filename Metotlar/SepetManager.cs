using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convertion
        public void Ekle(Urun urun) //parantez için parametre  ne ekleyeceğini soyle demek istiyor.
        {
            Console.WriteLine(urun.UrunAdi + " sepete eklendi.");
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("eklendi : " + urunAdi);
        }


    }
}
