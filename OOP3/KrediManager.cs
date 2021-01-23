using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır.
    interface IKrediManager //Tek başına bir anlam ifade etmez, sadece ebeveyn görevi gördüğü için interface dendi. Okunurluğu arttırmak için başına "I" konulur. Şablon demektir. Operasyon sınıflarında kullanılır. Aynı zamanda referans tutucu görevi görür.
    {
        void Hesapla();
        void BiseyYap();
    }
    //Loglama, kim ne zaman hangi operasyonu çağırmayı kontrol eder. Bir nevi o sistemde olan hareketleri döktüğümüz bir dökümdür.
    //Loglar, dosyalarda, veri tabanlarında tutulabilir veya SMS olarak gönderilebilir.
    //Her biri için farklı kodlar yazılır.
}

