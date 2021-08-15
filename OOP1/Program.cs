using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 3;
            product1.UnitPrice = 500;

            Product product2 = new Product { Id = 2, ProductName = "Kalem", CategoryId = 2, UnitsInStock = 400, UnitPrice=60 };
            
            //  stack te oluşturuldu   //   heap te oluşturuldu
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            //Console.WriteLine(product1.ProductName); // kamera - referans tip product türünden olduğu için

            /*
            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi); //100 - değer tip
             */



        }
    }
}
