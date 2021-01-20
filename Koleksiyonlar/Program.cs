using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); Bu şekilde yapıldığında "IndexOutOfRange" hatası alınır.
            
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); Bu kod çalışır fakat;
            //Console.WriteLine(isimler[0]); Bu boş döndürür. Çünkü bellekte yeni bir adres oluşur ve indexler ve değerler atanmadığı için boş döndürür. Çünkü new demek yeni referanslı bir değişken demektir. Eskileri kaybederiz.

            //isimler = new string[5]; //Bu şekilde genişletemiyoruz. Genişletince değerleri kaybediyoruz.

            //Daha sonra atama yapmak istediğimizde diziler sıkıntı çıkarıyor. O yüzden kurumsal işlerde de koleksiyonlar kullanılır.

            List<string> isimler2 = new List<string>() {"Engin", "Murat", "Kerem", "Halil"}; //Bu List arka planda bir array'i yönetir.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]); //Koleksiyonlar sayesinde "İlker" ismi eklenmiş oldu.
            Console.WriteLine(isimler2[0]); //0. indeks de gösterildi.
            
            //Soru: List olmasaydı nasıl oluşturulurdu? (Cevabı "GenericsIntro"da.)
        }
    }
}
