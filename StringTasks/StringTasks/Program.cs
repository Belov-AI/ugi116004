using System;

namespace StringTasks
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Задача 1\n");
            //Console.WriteLine(GetHalfString("Hello, world") + '#');
            //Console.WriteLine(GetHalfString("") + '#');
            //Console.WriteLine(GetHalfString("A B C D") + '#');
            //Console.WriteLine(GetHalfString("                             ") + '#');

            //Console.WriteLine("\nЗадача 2\n");
            //Console.WriteLine("Введите температуру в °С");
            //var temperatureInCelsium = double.Parse(Console.ReadLine());
            //var temperatureInFarenheith = ConvertCelsiumToFarenheith(temperatureInCelsium);
            //Console.WriteLine($"Температура {temperatureInCelsium:F1} °С составляет {temperatureInFarenheith:F1} °F");

            //Console.WriteLine("\nЗадача 3\n");
            //Console.WriteLine("Введите адрес электронной почты");
            //var email = Console.ReadLine();
            //var index = email.IndexOf('@');
            //var mailBox = email.Substring(0, index);
            //var mailService = email.Substring(index + 1);
            //Console.WriteLine($"Ваш почтовый ящик {mailBox} находится на почтовом сервисе {mailService}");

            //Console.WriteLine("\nЗадача 3+\n");
            //Console.WriteLine("Введите адрес электронной почты");
            //email = Console.ReadLine();
            //var strings = email.Split(new[] {'@'});
            //Console.WriteLine($"Ваш почтовый ящик {strings[0]} находится на почтовом сервисе {strings[1]}");

            Console.WriteLine("\nЗадача 4\n");
            Console.WriteLine("Введите символ");
            var character = Console.ReadLine()[0];
            Console.WriteLine($"Код символа \'{character}\': 0x{Convert.ToString((int)character, 16).ToUpper()}");
            Console.WriteLine($"Следующий символ: \'{(char)((int)character + 1)}\'");

            Console.WriteLine("\nЗадача 4+\n");
            Console.WriteLine("Введите символ");
            character = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nКод символа \'{character}\': 0x{Convert.ToString((int)character, 16).ToUpper()}");
            Console.WriteLine($"Следующий символ: \'{(char)((int)character + 1)}\'");

            Console.ReadKey();
        }

        static string GetHalfString(string fullString)
        {
            var s = fullString.Replace(" ", "");
            return s.Substring(s.Length / 2);
        }

        static double ConvertCelsiumToFarenheith(double celsiumDegrees)
        {
            return celsiumDegrees * 1.8 + 32;
        }
    }
}
