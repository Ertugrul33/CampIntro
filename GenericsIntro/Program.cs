using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            //Bir sonraki dersin konusu (5. Ders)
            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
