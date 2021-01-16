using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);

            // array - dizi
            string[] kurslar = new string[] {"Yazılım geliştirici yetiştirme kampı","Programlamaya başlangıç için temel kurs","Java","Python"};

            for (int i = 0; i <kurslar.Length; i++)//i+=2
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //foreach dizilere uygulanır. kurs alias.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
