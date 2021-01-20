using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Snippet
    class Product //Bu tip class'larda sadece özellikler olur. (Entity)
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //Kod okunurluluğunu arttırmak için Id'ler genelde alt alta yazılır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //Ürünün Birim Fiyatı
        public int UnitsInStock { get; set; } //Stok Adedi

        //CRUD -> Create Read Update Delete (bu gibi işlemler başka sınıflarda yazılır.)

    }
}
