using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trashold
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            var rnd = new Random();

            for (var i = 0; i < n; i++)
                numbers[i] = rnd.Next(1000);

            PrintSequence(numbers);

            Console.WriteLine("Введите значение порога");
            var trashold = int.Parse(Console.ReadLine());

            var small = new Queue<int>();
            var big = new Queue<int>();

            foreach (var number in numbers)
                if (number < trashold)
                    small.Enqueue(number);
                else
                    big.Enqueue(number);

            //PrintSequence(small);
            //PrintSequence(big);

            PrintAndDequeue(small);
            PrintAndDequeue(big);

            Console.WriteLine(small.Count);
            Console.WriteLine(big.Count);

            Console.ReadKey();
        }

        static void PrintSequence(IEnumerable<int> sequence)
        {
            foreach (var elem in sequence)
                Console.Write($"{elem} ");

            Console.WriteLine("\n");
        }

        static void PrintAndDequeue(Queue<int> q)
        {
            while (q.Count > 0)
                Console.Write($"{q.Dequeue()} ");

            Console.WriteLine("\n");
        }
    }
}
