using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Özel bir tip anlamındadır. İstenilen başka bir şey de yazılabilir. Aşağıda ona göre yapılandıracağız. Programcı nasıl bir tip oluşturursa(string, int...) ona göre yapılansın demektir.
    {
        T[] items;
        //Constructor -> class new'lendiği anda otomatik çalışır.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //Cevap: Bu şekilde oluşturur.
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        //Bir sonraki dersin konusu (5. Ders)
        public int Length
        {
            get { return items.Length; }
        }

        //Bir sonraki dersin konusu (5. Ders)
        public T[] Items
        {
            get { return items; }
        }
    }
}
