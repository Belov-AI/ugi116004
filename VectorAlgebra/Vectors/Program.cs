using System;
using VectorAlgebra;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(-2, 4, 0);

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"2 * {a} = {2 * a}");
            Console.WriteLine($"{a} * 2 = {a * 2}"); 
            Console.WriteLine($"{a}.{b} = {a * b}");
            Console.WriteLine($"{a}x{b} = {a ^ b}");

            Console.ReadKey();
        }
    }
}
