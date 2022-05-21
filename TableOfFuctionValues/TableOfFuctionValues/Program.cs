using System;

namespace TableOfFuctionValues
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите начальное значение аргумента");
            var x0 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите значение шага");
            var step = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число строк таблицы");
            var n = int.Parse(Console.ReadLine());

            //PrintHeader("x^2");

            //for(var i = 0; i < n; i++)
            //{
            //    var x = x0 + step * i;
            //    Console.WriteLine($"{x,5:F2} | {x * x:F3}");
            //}

            //Console.WriteLine();

            //PrintHeader("sin x");

            //for (var i = 0; i < n; i++)
            //{
            //    var arg = x0 + step * i;
            //    Console.WriteLine($"{arg,5:F2} | {Math.Sin(arg):F5}");
            //}

            PrintTable("x^2", x0, step, n, x => x * x);
            PrintTable("sin x", x0, step, n, x => Math.Sin(x));
                 
            Console.ReadKey();
        }

        static void PrintTable(string name, double start, double step, int rowsNumber, 
            Func<double, double> f)
        {
            PrintHeader(name);

            for(var i = 0; i < rowsNumber; i++)
            {
                var arg = start + i * step;
                Console.WriteLine($"{arg,5:F2} | {f(arg):F4}");
            }

            Console.WriteLine();
        }

        static void PrintHeader(string functionName)
        {
            Console.WriteLine($"  x   | {functionName}");
            Console.WriteLine(new string('-', 15));
        }
    }
}
