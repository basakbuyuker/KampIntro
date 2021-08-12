using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            string kurs1 = "yazılım geliştirme kursu";
            string kurs2 = "programlamaya başlangıç";
            string kurs3 = "java kursu";

            string[] kurslar = new string[] {kurs1, kurs2, kurs3};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\n\n\n------------------------");

            string[] kurslar2 = new string[] { "yazılım geliştirme kursu", "programlamaya başlangıç", "java kursu", "C++" };
            for (int i = 0; i < kurslar2.Length; i++)
            {
                Console.WriteLine(kurslar2[i]);
            }
            Console.WriteLine("\n\n\n------------------------");

            foreach (var kurs in kurslar) // dizi temelli yapıları tek tek döner
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\n\n\n------------------------");

            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
