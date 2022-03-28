using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Program
    {
        static void Main()
        {
            var warehouse = new Warehouse(10);

            var tv = new Product(1, "LG 42\"", 48000);
            warehouse.Add(tv);

            var freezer = new Product(2, "Stinol 8542", 35000);
            warehouse.Add(freezer);

            var oven = new Product(3, "Samsung 2411", 7000);
            warehouse.Add(oven);

            foreach (var product in warehouse)
                PrintProduct(product);

            Console.ReadKey();
        }

        static void PrintProduct(Product p)
        {
            Console.WriteLine($"{p.Name}. Цена {p.Price:F2} руб. Артикул {p.ID}");
        }
    }
}
