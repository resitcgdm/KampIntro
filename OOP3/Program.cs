// See https://aka.ms/new-console-template for more information


using OOP3;

IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager(); //IhtiyacKrediManager yerine IkrediManager de yazarsak  yine olur.Yani Interface lerde heapte oluşan adresimizin referans no sunu tutar...
//ihtiyacKrediManager.Hesapla();

IKrediManager tasitKrediManager=new TasitKrediManager();
//tasitKrediManager.Hesapla();

IKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

BasvuruManager basvuruManager=new BasvuruManager();
//basvuruManager.BasvuruYap(konutKrediManager);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

ILoggerService dataloggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService=new FileLoggerService();

basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> {new DataBaseLoggerService(),new FileLoggerService() });//yada yukarda tanımlayıp böyle değişkeni atarız direk.

// değişkene atanmış hali List<ILoggerService> loggers = new List<ILoggerService>() { new DataBaseLoggerService(), new FileLoggerService() };


//basvuruManager.BasvuruYap(konutKrediManager,new DataBaseLoggerService()); yukarda ki gibi tanımlamadan da böyle yazabiliriz