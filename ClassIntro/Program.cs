// See https://aka.ms/new-console-template for more information
/*
string adi = "Engin";
int yas = 36;

Kurs kurs1 = new Kurs();
kurs1.kursAdi = "C#";
kurs1.egitmen = "Engin Demiroğ";
kurs1.izlenmeOrani = 71;

Kurs kurs2 = new Kurs();
kurs2.kursAdi = "Java";
kurs2.egitmen = "Kerem";
kurs2.izlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.kursAdi = "Python";
kurs3.egitmen = "Berkay";
kurs3.izlenmeOrani = 90;

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 }; //kurs tipinde kurslar adında array oluşturduk.

foreach(Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.kursAdi+":" + kurs.egitmen);
    
    Console.WriteLine(kurs.izlenmeOrani);
}
*/

urun urun1 = new urun();
urun1.urunAdi = "Saat";
urun1.urununMarkasi = "Daniel Klein";
urun1.urununFiyati = 899;
urun1.urununKampanyasi = "Bileklik hediye";

urun urun2 = new urun();
urun2.urunAdi = "Kolye";
urun2.urununMarkasi = "Theis";
urun2.urununFiyati = 120;
urun2.urununKampanyasi = "Hediye yok";

urun urun3 = new urun();
urun3.urunAdi = "Gözlük";
urun3.urununMarkasi = "Rayban";
urun3.urununFiyati = 699;
urun3.urununKampanyasi = "Gözlük koyma kabı hediye";


urun[] urunler = new urun[] { urun1, urun2, urun3 };

/*
foreach (var urun in urunler)
{
    Console.WriteLine("Ürünün adı ve markası:"+urun.urunAdi+"=> "+urun.urununMarkasi);
    Console.Write("Ürünün Fiyatı:" );
    Console.WriteLine(urun.urununFiyati);
    Console.WriteLine("Ürünün Kampanyası:"+urun.urununKampanyasi);

}
*/
/*
for (int i=0; i<urunler.Length; i++)
{
    Console.WriteLine("Ürün Adı:"+urunler[i].urunAdi +" "+"=>" + urunler[i].urununMarkasi);
    Console.Write("Ürünün fiyatı:"); Console.WriteLine(urunler[i].urununFiyati);
    Console.WriteLine("Ürünün Kampanyası :"+" "+urunler[i].urununKampanyasi);
}
*/
int i = 0;

while (i<urunler.Length)

{
    
    Console.WriteLine("Ürün Adı:" + urunler[i].urunAdi + " " + "=>" + urunler[i].urununMarkasi);
    Console.Write("Ürünün fiyatı:"); Console.WriteLine(urunler[i].urununFiyati);
    Console.WriteLine("Ürünün Kampanyası :" + " " + urunler[i].urununKampanyasi);
    i++;
    
}


class urun
{
    public string urunAdi { get; set; }
    public string urununMarkasi { get; set; }
    public int urununFiyati { get; set; }
    public string urununKampanyasi { get; set; }

}

















class Kurs
{
    public string kursAdi { get; set; }
    public string egitmen { get; set; }
    public int izlenmeOrani { get; set; }

}





