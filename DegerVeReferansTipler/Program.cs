﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);


            int[] sayilar1 = new[] {10, 20, 30};
            int[] sayilar2 = new[] {100, 200, 300};

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            //int, decimal,float,double,bool = değer tip
            // array, class,interface => referans tip

            //stack => heap. new heap de yeni bir yer (adres) oluştur demek
            
        }
    }
}
