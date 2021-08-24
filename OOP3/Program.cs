using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TaşıtKrediManager tasitKrediManager = new TasitKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //ihtiyacKrediManager.Hesapla();


            //IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager1 = new TasitKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager konutKrediManager1 = new KonutKrediManager();
            //ihtiyacKrediManager.Hesapla();



            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager2 = new TasitKrediManager();
            IKrediManager konutKrediManager2 = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager2, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(tasitKrediManager2, fileloggerService); 

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager2, tasitKrediManager2, konutKrediManager2 };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);            
                

        }
    }
}
