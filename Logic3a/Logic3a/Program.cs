using System;

namespace Logic3a
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine(IsItTrue(x));
            
            Console.ReadKey();
        }

        static bool IsItTrue(double x)
        {
            //return !(x > 0 && x < 5);
            return x <= 0 || x >= 5;
        }
    }
}
