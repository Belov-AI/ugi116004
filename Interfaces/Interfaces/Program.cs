using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            var car = new Car();
            var plane = new Plane();

            IDivable[] vehicles = new IDivable[] { car, plane };

            foreach (var vehicle in vehicles)
                vehicle.Start();

            Console.ReadKey();
        }
    }
}
