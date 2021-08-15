using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //özellik tutan clas
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //referans alanları
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


        //CRUD - create read update delete
    }
}
