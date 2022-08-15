// See https://aka.ms/new-console-template for more information


//Tekrar tekrar kullanılabilir kod bloklarıdır
//Do not repeat yourself 
using Methotlar;

Urun urun1 = new Urun(); //classlar ile değişken oluşturmuş oluyoruz bu yüzden new class ismi yazılır
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklamasi = "Amasya elması";
urun1.stokAdedi = 55;

Urun urun2=new Urun();
urun2.Adi = "Kavun";
urun2.Fiyati = 50;
urun2.Aciklamasi = "Diyarbakır karpuzu";
urun2.stokAdedi = 52;

Urun[] urunler = new Urun[] {urun1,urun2 };

//type-safe --C# ve JAVA tip güvenli bir programlama dili olduğu için veri tipini yazarız her yerde Urun urun gibi
foreach (Urun urun  in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine("Fiyatı:"+urun.Fiyati);
    Console.WriteLine(urun.Aciklamasi);
    Console.WriteLine("Stok Adedi:"+urun.stokAdedi);
    Console.WriteLine("------------------------------");
}
Console.WriteLine("-----------Metotlar----------------");      

//instance-örnek oluşturma gibi
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
sepetManager.Ekle2("Armut", "Yeşil armut", 12,33);
sepetManager.Ekle2("Kiraz", "Taze kiraz", 13,44);
sepetManager.Ekle2("Erik", "Ekşi erik", 14,55);