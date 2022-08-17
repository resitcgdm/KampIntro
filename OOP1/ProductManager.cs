using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager
    {
        public void Add(Product product) 
        {
            //product.ProductName = "Kamera"; referans tipli olduğu için product1 ürünümüz olan masa kamera olarak değişir.
            Console.WriteLine(product.ProductName +"Eklendi."); 
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }
        /*
        public void Topla(int sayi1,int sayi2)  //void işlemi yapar ve işi biter fakat public int dersek işlemi yapar int değer verir.
        {                                       //Ve return sayesinde çıkan değeri tekrardan kullanabiliriz ama voidde yapılırsa kullanamayız.
            Console.WriteLine(sayi1 + sayi2);
        }

        public int Topla2(int sayi1,int sayi2)
        {
            return sayi1+ sayi2;    
        }
        */
    }
}
