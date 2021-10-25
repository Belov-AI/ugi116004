using System;

namespace Coodinates
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координату x: ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y: ");
            var y = double.Parse(Console.ReadLine());

            if (x == 0)
                if ( y == 0)
                    Console.WriteLine($"Точка ({x}; {y}) совпадает с началом координат");
                else
                    Console.WriteLine($"Точка ({x}; {y}) лежит на оси Oy");
            else
                if (y == 0)
                    Console.WriteLine($"Точка ({x}; {y}) лежит на оси Ox");
                else
                    if (x > 0)
                        if (y > 0)
                            Console.WriteLine($"Точка ({x}; {y}) лежит в I квадранте");
                        else
                            Console.WriteLine($"Точка ({x}; {y}) лежит в IV квадранте");
                    else
                        if (y > 0)
                            Console.WriteLine($"Точка ({x}; {y}) лежит во II квадранте");
                        else
                            Console.WriteLine($"Точка ({x}; {y}) лежит в III квадранте");

            Console.ReadKey();
        }
    }
}
