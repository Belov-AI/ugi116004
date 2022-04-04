using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;

namespace Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new Sequence();

            Console.WriteLine("Последовательность Фибоначчи");
            PrintSequence(sequence.Fibonacci());

            Console.WriteLine("\nФакториалы");
            PrintSequence(sequence.Factorial());

            Console.ReadKey();
        }

        static void PrintSequence(IEnumerable<BigInteger> s)
        {
            var i = 0;
            foreach(var elem in s)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{i++}: {elem}");

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Enter)
                        break;
                }
            }
        }
    }
}
