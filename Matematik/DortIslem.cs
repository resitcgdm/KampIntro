using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç :" + toplam);
        }


        public void Cikar(int sayi1, int sayi2)
        {
            int toplam;
            
            if (sayi1 > sayi2)
            {
                toplam = sayi1 - sayi2;
            }
            else if (sayi1 < sayi2)
            {
                toplam = sayi2 - sayi1;
            }
            else
            {
                toplam = 0;
            }
            Console.WriteLine("Sonuç :" + toplam);
        }
        public void Carp(int sayi1, int sayi2)
        {
            
            double sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuç :" + sonuc);
        }
        public void Bol(double sayi1, double sayi2)
        {
           
            double sonuc = sayi1 / sayi2;
            Console.WriteLine("Sonuç :" + sonuc);
            /*if (sayi1 > sayi2)
            {
                 sonuc = sayi1 / sayi2;
            }
            else if (sayi1 < sayi2)
            {
                 sonuc = sayi2 / sayi1;
            }
            else
            {
                 sonuc = 1;
            }*/

        }

    }
}