using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //Naming Convention (Kural gereği "E" harfi büyük olmalı.)
        //Syntax
        public void Ekle(Urun urun) //Encapsulation - Kapsülleme
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urun.Adi);
        }
        
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //Kapsülleme yapılarak daha kolay hale geldi.
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + urunAdi);
        }
    }
}
