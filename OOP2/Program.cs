// See https://aka.ms/new-console-template for more information

using OOP2;

Customer customer = new Customer();


RealCustomer customer1 = new RealCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "21312";
customer1.FirstName = "Reşit";
customer1.LastName = "Çiğdem";
customer1.TcNumber = "12312312";
LegalCustomer customer2 = new LegalCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "555123";
customer2.TaxNumber = "112233";
customer2.CompanyName = "let's code together";


Customer customer3 = new RealCustomer();  //ebeveyn oldugu icin ikisininde referans no sunu tutabilir.
Customer customer4 = new LegalCustomer();

CustomerManager customerManager=new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer4);




//Gerçek Müşteri-Tüzel Müşteri ikisinde de müşteri var diye birbiriyle eş değer değildir.Oyüzden yukardaki yazdıklarımız ileride sorun oluşturabilir.

//SOLID