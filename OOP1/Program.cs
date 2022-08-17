// See https://aka.ms/new-console-template for more information

using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;


// Böylede ürün ekleyebiliriz

Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=10 };
//PascalCase(classlar böyle yazılır)
//camelCase (değişken isimleri böyle yazılır)

ProductManager productManager=new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);

/*
productManager.Topla(3, 6);

int toplamaSonucu = productManager.Topla2(3, 6);
Console.WriteLine(toplamaSonucu*2);
*/

