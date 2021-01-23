using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //CoorporateCustomer
    //Özellik sınıfı (Operasyon olmaz)
    class TuzelMusteri :Musteri //Miras -> Inheritance (Tüzel müşteri bir müşteridir demek)
    { 
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
