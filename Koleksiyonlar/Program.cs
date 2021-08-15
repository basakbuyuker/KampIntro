using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"başak", "betül", "emracan"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);

            isimler = new string[4]; //new lendiği anda bellekte yeniden yer ayrılır 4 elemanlı ve 4. elemana şükriye değerini veriyor ve
                                     // ger kalan 3 eleman boş olur
            isimler[3] = "şükriye";
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string>() { "başki", "emruş"};
            isimler2.Add("beyti");

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

            isimler2.Add("salih");
             
            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }





        }
    }
}
