using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{ 
    //individual
    class GercekMusteri:Musteri //müşteride olan özellikler kendisini implemente eden sınıflarda da vardır. gerçek müşteri miras alır müşteriden. Esas önemli olan::: Müşteri hem gerçek müşterinin hem de tüzel müşterinin referansını tutabilir!!!
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
    }
}
