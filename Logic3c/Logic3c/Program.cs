using System;


namespace Logic3c
{
    class Program
    {
        static void Main()
        {
            var x = InputCoordinate("абсциссу");
            var y = InputCoordinate("ординату");

            Console.WriteLine("Точка внутри области: " + IsInsideArea(x, y));

            Console.ReadKey();
        }

        static bool IsInsideArea(double x, double y)
        {
            return 0 <= x && x <= 1 && 0 <= y && y <= 1 &&
                (x * x + (y - 1) * (y - 1) >= 1 || (x - 1) * (x - 1) + y * y >= 1);
        } 

        static double InputCoordinate(string name)
        {
            Console.WriteLine($"Введите {name} точки");
            return double.Parse(Console.ReadLine());
        }
    }
}
