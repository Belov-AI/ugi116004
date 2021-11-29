using System;

namespace ValueTuples
{
    class Program
    {
        static void Main()
        {
            int x, y;

            (x, y) = (2, 7);
            PrintXY(x, y);

            (x, y) = (y, x);
            PrintXY(x, y);

            Console.ReadKey();
        }

        static void PrintXY(int x, int y)
        {
            Console.WriteLine($"x = {x}; y = {y}");
        }
    }
}
