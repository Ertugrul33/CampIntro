using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Sınıf isimleri büyük harfle başlar.
    class ProductManager //CRUD -> Create Read Update Delete işlemleri bu isimlendirme(Manager, Services...) ile yapılır.
    {
        //Encapsulation
        public void Add(Product product) //string ad der gibi.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        //void -> Git ekle, git sil başka bir şey yapma, artık işin bitti... demektir.
        //Yani bu işlem sonucunda ekstra bil bilgiye gerek yok.
        //Yani başka bir yerde kullanmak istemiyorsak void kullanılır.

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        /*
        Soru:
        public void Add(Product product) //string ad der gibi.
        {
            product.ProductName = "Kamera"
        }

        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }

        ---------------------------------------

        void ve return'ün farkı:
        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        */
    }
}
