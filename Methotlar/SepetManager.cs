using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
     class SepetManager
    {
        //naming convetion - yazım kuralı E si büyük olmalı
        //syntax
        public void Ekle(Urun urun) //encapsulation olayı aşağıdakinin daha kullanışlı hali
        {
            Console.WriteLine("Sepete eklendi: "+urun.Adi);
        }

        //alttaki yöntemi de kullanabiliriz fakat bi değişiklik olduğunda mesela stok adedi de girmemiz gerekirse her sayfa da değişme yükü oluşur.Bu yüzden yukardaki gibi class ataması ile sadece classa stok adedini eklememiz yeterli olur...

       public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi);
        }

    }
}
