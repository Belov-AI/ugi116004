using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 5, -7, 11, 23, 56, 4 };
            PrintIntArray(array);
            Console.WriteLine();

            var clone = (int[])array.Clone();
            PrintIntArray(clone);
            Console.WriteLine();

            var copy = new int[array.Length];
            Array.Copy(array, copy, array.Length);
            PrintIntArray(copy);
            Console.WriteLine();

            Array.Sort(array);
            PrintIntArray(array);
            Console.WriteLine();

            Console.WriteLine(Array.BinarySearch(array, 11));
            Console.WriteLine(Array.BinarySearch(array, 25));

            Console.ReadKey();
        }

        private static void PrintIntArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
