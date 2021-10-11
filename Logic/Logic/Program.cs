using System;

namespace Logic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x:");
            var x = bool.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            var y = bool.Parse(Console.ReadLine());

            Console.WriteLine($"!x = {!x}, !y = {!y}");
            Console.WriteLine($"x & y = {x & y}, x | y = {x | y}, x^y = {x ^ y}");

            Console.ReadKey();
        }
    }
}
