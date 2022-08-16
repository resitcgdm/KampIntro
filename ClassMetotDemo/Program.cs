// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;


Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Ad = "Resit";
musteri1.Soyad = "Cigdem";
musteri1.Yas = 26;

Musteri musteri2=new Musteri();
musteri2.Id = 2;
musteri2.Ad = "Emin";
musteri2.Soyad = "Bulut";
musteri2.Yas = 19;

Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.Ad = "Deniz";
musteri3.Soyad = "Yaz";
musteri3.Yas = 28;

Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3 };

foreach (Musteri musteri in musteriler)
{
    Console.WriteLine(musteri.Ad +" "+ musteri.Soyad +"  Id:"+ musteri.Id +" Yas:"+ musteri.Yas);
}




MusteriManager musteriManager= new MusteriManager();
musteriManager.Ekle( musteri1);
Console.WriteLine("--------------");
musteriManager.Listele(musteri1);
Console.WriteLine("--------------");
musteriManager.Sil(musteri1);
Console.WriteLine("--------------");