// See https://aka.ms/new-console-template for more information

// int,decimal,float,double,bool(0,1) => Değer Tip'tir.
//array,class,interface => Referans Tip'tir.

int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
//sayi1=? kaç olur? cevap:30. Çünkü değer tipliler de sayi1'i sayi2'ye eşitledikten sonra sayi2 ile ilişkisi kesilir sayi2 değişse bile etkilenmez

int[] sayilar1 = new int[] { 10, 20, 30 };

int[] sayilar2 = new int[] { 100, 200, 300 };

sayilar1 = sayilar2;
sayilar2[0] = 999;
//sayilar1[0]=? kaç olur? Cevap:999. Çünkü Referans tiplilerde ilişki kesilmez.Değer tipliler bellekte STACK bölümünde işlem görür fakat referans tiplilerde
// STACK'e yazilan sayılar1 new int[] diyerek HEAP adlı bölümde verilen sayıların oluşmasını sağlar.Ve arasındaki bağlantıyı adres ile oluşturur.

