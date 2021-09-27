using System;

namespace FunWithTypes
{
    class Program
    {
        static void Main()
        {
            double pi = Math.PI;
            int oneThousand = (int)1000L; 
            float piF = (float)pi;
            float oneThousandPi = (float)(pi * oneThousand);
            int rounded1000Pi = (int)Math.Round(oneThousandPi); //тут должно правильно округляться
            int integerPart = (int)Math.Floor(oneThousandPi); //а тут нужно вычислить целую часть
            Console.WriteLine(rounded1000Pi);
            Console.WriteLine(integerPart);

            double a = 10;
            a += 0.5; //надо исправить, чтоб работало
            Console.WriteLine(a);

            var b = "15";
            var c = a + double.Parse(b); //тут что-то не так! надо поправить
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
