using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Product
    {
        public string Name;
        public double Price;
        public int ID { get; }

        public Product(int id, string name, double price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}
