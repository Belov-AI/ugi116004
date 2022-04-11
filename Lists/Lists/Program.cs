using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int> { 1, 2, 5, 0 };
            var lines = new List<string>();

            numbers[1] = 7;
            var n = numbers[0] + numbers[1];
            Console.WriteLine($"n = {n}");

            lines.Add("Первая строка");
            lines.Add("Вторая строка");

            Console.WriteLine($"numbers capacity = {numbers.Capacity}");
            numbers.Add(9);            
            Console.WriteLine($"numbers capacity = {numbers.Capacity}");

            numbers.Insert(2, 4);
            //numbers[2] = 4;
            numbers.Add(4);

            Console.WriteLine($"Первое вхождение \"4\" по индексу {numbers.IndexOf(4)}");
            Console.WriteLine($"Последнее вхождение \"4\" по индексу {numbers.LastIndexOf(4)}");
            Console.WriteLine($"Первое вхождение \"11\" по индексу {numbers.IndexOf(11)}");

            numbers.RemoveAt(6);
            numbers.Remove(4);

            var answer = numbers.Contains(1) ? "Да" : "Нет";
            Console.WriteLine($"Есть ли в списке 1? {answer}");
            answer = numbers.Contains(11) ? "Да" : "Нет";
            Console.WriteLine($"Есть ли в списке 11? {answer}");

            numbers.Clear();

            Console.ReadKey();
        }
    }
}
