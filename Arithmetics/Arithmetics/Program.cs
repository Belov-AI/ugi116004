using System;

namespace Arithmetics
{
    class Program
    {
        static void Main()
        {
            int n = 2;
            const double g = 9.8;

            Console.WriteLine(n);
            Console.WriteLine(g);
            Console.WriteLine(n++ + ++n);
            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
