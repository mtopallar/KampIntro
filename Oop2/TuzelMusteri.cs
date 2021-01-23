using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{ 
    //coorporate
    class TuzelMusteri:Musteri //miras (inheritance) - tüzel müşteri bir müşteridir demek bu. burada müşteri ebeveyn
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
