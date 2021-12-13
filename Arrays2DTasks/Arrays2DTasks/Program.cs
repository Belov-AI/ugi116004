using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2DTasks
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            var numbers = new[,] { { 3, -11, 8 }, { 0, 5, 17 } };
            PrintTable(numbers);

            var answer = IsTableContainsZero(numbers) ? "Таблица содержит 0" : "Таблица не содержит 0";
            Console.WriteLine($"{answer}\n");

            PrintTable(Transpose(numbers));

            var rowNumber = rnd.Next(2, 11);
            var columnNumber = rnd.Next(2, 11);

            var matrix = new double[rowNumber, columnNumber];
            
            FillRandomA(matrix);
            PrintMatrix(matrix);

            FillRandomB(matrix);
            PrintMatrix(matrix);

            //var rand = new Random();

            //for (var i = 0; i < 20; i++)
            //{
            //    Console.Write($"{rand.Next(1000)} ");
            //}

            Console.ReadKey();
        }

        static void PrintTable(int[,] table)
        {
            for(var row = 0; row < table.GetLength(0); row++)
            {
                for (var column = 0; column < table.GetLength(1); column++)
                    Console.Write($"{table[row, column],3} ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static bool IsTableContainsZero(int[,] table)
        {
            foreach (var elem in table)
                if (elem == 0)
                    return true;

            return false;
        }

        static int[,] Transpose(int[,] array)
        {
            var result = new int[array.GetLength(1), array.GetLength(0)];

            for (var i = 0; i < result.GetLength(0); i++)
                for (var j = 0; j < result.GetLength(1); j++)
                    result[i, j] = array[j, i];

            return result;
        }

        static void PrintMatrix(double[,] matrix)
        {
            for(var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]:F5} ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void FillRandomA(double[,] matrix)
        {
            double sum = 0;

            for(var i = 0; i < matrix.GetLength(0); i++)
                for(var j = 0; j < matrix.GetLength(1); j++)
                {
                    do
                    {
                        matrix[i, j] = rnd.NextDouble();
                    } while (matrix[i, j] == 0);

                    sum += matrix[i, j];
                }

            for (var i = 0; i < matrix.GetLength(0); i++)
                for (var j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] /= sum;
        }

        static void FillRandomB(double[,] matrix)
        {
            for(var i = 0; i < matrix.GetLength(0); i++)
            {
                double sum = 0;

                for(var j = 0; j < matrix.GetLength(1); j++)
                {
                   while ((matrix[i, j] = rnd.NextDouble()) == 0) { }

                   sum += matrix[i, j];
                }

                for (var j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] /= sum;
            }
        }
    }
}
