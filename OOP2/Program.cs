using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri();
            musteri.MusteriNo = "12345";
            musteri.Adi = "başak";
            musteri.Soyadi = "buyuker";
            musteri.TcNo = "12345678910";
            musteri.Id = 1;

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.SirketAdi = "bbausy";
            tuzelMusteri.MusteriNo = "0458";
            tuzelMusteri.Id = 2;
            tuzelMusteri.VergiNo = "7878";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customer = new CustomerManager();
            customer.Add(musteri);
            customer.Add(tuzelMusteri);
            customer.Add(musteri3);
            customer.Add(musteri4);







            //      gerçek - tüzel müşteriler
             

        
        }
        
    }
}
