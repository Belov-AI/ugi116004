using System;

namespace JapaneeseCalendar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер года н. э.");
            var year = int.Parse(Console.ReadLine());
            var yearNumber = (year - 1984) % 60;

            if (yearNumber < 0)
                yearNumber += 60;

            Console.WriteLine($"{year} г. - год {GetColor(yearNumber / 12)}{GetAnimal(yearNumber % 12)}");

            Console.ReadKey();
        }

        static string GetAnimal(int animalNumber)
        {
            switch (animalNumber)
            {
                case 0:
                    return "ой крысы";
                case 1:
                    return "ой коровы";
                case 2:
                    return "ого тигра";
                case 3:
                    return "ого зайца";
                case 4:
                    return "ого дракона";
                case 5:
                    return "ой змеи";
                case 6:
                    return "ой лошади";
                case 7:
                    return "ой овцы";
                case 8:
                    return "ой обезьяны";
                case 9:
                    return "ой курицы";
                case 10:
                    return "ой собаки";
                default:
                    return "ой свиньи";
            }
        }

        static string GetColor(int colorNumber)
        {
            if (colorNumber == 0)
                return "зелен";
            else if (colorNumber == 1)
                return "красн";
            else if (colorNumber == 2)
                return "желт";
            else if (colorNumber == 3)
                return "бел";
            else
                return "чёрн";
        }
    }
}
