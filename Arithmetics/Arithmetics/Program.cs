﻿using System;

namespace Arithmetics
{
    class Program
    {
        static void Main()
        {
            int n = 2;
            const double g = 9.8;

            Console.WriteLine(n);
            Console.WriteLine(g);
            Console.WriteLine(n++ + ++n);
            Console.WriteLine(n);

            int x = 3, y = 4, z = 5;
            Console.WriteLine(x + y * z);

            x = y += 2;
            Console.WriteLine(x);

            double angle = Math.PI/6;
            double sinusX = Math.Sin(angle);
            Console.WriteLine(sinusX);

            var k = "1";
            Console.WriteLine(k);

            angle = x;
            Console.WriteLine(angle);

            x = (int)Math.Pow(2, 3);
            Console.WriteLine(x);

            x = (int)Math.Sqrt(3);
            Console.WriteLine(x);

            x = (int)Math.Round(Math.Sqrt(3));
            Console.WriteLine(x);

            Console.WriteLine((int)(-1.5));
            Console.WriteLine(Math.Floor(-1.5));

            int integerNumber;
            long longNumber;

            checked
            {
                longNumber = 100; //число 100
                integerNumber = (int)longNumber;
                Console.WriteLine(integerNumber);
               
                //longNumber = 3000000000L;
                //integerNumber = (int)longNumber;
                //Console.WriteLine(integerNumber);               
            }

            Console.WriteLine(Square(5));
            
            Console.ReadKey();
        }

        /// <summary>
        /// Вычисление квадрата целого числа
        /// </summary>
        /// <param name="number">исходное число</param>
        /// <returns>квадрат числа</returns>
        static int Square(int number)
        {
            return number * number;
        }
    }
}
