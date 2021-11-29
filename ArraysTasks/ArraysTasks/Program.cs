using System;

namespace ArraysTasks
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите массив целых чисел в строку через пробел");
            var input = Console.ReadLine().Split();

            var numbers = new int[input.Length];
            for (var i = 0; i < numbers.Length; i++)
                numbers[i] = int.Parse(input[i]);

            PrintIntArray(numbers);
            Console.WriteLine($"Наибольший элемент: {GetMaxElement(numbers)}");
            Console.WriteLine($"Сумма элементов: {GetSum(numbers)}");
            
            Console.Write($"Массив элементов через один: ");
            PrintIntArray(GetEvenIndexesElements(numbers));

            var clone = CloneIntArray(numbers);
            Console.Write($"Массив-клон: ");
            PrintIntArray(clone);

            var answer = numbers == clone ? "Да" : "Нет";

            //string answer;
            //if (numbers == newArray)
            //    answer = "Да";
            //else
            //    answer = "Нет";

            Console.WriteLine($"Совпадает ли клон с исходным массивом? {answer}");

            ReverseIntArray(clone);
            Console.Write($"Массив в обратном порядке: ");
            PrintIntArray(clone);

            clone = CloneIntArray(numbers);
            ReplaceOddsWithZeroes(clone);
            Console.Write($"Массив c нулями вместо нечетных чисел: ");
            PrintIntArray(clone);

            Console.ReadKey();
        }

        static void PrintIntArray(int[] array)
        {
            foreach(var elem in array)
                Console.Write($"{elem} ");

            Console.WriteLine();
        }

        static int GetMaxElement(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Массив не содержит ни одного элемента");

            var max = int.MinValue;

            foreach (var elem in array)
                if (elem > max)
                    max = elem;

            return max;
        }

        static int GetSum(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Массив не содержит ни одного элемента");

            var sum = 0;

            foreach (var elem in array)
                sum += elem;

            return sum;
        }

        static int[] GetEvenIndexesElements(int[] array)
        {
            if (array.Length == 0)
                return new int[0];

            var result = new int[(array.Length + 1) / 2];

            for (var i = 0; i < result.Length; i++)
                result[i] = array[2 * i];

            return result;
        }

        static int[] CloneIntArray(int[] array)
        {
            var clone = new int[array.Length];

            for (var i = 0; i < clone.Length; i++)
                clone[i] = array[i];

            return clone;
        }

        static void ReverseIntArray(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
                (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i]);
        }

        static void ReplaceOddsWithZeroes(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0)
                    array[i] = 0;
        }
    }
}
