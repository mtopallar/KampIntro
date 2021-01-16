using System;

namespace DonguOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "Traş bıçağı";
            urun1.GorselAdresi = "ürün resminin konumu";
            urun1.EskiFiyat = 35.49;
            urun1.Fiyat = 30;

            Product urun2 = new Product();
            urun2.UrunAdi = "Ütü";
            urun2.GorselAdresi = "ürün resminin konumu";
            urun2.EskiFiyat = 475.59;
            urun2.Fiyat = 385.99;

            Product urun3 = new Product();
            urun3.UrunAdi = "Orkide Saksısı";
            urun3.GorselAdresi = "Ürün görselinin adresi";
            urun3.EskiFiyat = 59.90;
            urun3.Fiyat = 44.90;

            Product[] urunler = new Product[]{urun1,urun2,urun3};

            Console.WriteLine("For ile listeleme");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün adı :"+ urunler[i].UrunAdi+" Ürün resmi :" + urunler[i].GorselAdresi +" Indirimsiz fiyat :"+urunler[i].EskiFiyat+" Güncel Fiyat :"+urunler[i].Fiyat);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Foreach ile listeleme");
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün adı :" +urun.UrunAdi+" Ürün Resmi : "+urun.GorselAdresi+" İndirimsiz Fiyat :  "+urun.EskiFiyat+" Güncel Fiyat : "+urun.Fiyat);
            }
            Console.WriteLine("\n");

            Console.WriteLine("While ile listeleme");

            int sayac = 0;
            while (sayac < urunler.Length)
            {
                Console.WriteLine("Ürün adı : "+ urunler[sayac].UrunAdi+" Ürün görseli : "+urunler[sayac].GorselAdresi+" İndirimsiz Fiyat : "+urunler[sayac].EskiFiyat+" Güncel Fiyat : "+urunler[sayac].Fiyat);
                sayac++;
            }
        }
    }

    class Product
    {
        public string UrunAdi { get; set; }
        public string GorselAdresi { get; set; }
        public double EskiFiyat { get; set; }
        public double Fiyat { get; set; }

    }
}
