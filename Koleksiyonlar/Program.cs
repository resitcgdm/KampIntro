// See https://aka.ms/new-console-template for more information

string[] isimler = new string[] {"Halil","Cem","Murat","Cemal" };
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
Console.WriteLine(isimler[3]);

//Array lere sonrada ekleme yapamadıgımız icin Koleksiyonlar kullanılır.
//isimler=new String[5]; isimler[4]="İlker" der isek isimler 4elemanlı isimler arrayi iptal olur ve 5elemanlı içi boş array olur ve 4.elemanı olarak ilkeri atar.


List<string> isimler2 = new List<string> {"H","C","M","K" };
//isimler2.Add("M"); böyle de ekleme yapabiliriz.
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("R");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);
