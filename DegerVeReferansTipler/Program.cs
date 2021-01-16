using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu konu çok çok ÖNEMLİ!!!
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? -> 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayilar1'in ref. nosu, sayilar2'in ref. nosuna eşittir demektir.
            sayilar2[0] = 999;
            //sayilar1[0] ?? -> 999 (Neden?)

            //int, decimal, float, double, bool -> değer tip
            //array, class, interface -> referans tip(türler önemli değil)

            //Bellekte iki yer vardır: stack ve heap
            //Değer tipler stackte, referans tipler heapte tutulur.

            //Değer Tip İçin
            //stack                     heap
            //sayi1=10 -> 30
            //sayi2=30 -> 65

            //Referans Tip İçin
            //stack                                          heap
            //101(adres)/sayilar1 ---> new dendiği anda ---> 101(adres)/[10, 20, 30]
            //102(adres)/sayilar2 ---> new dendiği anda ---> 102(adres)/[100, 200, 300]

            //Atamadan sonra
            //stack                     heap
            //                          101(adres)/[10, 20, 30] -> Garbage Collector bunu bellekten atar. Çünkü bunu tutan referans numarası artık kalmadı.
            //102(adres)/sayilar1  -->  102(adres)/[999, 200, 300]
            //102(adres)/sayilar2  -->  102(adres)/[999, 200, 300]
        }
    }
}
