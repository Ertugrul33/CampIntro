using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sınıflar özellikli ve operasyonlu(metodlu) olmak üzere ikiye ayrılır.

            //Nesne Oluşturmanın 1. Yolu
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Nesne Oluşturmanın 2. Yolu
            Product product2 = new Product { Id = 2, CategoryId = 5,
                UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};

            //case sensitive
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager(); //new dendiği için belleğin "heap" bölümünde oluşturuldu.
            //stack                       = heap

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            /*             
            Soru: 
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //?? -> Kamera

            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi); //?? -> 100

            //Çünkü:
            //int, double, bool... değer tip idi.
            //diziler, class, abstract class, interface... referans tip idi.

            //Değer tipler değer ile iş yapar.
            //Referans tipler bellekteki referans numarası ile iş yapar ve o referans numarası artık kamerayı gösterir.

            ------------------------------------------------------------------------

            void ve return'ün farkı:
            productManager.Topla2(3, 6); //Bu işlemin sonucunu artık başka bir yerde kullanamam. void'in amacı budur.

            int toplamaSonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamaSonucu * 2); //Fakat return dediğim için sonucunu tekrar başka bir yerde kullanabildik. return'ün amacı budur.
            */
        }
    }
}
