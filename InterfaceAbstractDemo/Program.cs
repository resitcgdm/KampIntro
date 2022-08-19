// See https://aka.ms/new-console-template for more information



using InterfaceAbstractDemo;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer { DateOfBirth = new DateTime(1996,8,5),FirstName="Reşit",LastName="Çiğdem",NationalityId="49189066384" });
Console.ReadLine();    

