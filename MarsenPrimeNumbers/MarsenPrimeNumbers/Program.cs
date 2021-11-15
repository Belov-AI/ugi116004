using System;

namespace MarsenPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const long UpperBound = long.MaxValue / 2;

            var p = (long)2;
            var power = (long)2;

            while (power < UpperBound)
            {
                power *= 2;
                var mp = power - 1;

                if (IsPrime(p) && IsPrime(mp))
                    Console.WriteLine($"p = {p} Mp = {mp}");

                p++;
            }

            Console.ReadKey();
        }

        static bool IsPrime(long number)
        {
            var d = (long)2;

            while(d < Math.Sqrt(number))
            {
                if(number % d == 0)
                    return false;

                d++;
            }

            return true;
        }
    }
}
