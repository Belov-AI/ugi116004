using System;

namespace Delegates
{
    delegate double Function(double x);

    class Program
    {
        static void Main()
        {
            Function f;

            f = Math.Sin;
            Console.WriteLine($"sin(п/4) = {f(Math.PI/4)}");

            f = Square;
            Console.WriteLine($"(п/4)^2 = {f(Math.PI / 4)}");

            var calc = new Calculator();
            f = calc.Cube;
            Console.WriteLine($"(п/4)^3 = {f(Math.PI / 4)}");

            var first = new double[] { 1, 2, 3, 4, 5 };
            var second = new double[] { 6, 7, 8, 9 };

            PrintArray(Zip(first, second, Sum));
            PrintArray(Zip(first, second, delegate (double x, double y) { return x + y; }));
            PrintArray(Zip(first, second, (x, y) => x + y));
            PrintArray(Zip(first, second, (x, y) => x * y));

            Console.ReadKey();
        }

        static double Square(double x)
        {
            return x * x;
        }

        static double[] Zip(double[] x, double[] y, Func<double,double,double> z)
        {
            var n = Math.Min(x.Length, y.Length);
            var rezult = new double[n];

            for (var i = 0; i < n; i++)
                rezult[i] = z(x[i], y[i]);

            return rezult;
        }

        static void PrintArray(double[] array)
        {
            for (var i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            Console.WriteLine();
        }

        static double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
