using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Eklendi : " + product.ProductName);
            //product.ProductName = "kamera";
        }
        public void Update(Product product)
        {
            Console.WriteLine("Güncellendi : " + product.ProductName);
        }









        /*
        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }*/
    }
}
