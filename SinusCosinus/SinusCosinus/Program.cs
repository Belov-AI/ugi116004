using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinusCosinus
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSinCos(15);
            PrintSinCos(37);
            PrintSinCos(113);

            Console.WriteLine("Введите произвольный угол в градусах");
            var angleInDegrees = double.Parse(Console.ReadLine());
            PrintSinCos(angleInDegrees);

            Console.ReadKey();
        }

        static void PrintSinCos(double angleInDegrees)
        {
            var angleInRadians = ConvertDegreesToRadians(angleInDegrees);

            Console.WriteLine("sin " + angleInDegrees + "° = " + CalculateRoundedSinus(angleInRadians));
            Console.WriteLine("cos " + angleInDegrees + "° = " + CalculateRoundedCosinus(angleInRadians));
        }

        private static double CalculateRoundedCosinus(double angleInRadians)
        {
            return Math.Round(Math.Sin(angleInRadians), 3);
        }

        private static double CalculateRoundedSinus(double angleInRadians)
        {
            return Math.Round(Math.Sin(angleInRadians), 3);
        }

        private static double ConvertDegreesToRadians(double x)
        {
            return x * Math.PI / 180;
        }



    }
}
