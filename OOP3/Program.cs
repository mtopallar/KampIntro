using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        // interfaceleri konuşacağız.
        static void Main(string[] args)
        {
            /*
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            */

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // !!! sonuç interfaceler de kendini implemente eden classların referanslarını tutabilirler.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
           basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService); //IKrediManager ı implemente eden herhangi bir kredi gönderilebilir. Hangisi gönderilirse onun kendi hesaplası çalışır.
            // *** Bu kullanım yani soyutlama çok önemlidir*** Yazılımda sürdürülebilirlik!

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            // o open close prensibi => sisteme yeni bir kod eklendiğinde mevcut kodlar bozulmaz. (esnaf kredisi ekledik)
        }
    }
}
