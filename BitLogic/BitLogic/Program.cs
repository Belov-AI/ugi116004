using System;

namespace BitLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите двузначное число в 16-й системе счисления");
            byte x = Convert.ToByte(Console.ReadLine(), 16);

            Console.WriteLine("Введите еще одно двузначное число в 16-й системе счисления");
            byte y = Convert.ToByte(Console.ReadLine(), 16);

            Console.WriteLine($"x = {Convert.ToString(x, 2)}");
            Console.WriteLine($"y = {Convert.ToString(y, 2)}");
            Console.WriteLine($"~x = {Convert.ToString(~x, 2).Substring(24)}");
            Console.WriteLine($"~y = {Convert.ToString(~y, 2).Substring(24)}");
            Console.WriteLine($"x & y = {Convert.ToString(x & y, 2)}");
            Console.WriteLine($"x | y = {Convert.ToString(x | y, 2)}");
            Console.WriteLine($"x ^ y = {Convert.ToString(x ^ y, 2)}");

            Console.ReadKey();
        }
    }
}
