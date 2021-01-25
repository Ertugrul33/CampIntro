using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TCNo = "12345678910";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();//new dendiği için hem GercekMusteri'nin ref. no'sunu tutuyor;
            Musteri musteri4 = new TuzelMusteri();//hem de TuzelMusteri'nin ref. no'sunu tutuyor.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            //Musteri sınıfı her iki sınıfın da ref. no'sunu tuttuğu için bütün müşterileri ekleyebildim.



            //(İlk dakikalar)
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TCNo = "2222222222";
            //musteri1.MusteriNo = "122345";
            //musteri1.SirketAdi = "?"; //Bu müşteri şirket değil, bir şahıs. O yüzden soyutlama yapılmalıdır. Yoksa veri tabanında hatalarla karşılaşılabilir.

            //Gerçek Müşteri - Tüzel Müşteri
            //Bunlar birbirine benziyor diye birbiri yerine kullanılamazlar. Çünkü bunlar farklı müşteri tipleridir.
            //SOLID -> L harfi bunu söylüyor.
        }
    }
}
