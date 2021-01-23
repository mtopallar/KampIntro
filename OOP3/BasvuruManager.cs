using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection
        
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //interfacelerin gerçek hayat kullanımı budur!! SOLID buna dayanır. Buraya IKrediManager'i implemente eden tüm krediler böylelikle gönderilebilir. (Polymorphizm)
        {
            // Başvuran bilgilerini değerlendirme
            //
            /*KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            Tüm başvurular konutkredisine bağımlı hale gelir. Bu doğru değildir.
             */

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
