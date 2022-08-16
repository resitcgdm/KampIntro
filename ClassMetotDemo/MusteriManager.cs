using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " :" + musteri.Id + " "+musteri.Yas);
            Console.WriteLine("Ekleme işlemi tamamlandı");
            Console.WriteLine("------------");
        }
        public void Listele(Musteri musteri) 
        {
                Console.WriteLine("Müşteriler listeleniyor"+" "+musteri.Ad+ musteri.Soyad + " :" + musteri.Id + " " + musteri.Yas);
            Console.WriteLine("Müşteriler Listelendi");
            Console.WriteLine("-----------------" );
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad+" isimli müşteri siliniyor...");
            Console.WriteLine("silme işlemi tamamlandı.");
            Console.WriteLine("-------");

        }



    }


}
