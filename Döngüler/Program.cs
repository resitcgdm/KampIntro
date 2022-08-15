// See https://aka.ms/new-console-template for more information
/*
using System;

namespace Döngüler// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/


/*
.
.
.
                                                   -HESAP MAKİNESİ-

int i;
int j;
int a;
for ( i = 1; i < 10; i++)
{
 
  
    //Console.WriteLine(i);
    for ( j=1; j<10; j++)
    {
         a= i * j;
        Console.Write(i); Console.Write("x"); Console.Write(j); Console.Write(":");
        Console.WriteLine(a);
    }

}

.
.
.
.
*/

//ARRAY -dizi : Sürekli değişken atamaktansa birden fazla datayı barındıran dizileri oluştururuz.
string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";
string kurs4 = "C#";

// string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "C#" }
string[] kurslar = new string[] { kurs1,kurs2,kurs3,kurs4 ,"Python:)"};
 for (int i=0; i<kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
 Console.WriteLine("For bitti sırada foreachle yapma var");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

