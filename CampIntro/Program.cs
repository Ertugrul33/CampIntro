using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type Safety = Tip Güvenliği
            //C#'da veri türü yazılmak zorundadır.
            //Do Not Repeat Yourself
            //Değer Tutucu(Alias)

            string kategoriEtiketi = "Kategori"; //Tek tırnak yapılmaz.
            int ogrenciSayisi = 32000;
            double ondalikliSayi = 1.45;
            bool sistemeGirisYapmisMi = false;
            //bool sistemeGirisYapmisMi = sistemeGirisYapmisMiBirBak();
            //Normalde sabit olmaz. Veri kaynağından gelir.

            //Birbiriyle ilişkili olan kodları Solution Explorer bölümüne konulur

            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
