using System;

namespace Logic3b
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Input("x");
            var y = Input("y");
            var z = Input("z");

            Console.WriteLine(IsOnlyOneNumberDevidedByFive(x, y, z));

            Console.ReadKey();
        }

        static int Input(string name)
        {
            Console.WriteLine($"Введите целое число {name}");
            return int.Parse(Console.ReadLine());
        }

        static bool IsOnlyOneNumberDevidedByFive(int x, int y, int z)
        {
            var a = IsDevidedByFive(x);
            var b = IsDevidedByFive(y);
            var c = IsDevidedByFive(z);

            return !a && b && c || a && !b && c || a && b && !c;
            //return !(a ^ b ^ c);
        }

        static bool IsDevidedByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
