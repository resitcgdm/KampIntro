using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T> // burdaki T type ı belirtir yani Mylist classımızın tipi ne girilirse o olucak program.cs imizde
    {
        T[] items; 
        
        
        //ctor
        //constructor(Bir class new lendiğinde çalışan bloğa denir). Yukardaki classı bir yerde new lersek aşağıdaki Mylist otomatik çalışır.
        public MyList() //default constructor
        {
             items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //burası da items daki elemanları buraya emanet ediyoruz daha sonradan almak üzere
            items = new T[items.Length + 1]; // dizimiz eleman sayısını artırmamız lazım önce cünkü 0 elemanlı oldugunu belirttik yukarıda
            //daha sonra ekleme yapabiliyoruz. Ve burda tekrar newledigimiz icin(her seferinde items dizimizi 1 arttır) yeni referans numarası alıyor.O yüzden önceki elemanlarımızı başka yere aktarmamız gerek

            for (int i = 0; i < tempArray.Length; i++)

                //tempArray deki dizi icinde ne kadar eleman varsa döndür ve items ile index numarasına  göre yerine koy.
           
            {
                items[i] = tempArray[i];
                items[items.Length - 1] = item; // items 'ın sonuncu elemanı item parametresi yani ekleyecegimiz eleman olsun diyoruz.

            }
        }


    }

}
