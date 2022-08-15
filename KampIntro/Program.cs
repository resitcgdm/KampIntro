// See https://aka.ms/new-console-template for more information
string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOranı = 1.45;
double dolarDun = 7.45;
double dolarBugun = 7.45;
bool sistemeGirisYapmismi = false;

if(dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");

}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış butonu");

}
else
{
    Console.WriteLine("Değişmedi butonu");
}
/*
if (sistemeGirisYapmismi==true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine(" Kayıt ol butonu");
}
*/