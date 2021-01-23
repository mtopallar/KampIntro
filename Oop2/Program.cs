using System;

namespace Oop2
{
    class Program
    { 
        // bugün soyutlamayı kavramaya çalışacağız. (5. gün)
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "2222222222";


            //Tüzel müşteri - Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            // Gerçek Müşteri - tüzel müşteri sırf birbirine benziyor diye birbirlerinin yerine kullanılamazlar.
            //SOLID => L

            Musteri musteri3 = new GercekMusteri(); //Musteri gerçek müsterinin referansını tutabilir
            Musteri musteri4 = new TuzelMusteri(); // Musteri tuzel musterinin de referansını tutabilir.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4); // işte inheritance bunun için önemlidir.
        }
    }
}
