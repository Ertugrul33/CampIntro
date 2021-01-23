using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //IndividualCustomer
    //Özellik sınıfı (Operasyon olmaz)
    class GercekMusteri :Musteri //Miras -> Inheritance (Gerçek müşteri bir müşteridir demektir.
    {
        public string TCNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
