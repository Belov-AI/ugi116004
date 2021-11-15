using System;
using System.Text;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение верхней границы");
            var upperBound = ulong.Parse(Console.ReadLine());

            ulong a = 1, b = 0, c;

            do
            {
                c = a + b;
                a = b;
                b = c;

                Console.Write($"{c}, ");

            } while (c < upperBound);

            Console.WriteLine("\b\b  ");

            Console.ReadKey();
        }
    }
}
