using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //class KrediManager
        
        /*
        public void Hesapla()
        {
          konut, taşıt, ihtiyaç kredilerinin farklı faiz oranları farklı dosya masrafları vardır. Burada metodun imzası aynı fakat içeriği farklıdır: BUNUN İÇİN INTERFACE kullanırız. İnterfacelerde imzalar sabit, metod gövdeleri farklı olabilir.
        }
        */


        public void Hesapla();
        void BiseyYap();

        // interface arayüz (şablon) demektir.
        //   INTERFACELERI birbirinin alternatifi olan ama kod içeriği farklı olan durumlar için kullanırız.
    }
}
