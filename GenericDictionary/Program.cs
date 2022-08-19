// See https://aka.ms/new-console-template for more information

using GenericDictionary;

Dictionary<int,string> musteri = new Dictionary<int,string>();
musteri.Add(25, "Resit");
musteri.Add(19, "Nalan");
Dictionary<int,int> servet=new Dictionary<int,int>();
servet.Add(11, 22);

foreach (var item in musteri)
{
    Console.WriteLine("Yaş: "+item.Key+ " " + "İsim: " +item.Value);
}



Mydictionary<int, string> isimler = new Mydictionary<int, string>();
isimler.Add(22, "ç");
isimler.Add(22, "r");

isimler.ShowList();

